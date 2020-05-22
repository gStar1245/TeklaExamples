using System;
using System.Collections.Generic;

using Tekla.Structures.Model.UI;
using Tekla.Structures.Plugins;
using TSG = Tekla.Structures.Geometry3d;
using TSM = Tekla.Structures.Model;

namespace BeamPlugin
{
    public class StructruesData
    {
        [StructuresField("LengthFactor")]
        public double LengthFactor;
        [StructuresField("Profile")]
        public string Profile;
    }

    [Plugin("BeamPlugin")]
    [PluginUserInterface("BeamPlugin.BeamPluginForm")]
    public class BeamPlugin : PluginBase
    {
        private StructruesData Data { get; set; }

        private double _LengthFactor;
        private string _Profile;

        public BeamPlugin(StructruesData data)
        {
            TSM.Model model = new TSM.Model();
            Data = data;
        }

        public override bool Run(List<InputDefinition> Input)
        {
            try
            {
                GetValuesFromDialog();

                TSG.Point Point1 = (TSG.Point)(Input[0]).GetInput();
                TSG.Point Point2 = (TSG.Point)(Input[1]).GetInput();
                TSG.Point LengthVector = new TSG.Point(Point2.X - Point1.X, Point2.Y - Point1.Y, Point2.Z - Point1.Z);

                if(_LengthFactor > 0)
                {
                    Point2.X = _LengthFactor * LengthVector.X + Point1.X;
                    Point2.Y = _LengthFactor * LengthVector.Y + Point1.Y;
                    Point2.Z = _LengthFactor * LengthVector.Z + Point1.Z;
                }
                CreateBeam(Point1, Point2);
            }
            catch(Exception Ex)
            {
                Console.WriteLine("Exception : " + Ex.ToString());
            }

            return true;
        }

        public override List<InputDefinition> DefineInput()
        {
            Picker BeamPicker = new Picker();
            List<InputDefinition> PointList = new List<InputDefinition>();

            TSG.Point Point1 = BeamPicker.PickPoint();
            TSG.Point Point2 = BeamPicker.PickPoint();

            InputDefinition Input1 = new InputDefinition(Point1);
            InputDefinition Input2 = new InputDefinition(Point2);

            PointList.Add(Input1);
            PointList.Add(Input2);

            return PointList;
        }

        private void CreateBeam(TSG.Point Point1, TSG.Point Point2)
        {
            TSM.Beam MyBeam = new TSM.Beam(Point1, Point2);

            MyBeam.Profile.ProfileString = _Profile;
            MyBeam.Finish = "PAINT";
            MyBeam.Insert();
        }

        private void GetValuesFromDialog()
        {
            _LengthFactor = Data.LengthFactor;
            _Profile = Data.Profile;

            if(IsDefaultValue(_LengthFactor))
            {
                _LengthFactor = 2.0;
            }
            if(IsDefaultValue(_Profile))
            {
                _Profile = "HEA300";
            }
        }
    }
}
