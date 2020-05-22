using System;

using Tekla.Structures.Plugins;
using Tekla.Structures.Catalogs;
using TSM = Tekla.Structures.Model;
using TSG = Tekla.Structures.Geometry3d;

namespace BeamCustomPart2
{
    public class StructuresData
    {
        [StructuresField("LengthFactor")]
        public double LengthFactor;
        [StructuresField("Profile")]
        public string Profile;
    }

    [Plugin("BeamCustomPart2")]
    [PluginUserInterface("BeamCustomPart2.BeamCustomPartForm")]
    public class BeamCustomPart2 : CustomPartBase
    {
        private double lengthFactor;
        private string profile;
        private double flangeThickness;
        private double flangeWidth;
        private double webHeight;
        private double webThickness;

        private StructuresData Data;

        public BeamCustomPart2(StructuresData data)
        {
            Data = data;
        }

        public override bool Run()
        {
            try
            {
                GetValuesFromDialog();

                TSG.Point Point1 = (TSG.Point)this.Positions[0];
                TSG.Point Point2 = (TSG.Point)this.Positions[1];
                TSG.Point lengthVector = new TSG.Point(Point2.X - Point1.X, Point2.Y - Point1.Y, Point2.Z - Point1.Z);

                if (this.lengthFactor > 0)
                {
                    Point2.X = this.lengthFactor * lengthVector.X + Point1.X;
                    Point2.Y = this.lengthFactor * lengthVector.Y + Point1.Y;
                    Point2.Z = this.lengthFactor * lengthVector.Z + Point1.Z;
                }

                CreateTaperedBeam(Point1, Point2);
            }
            catch (Exception Ex)
            {
                TSM.Operations.Operation.DisplayPrompt(Ex.Message);
            }

            return true;
        }

        public void CreateTopFlangePlate(TSG.Point Point1, TSG.Point Point2)
        {
            TSM.Beam myBeam = new TSM.Beam(new TSG.Point(Point1), new TSG.Point(Point2));
            myBeam.StartPoint.Y = myBeam.StartPoint.Y + this.webHeight / 2.0;
            myBeam.EndPoint.Y = myBeam.EndPoint.Y + this.webHeight / 2.0;

            string profileString = "PL" + this.flangeThickness.ToString() + "*" + this.flangeWidth.ToString();
            myBeam.Profile.ProfileString = profileString.Replace(",", ".");

            myBeam.Finish = "PAINT";
            myBeam.Position.Depth = TSM.Position.DepthEnum.MIDDLE;
            myBeam.Position.Plane = TSM.Position.PlaneEnum.RIGHT;
            myBeam.Position.Rotation = TSM.Position.RotationEnum.BELOW;
            myBeam.Insert();
        }

        public void CreateBottomFlangePlate(TSG.Point Point1, TSG.Point Point2)
        {
            TSM.Beam myBeam = new TSM.Beam(new TSG.Point(Point1), new TSG.Point(Point2));
            myBeam.StartPoint.Y = myBeam.StartPoint.Y - this.webHeight / 2.0;
            myBeam.EndPoint.Y = myBeam.EndPoint.Y - this.webHeight / 2.0;

            string profileString = "PL" + this.flangeThickness.ToString() + "*" + this.flangeWidth.ToString();
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

            string profileString = "Pl" + this.webThickness.ToString() + "*" + (this.webHeight - 2.0 * this.flangeThickness).ToString();
            myBeam.Profile.ProfileString = profileString.Replace(",", ".");
            myBeam.Finish = "PAINTT";
            myBeam.Position.Depth = TSM.Position.DepthEnum.MIDDLE;
            myBeam.Position.Plane = TSM.Position.PlaneEnum.MIDDLE;
            myBeam.Position.Rotation = TSM.Position.RotationEnum.BACK;
            myBeam.Insert();
        }

        private void CreateTaperedBeam(TSG.Point Point1, TSG.Point Point2)
        {
            ProfileItem item = null;

            ParametricProfileItem parametricItem = new ParametricProfileItem();
            if (parametricItem.Select(this.profile) && parametricItem.ProfileItemType == ProfileItem.ProfileItemTypeEnum.PROFILE_I)
                item = parametricItem;

            if (item == null)
            {
                LibraryProfileItem libraryItem = new LibraryProfileItem();
                if (libraryItem.Select(this.profile) && libraryItem.ProfileItemType == ProfileItem.ProfileItemTypeEnum.PROFILE_I)
                    item = libraryItem;
            }

            if (item != null)
            {
                foreach (ProfileItemParameter p in item.aProfileItemParameters)
                {
                    if (p.Symbol == "h")
                        this.webHeight = p.Value;
                    if (p.Symbol == "s")
                        this.webThickness = p.Value;
                    if (p.Symbol == "b")
                        this.flangeWidth = p.Value;
                    if (p.Symbol == "t")
                        this.flangeThickness = p.Value;
                }

                this.CreateTopFlangePlate(new TSG.Point(Point1), new TSG.Point(Point2));
                this.CreateBottomFlangePlate(new TSG.Point(Point1), new TSG.Point(Point2));
                this.CreateWebPlate(new TSG.Point(Point1), new TSG.Point(Point2));
            }
        }

        private void GetValuesFromDialog()
        {
            lengthFactor = Data.LengthFactor;
            profile = Data.Profile;

            if(IsDefaultValue(lengthFactor))
            {
                lengthFactor = 2.0;
            }
            if(IsDefaultValue(profile))
            {
                profile = "HEA300";
            }
        }
    }
}
