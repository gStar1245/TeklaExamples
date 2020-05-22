using System.Collections.Generic;
using Tekla.Structures.Geometry3d;
using Tekla.Structures.Plugins;
using Tekla.Structures.Drawing;
using Tekla.Structures.Drawing.Tools;
using Tekla.Structures.Drawing.UI;

namespace EllipsePlugin
{
    [Plugin("EllipsePlugin")]
    [InputObjectDependency(PluginBase.InputObjectDependency.DEPENDENT)]
    [PluginUserInterface("EllipsePlugin.EllipsePluginForm")]
    [UpdateMode(DrawingPluginBase.UpdateMode.DRAWING_OPENED)]
    public class EllipsePlugin : DrawingPluginBase
    {
        private EllipsePluginData Data { get; set; }

        public EllipsePlugin(EllipsePluginData data)
        {
            Data = data;
        }

        public override List<InputDefinition> DefineInput()
        {
            List<InputDefinition> inputs = new List<InputDefinition>();
            DrawingHandler drawingHandler = new DrawingHandler();

            if (drawingHandler.GetConnectionStatus())
            {
                Picker picker = drawingHandler.GetPicker();

                ViewBase view;
                PointList pointList;

                StringList promts = new StringList();
                promts.Add("able_Pick_center_point");
                promts.Add("able_Pick_major_point");

                picker.PickPoints(2, promts, out pointList, out view);
                inputs.Add(InputDefinitionFactory.CreateInputDefinition(view, pointList));
            }

            return inputs;
        }

        public override bool Run(List<InputDefinition> inputs)
        {
            ViewBase view = InputDefinitionFactory.GetView(inputs[0]);
            PointList points = InputDefinitionFactory.GetPoints(inputs[0]);
            if(Distance.PointToPoint(points[0], points[1]) <= Point.EPSILON_SQUARED)
            {
                return false;
            }

            Data.CheckDefaults(this);
            EllipsePluginShapes.DrawAnEllipse(view, points[0], points[1], Data.MajorAxis, Data.MinorAxis, Data.Precision);
            return true;
        }
    }
}
