using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

using Tekla.Structures;
using Tekla.Structures.Drawing.UI;
using Tekla.Structures.Drawing;
using Tekla.Structures.Model;
using Tekla.Structures.Geometry3d;
using TSMUI = Tekla.Structures.Model.UI;
using ModelObject = Tekla.Structures.Model.ModelObject;
using Part = Tekla.Structures.Drawing.Part;

namespace DimensionExample
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            try
            {
                DrawingHandler drawingHandler = new DrawingHandler();

                if (drawingHandler.GetConnectionStatus())
                {
                    Drawing CurrentDrawing = drawingHandler.GetActiveDrawing();
                    if(CurrentDrawing != null)
                    {
                        DrawingObjectEnumerator drawingObjectEnumerator = CurrentDrawing.GetSheet().GetAllObjects(typeof(Part));

                        foreach(Part myPart in drawingObjectEnumerator)
                        {
                            View view = myPart.GetView() as View;
                            TransformationPlane SavePlane = new Model().GetWorkPlaneHandler().GetCurrentTransformationPlane();
                            new Model().GetWorkPlaneHandler().SetCurrentTransformationPlane(new TransformationPlane(view.DisplayCoordinateSystem));

                            Identifier Identifier = myPart.ModelIdentifier;
                            ModelObject modelObject = new Model().SelectModelObject(Identifier);

                            PointList PointList = new PointList();
                            Beam myBeam = new Beam();
                            if (modelObject.GetType().Equals(typeof(Beam)))
                            {
                                myBeam.Identifier = Identifier;
                                myBeam.Select();

                                PointList.Add(myBeam.StartPoint);
                                PointList.Add(myBeam.EndPoint);
                            }

                            ViewBase viewBase = myPart.GetView();
                            StraightDimensionSet.StraightDimensionSetAttributes attr = new StraightDimensionSet.StraightDimensionSetAttributes(myPart);

                            if (myBeam.StartPoint.X != myBeam.EndPoint.X)
                            {
                                StraightDimensionSet XDimensions = new StraightDimensionSetHandler().CreateDimensionSet(viewBase, PointList, new Vector(0, 100, 0), 100, attr);
                                XDimensions.Insert();
                            }

                            new Model().GetWorkPlaneHandler().SetCurrentTransformationPlane(SavePlane);
                        }
                    }

                }
            }
            catch(Exception EX)
            {
                Console.WriteLine("Exception : " + EX.ToString());
            }
        }
    }
}
