using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tekla.Structures.Datatype;
using TSG = Tekla.Structures.Geometry3d;
using TSM = Tekla.Structures.Model;
using TSPlugins = Tekla.Structures.Plugins;

namespace FormPlugin
{
    public class StructureData
    {
        [TSPlugins.StructuresField("height")]
        public double height;
    }

    [TSPlugins.Plugin("FormPlugin")]
    [TSPlugins.PluginUserInterface("FormPlugin.MainForm")]

    public class MainPlugin : TSPlugins.PluginBase
    {
        private readonly TSM.Model _model;
        private readonly StructureData _data;

        public TSM.Model model { get { return _model; } }

        public MainPlugin(StructureData data)
        {
            _model = new TSM.Model();
            _data = data;
        }

        public override List<InputDefinition> DefineInput()
        {
            TSM.UI.Picker PointPicker = new TSM.UI.Picker();
            List<InputDefinition> PointList = new List<InputDefinition>();
            TSG.Point InputPoint = PointPicker.PickPoint();
            InputDefinition InputDef = new InputDefinition(InputPoint);
            PointList.Add(InputDef);

            return PointList;
        }

        public override bool Run(List<InputDefinition> Input)
        {
            try
            {
                double Height = _data.height;

                TSG.Point StartPoint = (TSG.Point)Input[0].GetInput();

                TSG.Point EndPoint = new TSG.Point(StartPoint);
                EndPoint.Z += Height;

                TSM.Beam Column = new TSM.Beam(StartPoint, EndPoint);
                Column.Profile.ProfileString = "HEA400";

                Column.Insert();

                _model.CommitChanges();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return true;
        }
    }
}
