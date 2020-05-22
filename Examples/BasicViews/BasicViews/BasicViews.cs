using System;
using System.Collections;
using System.Windows.Forms;

using TSM = Tekla.Structures.Model;
using TSD = Tekla.Structures.Drawing;
using TSG = Tekla.Structures.Geometry3d;
using TSMUI = Tekla.Structures.Model.UI;

namespace BasicViews
{
    public partial class BasicViews : Form
    {
        #region Field
        private TSM.Model model = new TSM.Model();
        private TSD.DrawingHandler drawingHandler = new TSD.DrawingHandler();
        #endregion

        public BasicViews()
        {
            InitializeComponent();

            BtnCreate.Click += BtnCreate_Click;
        }

        #region Event : Click

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            TSM.TransformationPlane current = model.GetWorkPlaneHandler().GetCurrentTransformationPlane();

            try
            {
                model.GetWorkPlaneHandler().SetCurrentTransformationPlane(new TSM.TransformationPlane());
                TSM.ModelObjectEnumerator selectedModelObjects = new TSMUI.ModelObjectSelector().GetSelectedObjects();

                TSD.GADrawing MyDrawing = null;

                while (selectedModelObjects.MoveNext())
                {
                    TSG.CoordinateSystem ModelObjectCoordSys;

                    string ModelObjectName;
                    string DrawingName = "Part basic views" + (selectedModelObjects.Current as TSM.ModelObject).Identifier;

                    GetCoordinateSystemAndNameOfSelectedObject(selectedModelObjects, out ModelObjectCoordSys, out ModelObjectName);

                    MyDrawing = new TSD.GADrawing(DrawingName, "standard");
                    MyDrawing.Insert();

                    if (openDrawings.Checked)
                        drawingHandler.SetActiveDrawing(MyDrawing, true);
                    else
                        drawingHandler.SetActiveDrawing(MyDrawing, false);

                    ArrayList Parts = new ArrayList();

                    if (selectedModelObjects.Current is TSM.Part)
                        Parts.Add(selectedModelObjects.Current.Identifier);
                    else if (selectedModelObjects.Current is TSM.Assembly)
                        Parts = GetAssemblyParts(selectedModelObjects.Current as TSM.Assembly);
                    else if (selectedModelObjects.Current is TSM.BaseComponent)
                        Parts = GetComponentParts(selectedModelObjects.Current as TSM.BaseComponent);
                    else if (selectedModelObjects.Current is TSM.Task)
                        Parts = GetTaskParts(selectedModelObjects.Current as TSM.Task);

                    CreateViews(ModelObjectCoordSys, ModelObjectName, MyDrawing, Parts);

                    MyDrawing.PlaceViews();

                    drawingHandler.CloseActiveDrawing(true);
                }

                if (MyDrawing != null && openDrawings.Checked)
                    drawingHandler.SetActiveDrawing(MyDrawing);

                model.GetWorkPlaneHandler().SetCurrentTransformationPlane(current);
            }
            catch (Exception Ex)
            {
                model.GetWorkPlaneHandler().SetCurrentTransformationPlane(current);
                MessageBox.Show(Ex.Message);
            }
        }
        #endregion

        private static void GetCoordinateSystemAndNameOfSelectedObject(TSM.ModelObjectEnumerator SelectedModelObjects, out TSG.CoordinateSystem ModelObjectCoordSys, out string ModelObjectName)
        {
            if (SelectedModelObjects.Current is TSM.Part)
            {
                ModelObjectCoordSys = (SelectedModelObjects.Current as TSM.Part).GetCoordinateSystem();
                ModelObjectName = (SelectedModelObjects.Current as TSM.Part).GetPartMark();
            }
            else if (SelectedModelObjects.Current is TSM.Assembly)
            {
                ModelObjectCoordSys = (SelectedModelObjects.Current as TSM.Assembly).GetCoordinateSystem();
                ModelObjectName = (SelectedModelObjects.Current as TSM.Assembly).AssemblyNumber.Prefix + (SelectedModelObjects.Current as TSM.Assembly).AssemblyNumber.StartNumber;
            }
            else if (SelectedModelObjects.Current is TSM.BaseComponent)
            {
                ModelObjectCoordSys = (SelectedModelObjects.Current as TSM.BaseComponent).GetCoordinateSystem();
                ModelObjectName = (SelectedModelObjects.Current as TSM.BaseComponent).Name;
            }
            else if (SelectedModelObjects.Current is TSM.Task)
            {
                ModelObjectCoordSys = new TSG.CoordinateSystem();
                ModelObjectName = (SelectedModelObjects.Current as TSM.Task).Name;
            }
            else
            {
                ModelObjectCoordSys = new TSG.CoordinateSystem();
                ModelObjectName = string.Empty;
            }
        }

        #region Coordinate System Calcuations

        readonly TSG.Vector UpDirection = new TSG.Vector(0, 0, 1.0);

        private TSG.CoordinateSystem GetBasicViewsCoordinateSystemForFrontView(TSG.CoordinateSystem objectCoordinateSystem)
        {
            TSG.CoordinateSystem result = new TSG.CoordinateSystem
            {
                Origin = new TSG.Point(objectCoordinateSystem.Origin),
                AxisX = new TSG.Vector(objectCoordinateSystem.AxisX) * -1.0,
                AxisY = new TSG.Vector(objectCoordinateSystem.AxisY)
            };

            TSG.Vector tempVector = (result.AxisX.Cross(UpDirection));

            if (tempVector == new TSG.Vector())
            {
                tempVector = (objectCoordinateSystem.AxisX.Cross(UpDirection));
            }

            result.AxisX = tempVector.Cross(UpDirection).GetNormal();
            result.AxisY = UpDirection.GetNormal();

            return result;
        }

        private TSG.CoordinateSystem GetBasicViewsCoordinateSystemForTopView(TSG.CoordinateSystem objectCoordinateSystem)
        {
            TSG.CoordinateSystem result = new TSG.CoordinateSystem()
            {
                Origin = new TSG.Point(objectCoordinateSystem.Origin),
                AxisX = new TSG.Vector(objectCoordinateSystem.AxisX) * -1.0,
                AxisY = new TSG.Vector(objectCoordinateSystem.AxisY)
            };

            TSG.Vector tempVector = (result.AxisX.Cross(UpDirection));
            if (tempVector == new TSG.Vector())
            {
                tempVector = (objectCoordinateSystem.AxisY.Cross(UpDirection));
            }

            result.AxisX = tempVector.Cross(UpDirection).GetNormal();
            result.AxisY = UpDirection.GetNormal();

            return result;
        }

        private TSG.CoordinateSystem GetBasicViewsCoordinateSystemForEndView(TSG.CoordinateSystem objectCoordinateSystem)
        {
            TSG.CoordinateSystem result = new TSG.CoordinateSystem()
            {
                Origin = new TSG.Point(objectCoordinateSystem.Origin),
                AxisX = new TSG.Vector(objectCoordinateSystem.AxisX) * -1.0,
                AxisY = new TSG.Vector(objectCoordinateSystem.AxisY)
            };

            TSG.Vector tempVector = (result.AxisX.Cross(UpDirection));

            if (tempVector == new TSG.Vector())
            {
                tempVector = (objectCoordinateSystem.AxisX.Cross(UpDirection));
            }

            result.AxisX = tempVector;
            result.AxisY = UpDirection;

            return result;
        }
        #endregion

        #region Model object child part fetching

        private static ArrayList GetAssemblyParts(TSM.Assembly assembly)
        {
            ArrayList Parts = new ArrayList();
            IEnumerator AssemblyChildren = (assembly).GetSecondaries().GetEnumerator();

            Parts.Add((assembly).GetMainPart().Identifier);

            while (AssemblyChildren.MoveNext())
                Parts.Add((AssemblyChildren.Current as TSM.ModelObject).Identifier);

            return Parts;
        }

        private static ArrayList GetComponentParts(TSM.BaseComponent baseComponent)
        {
            ArrayList Parts = new ArrayList();
            IEnumerator myChildren = baseComponent.GetChildren();

            while (myChildren.MoveNext())
                Parts.Add((myChildren.Current as TSM.ModelObject).Identifier);

            return Parts;
        }

        private static ArrayList GetTaskParts(TSM.Task task)
        {
            ArrayList Parts = new ArrayList();

            TSM.ModelObjectEnumerator myMembers = task.GetChildren();

            while (myMembers.MoveNext())
            {
                if (myMembers.Current is TSM.Task)
                {
                    Parts.AddRange(GetTaskParts(myMembers.Current as TSM.Task));
                }
                else if (myMembers.Current is TSM.Part)
                {
                    Parts.Add(myMembers.Current.Identifier);
                }
            }

            return Parts;
        }

        #endregion

        private void CreateViews(TSG.CoordinateSystem ModelObjectCoordSys, string ModelObjectName, TSD.GADrawing MyDrawing, ArrayList Parts)
        {
            if (createFrontView.Checked)
                AddView("Front view of " + ModelObjectName, MyDrawing, Parts, GetBasicViewsCoordinateSystemForFrontView(ModelObjectCoordSys));
            if (createTopView.Checked)
                AddView("Top view of " + ModelObjectName, MyDrawing, Parts, GetBasicViewsCoordinateSystemForTopView(ModelObjectCoordSys));
            if (createEndView.Checked)
                AddView("End view of " + ModelObjectName, MyDrawing, Parts, GetBasicViewsCoordinateSystemForEndView(ModelObjectCoordSys));
            if (create3dView.Checked)
                AddRotatedView("3d view of " + ModelObjectName, MyDrawing, Parts, GetBasicViewsCoordinateSystemForFrontView(ModelObjectCoordSys));
        }

        private void AddView(string Name, TSD.Drawing MyDrawing, ArrayList Parts, TSG.CoordinateSystem coordinateSystem)
        {
            TSD.View MyView = new TSD.View(MyDrawing.GetSheet(), coordinateSystem, coordinateSystem, Parts);

            MyView.Name = Name;
            MyView.Insert();
        }

        private void AddRotatedView(string Name, TSD.Drawing MyDraiwng, ArrayList Parts, TSG.CoordinateSystem coordinateSystem)
        {
            TSG.CoordinateSystem displayCoordinateSystem = new TSG.CoordinateSystem();

            TSG.Matrix RotationAroundX = TSG.MatrixFactory.Rotate(20.0 * Math.PI * 2.0 / 360.0, coordinateSystem.AxisX);
            TSG.Matrix RotationAroundZ = TSG.MatrixFactory.Rotate(30.0 * Math.PI * 2.0 / 360.0, coordinateSystem.AxisY);

            TSG.Matrix Rotation = RotationAroundX * RotationAroundZ;

            displayCoordinateSystem.AxisX = new TSG.Vector(Rotation.Transform(new TSG.Point(coordinateSystem.AxisX)));
            displayCoordinateSystem.AxisY = new TSG.Vector(Rotation.Transform(new TSG.Point(coordinateSystem.AxisY)));

            TSD.View FrontView = new TSD.View(MyDraiwng.GetSheet(), coordinateSystem, displayCoordinateSystem, Parts);

            FrontView.Name = Name;
            FrontView.Insert();
        }
    }
}
