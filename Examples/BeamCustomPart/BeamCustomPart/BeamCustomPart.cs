using System;

using TSG = Tekla.Structures.Geometry3d;
using Tekla.Structures.Plugins;
using Tekla.Structures.Catalogs;
using TSM = Tekla.Structures.Model;

namespace BeamCustomPart
{
    public class StructuresData
    {
        [StructuresField("LengthFactor")]
        public double LengthFactor;
        [StructuresField("Profile")]
        public string Profile;
    }

    [Plugin("BeamCustomPart")]
    [PluginUserInterface("BeamCustomPart.BeamCustomPartForm")]
    class BeamCustomPart : CustomPartBase
    {
        #region Field
        private double LengthFactor;
        private string Profile;
        private double FlangeThickness;
        private double FlangeWidth;
        private double WebHeight;
        private double WebThickness;
        #endregion

        #region Propertiy
        public StructuresData Data { get; set; }
        #endregion

        #region Constructor
        public BeamCustomPart(StructuresData data)
        {
            this.Data = data;
        }
        #endregion

        public override bool Run()
        {
            try
            {
                GetValuesFromDialog();

                TSG.Point Point1 = (TSG.Point)this.Positions[0];
                TSG.Point Point2 = (TSG.Point)this.Positions[1];
                TSG.Point LengthVector = new TSG.Vector(Point2.X - Point1.X, Point2.Y - Point1.Y, Point2.Z - Point1.Z);

                if (this.LengthFactor > 0)
                {
                    Point2.X = this.LengthFactor * LengthVector.X + Point1.X;
                    Point2.Y = this.LengthFactor * LengthVector.Y + Point1.Y;
                    Point2.Z = this.LengthFactor * LengthVector.Z + Point1.Z;
                }

                CreateTaperedBeam(Point1, Point2);
            }
            catch(Exception Ex)
            {
                TSM.Operations.Operation.DisplayPrompt(Ex.Message);
            }

            return true;
        }

        // Top Plate
        private void CreateTopFlangePlate(TSG.Point Point1, TSG.Point Point2)
        {
            TSM.Beam myBeam = new TSM.Beam(new TSG.Point(Point1), new TSG.Point(Point2));
            myBeam.StartPoint.Y = myBeam.StartPoint.Y + this.WebHeight / 2.0;
            myBeam.EndPoint.Y = myBeam.EndPoint.Y + this.WebHeight / 2.0;

            string profileString = "PL" + this.FlangeThickness.ToString() + "*" + this.FlangeWidth.ToString();
            myBeam.Profile.ProfileString = profileString.Replace(",", ".");

            myBeam.Finish = "PAINT";
            myBeam.Position.Depth = TSM.Position.DepthEnum.MIDDLE;
            myBeam.Position.Plane = TSM.Position.PlaneEnum.RIGHT;
            myBeam.Position.Rotation = TSM.Position.RotationEnum.BELOW;
            myBeam.Insert();
        }

        // Bottom Plate
        private void CreateBottomFlangePlate(TSG.Point Point1, TSG.Point Point2)
        {
            TSM.Beam myBeam = new TSM.Beam(new TSG.Point(Point1), new TSG.Point(Point2));

            myBeam.StartPoint.Y = myBeam.StartPoint.Y - this.WebHeight / 2.0;
            myBeam.EndPoint.Y = myBeam.EndPoint.Y - this.WebThickness / 2.0;

            string profileString = "PL" + this.FlangeThickness.ToString() + "*" + this.FlangeWidth.ToString();
            myBeam.Profile.ProfileString = profileString.Replace(",", ".");
            myBeam.Finish = "PAINT";
            myBeam.Position.Depth = TSM.Position.DepthEnum.MIDDLE;
            myBeam.Position.Plane = TSM.Position.PlaneEnum.LEFT;
            myBeam.Position.Rotation = TSM.Position.RotationEnum.TOP;
            myBeam.Insert();
        }

        private void CreateWebPlate(TSG.Point Point1, TSG.Point Point2)
        {
            TSM.Beam myBeam = new TSM.Beam(new TSG.Point(Point1), new TSG.Point(Point2));

            string profileString = "PL" + this.WebThickness.ToString() + "*" + (this.WebHeight - 2.0 * this.FlangeThickness).ToString();
            myBeam.Profile.ProfileString = profileString.Replace(",", ".");
            myBeam.Finish = "PAINT";
            myBeam.Position.Depth = TSM.Position.DepthEnum.MIDDLE;
            myBeam.Position.Plane = TSM.Position.PlaneEnum.MIDDLE;
            myBeam.Position.Rotation = TSM.Position.RotationEnum.BACK;

            myBeam.Insert();
        }

        private void CreateTaperedBeam(TSG.Point Point1, TSG.Point Point2)
        {
            ProfileItem item = null;

            ParametricProfileItem parametricItem = new ParametricProfileItem();
            if (parametricItem.Select(this.Profile) && parametricItem.ProfileItemType == ProfileItem.ProfileItemTypeEnum.PROFILE_I)
                item = parametricItem;

            if (item == null)
            {
                LibraryProfileItem libraryItem = new LibraryProfileItem();
                if (libraryItem.Select(this.Profile) && libraryItem.ProfileItemType == ProfileItem.ProfileItemTypeEnum.PROFILE_I)
                {
                    item = libraryItem;
                }
            }

            if (item != null)
            {
                foreach(ProfileItemParameter p in item.aProfileItemParameters)
                {
                    if (p.Symbol == "h")
                        this.WebHeight = p.Value;
                    if (p.Symbol == "s")
                        this.WebThickness = p.Value;
                    if (p.Symbol == "b")
                        this.FlangeWidth = p.Value;
                    if (p.Symbol == "t")
                        this.FlangeThickness = p.Value;
                }

                this.CreateTopFlangePlate(new TSG.Point(Point1), new TSG.Point(Point2));
                this.CreateBottomFlangePlate(new TSG.Point(Point1), new TSG.Point(Point2));
                this.CreateWebPlate(new TSG.Point(Point1), new TSG.Point(Point2));
            }
        }

        private void GetValuesFromDialog()
        {
            this.LengthFactor = this.Data.LengthFactor;
            this.Profile = this.Data.Profile;
            if(this.IsDefaultValue(this.LengthFactor))
            {
                this.LengthFactor = 2.0;
            }
            if (this.IsDefaultValue(this.Profile))
            {
                this.Profile = "HEA300";
            }
        }
    }
}
