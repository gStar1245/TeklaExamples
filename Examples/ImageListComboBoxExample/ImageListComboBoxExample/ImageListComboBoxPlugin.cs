using System;
using System.Collections.Generic;

using TSG = Tekla.Structures.Geometry3d;
using Tekla.Structures.Model.UI;
using Tekla.Structures.Plugins;
using TSM = Tekla.Structures.Model;

namespace ImageListComboBoxExample
{
    public class StructureData
    {
        [StructuresField("Color")]
        public int Color;
        [StructuresField("Profile")]
        public string Profile;
    }

    [Plugin("ImageListComboBoxPlugin")]
    [PluginUserInterface("ImageListComboBoxExample.PluginForm")]
    public class ImageListComboBoxPlugin : PluginBase
    {
        private StructureData Data { get; set; }
        private int _Color;
        private string _Profile;

        public ImageListComboBoxPlugin(StructureData data)
        {
            TSM.Model model = new TSM.Model();
            Data = data;
        }

        public override List<InputDefinition> DefineInput()
        {
            Picker BeamPicker = new Picker();
            List<InputDefinition> PointList = new List<InputDefinition>();

            TSG.Point point1 = BeamPicker.PickPoint();
            TSG.Point point2 = BeamPicker.PickPoint();

            InputDefinition input1 = new InputDefinition(point1);
            InputDefinition input2 = new InputDefinition(point2);

            PointList.Add(input1);
            PointList.Add(input2);

            return PointList;
        }

        public override bool Run(List<InputDefinition> Input)
        {
            try
            {
                GetValuesFromDialog();

                TSG.Point point1 = (TSG.Point)(Input[0]).GetInput();
                TSG.Point point2 = (TSG.Point)(Input[1]).GetInput();

                CreateBeam(point1, point2);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return true;
        }

        private void GetValuesFromDialog()
        {
            _Color = Data.Color;
            _Profile = Data.Profile;

            if (IsDefaultValue(_Color))
            {
                _Color = 2;
            }
            if (IsDefaultValue(_Profile))
            {
                _Profile = "HEA300";
            }
        }

        private void CreateBeam(TSG.Point point1, TSG.Point point2)
        {
            TSM.Beam beam = new TSM.Beam();

            beam.Profile.ProfileString = _Profile;
            beam.Class = _Color.ToString();
            beam.Insert();

        }
    }
}
