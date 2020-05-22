using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tekla.Structures;
using Tekla.Structures.Geometry3d;
using Tekla.Structures.Solid;
using Tekla.Structures.Model;
using TSM = Tekla.Structures.Model;
using TSG = Tekla.Structures.Geometry3d;

namespace ObjectTestApplication
{
    public partial class Form1 : Form
    {
        #region Field
        TSM.Model model = new Model();
        private static ArrayList ObjectList = new ArrayList();
        #endregion

        #region Constructor
        public Form1()
        {
            #region Initialize

            InitializeComponent();

            if (!model.GetConnectionStatus())
            {
                WriteLine("Failed to connect to TS!");
                Environment.Exit(-1);
            }
            TSM.ModelInfo info = model.GetInfo();
            TeklaStructuresInfo.GetCurrentProgramVersion();
            this.Text = "ObjectTest with " + info.ModelName;

            #endregion

            #region Event
            BtnRun.Click += BtnRun_Click;
            BtnClear.Click += BtnClear_Click;

            #endregion
        }
        #endregion

        #region Event

        private void BtnClear_Click(object sender, EventArgs e)
        {
            DeleteAll(model);
            model.CommitChanges();
            ObjectList.Clear();
        }

        private void BtnRun_Click(object sender, EventArgs e)
        {
            foreach (object itemChecked in checkedListBox1.CheckedItems)
            {
                RunTest(itemChecked.ToString());
            }
        }
        #endregion

        #region private

        private void WriteLine(string text)
        {
            if (textLog.TextLength + text.Length < textLog.MaxLength)
            {
                textLog.AppendText(text);
                textLog.AppendText("\r\n");
            }
            statusBarPanel1.Text = text;
            statusBarPanel2.Text = ObjectList.Count.ToString() + "Objects Insersted";
        }

        private void DeleteAll(Model model)
        {
            int counter = 0;

            WriteLine("Starting DeleteAll..");

            IEnumerator Enum = ObjectList.GetEnumerator();
            while (Enum.MoveNext())
            {
                WriteLine("Deleting object number " + counter++);
                ModelObject MO = Enum.Current as ModelObject;
                if (MO != null)
                {
                    MO.Delete();
                }
                else
                {
                    WriteLine("Object already deleted or unsupported!");
                }
                WriteLine("All created objected deleted, have fun!");
            }
        }

        private void RunTest(string test)
        {
            if (test.Equals("All") || test.Equals("BeamTest"))
                BeamTest();
            if (test.Equals("All") || test.Equals("PolyBeamTest"))
                PolyBeamTest();
            if (test.Equals("All") || test.Equals("ContourPlateTest"))
                ContourPlateTest();
            if (test.Equals("All") || test.Equals("BooleanTests"))
            {
                BooleanPartTest();
                CutTest();
                FittingTest();
            }
            if (test.Equals("All") || test.Equals("WeldTest"))
                WeldTest();
            if (test.Equals("All") || test.Equals("CastUnitTest"))
                CastUnitTest();
            if (test.Equals("All") || test.Equals("PlaneTests"))
            {
                ControlPlaneTest();
                TransformationPlaneTest(model);
                Grid grid = GridTest();
            }
            if (test.Equals("All") || test.Equals("RebarTests"))
            {
                SingleRebarTest();
            }
            if (test.Equals("All") || test.Equals("AssemblyTest"))
            {
                AssemblyTest();
                GetPartMarkTest();
                GetAndSetPropertyTest();
            }

            if (test.Equals("All") || test.Equals("SurfaceTreatmentTest"))
                SurfaceTreatmentTest();

            if (test.Equals("All") || test.Equals("BoltTests"))
            {
                BoltArrayTest();
                BoltXYListTest();
                BoltCircleTest();
            }

            if (test.Equals("All") || test.Equals("LoadTests"))
            {
                LoadPointTest();
                //LoadAreaTest();
                //LoadLineTest();
                //LoadUniform();
            }

            model.CommitChanges();
        }

        #endregion

        #region Test Method

        private void BeamTest()
        {
            double Test = 0;
            WriteLine("Starting BeamTest...");
            TSG.Point point = new TSG.Point(0, 0, 0);
            TSG.Point point2 = new TSG.Point(1000, 0, 0);

            Beam beam = new Beam(point, point2);

            beam.Profile.ProfileString = "L60*6";
            beam.Finish = "PAINT";

            if (!beam.Insert())
                MessageBox.Show("Insert failed!");
            else
                ObjectList.Add(beam);

            if (beam.GetReportProperty("PROFILE.FLANGE_THICKNESS_1", ref Test))
                WriteLine("PROFILE.FLANGE_THICKNESS_1 returned " + Test.ToString());

            if (beam.GetReportProperty("PROFILE.FLANGE_THICKNESS_2", ref Test))
                WriteLine("PROFILE.FLAGNE_THICKNESS_2 returned " + Test.ToString());

            WriteLine(beam.Identifier.ID + " Inserted");

            if (!beam.Select())
                MessageBox.Show("Select failed!");

            beam.StartPoint.Translate(0, 1000, 0);
            beam.EndPoint.Translate(0, 1000, 0);

            if (!beam.Modify())
                MessageBox.Show("Modify failed!");

            WriteLine("BeamTest complete!");

        }

        private void PolyBeamTest()
        {
            WriteLine("PolyBeamTest complete!");

            ContourPoint point = new ContourPoint(new TSG.Point(0, 2000, 0), null);
            ContourPoint point2 = new ContourPoint(new TSG.Point(2000, 2000, 0), new Chamfer(0, 0, Chamfer.ChamferTypeEnum.CHAMFER_ARC_POINT));
            ContourPoint point3 = new ContourPoint(new TSG.Point(0, 4000, 0), null);

            PolyBeam polyBeam = new PolyBeam();

            polyBeam.AddContourPoint(point);
            polyBeam.AddContourPoint(point2);
            polyBeam.AddContourPoint(point3);

            polyBeam.Profile.ProfileString = "HI400-15-20*400";
            polyBeam.Finish = "PAINT";

            if (!polyBeam.Insert())
                MessageBox.Show("Insert failed!");
            else
                ObjectList.Add(polyBeam);

            if (!polyBeam.Select())
                MessageBox.Show("Select failed!");

            WriteLine("PolyBeamTest complete");

        }

        private void ContourPlateTest()
        {
            WriteLine("Starting ContourPlateTest...");

            ContourPoint point = new ContourPoint(new TSG.Point(0, 4000, 0), null);
            ContourPoint point2 = new ContourPoint(new TSG.Point(2000, 4000, 0), new Chamfer(0, 0, Chamfer.ChamferTypeEnum.CHAMFER_ARC_POINT));
            ContourPoint point3 = new ContourPoint(new TSG.Point(0, 6000, 0), null);

            point2.Chamfer.DZ1 = 2500;
            point2.Chamfer.DZ2 = 300;

            ContourPlate CP = new ContourPlate();

            CP.AddContourPoint(point);
            CP.AddContourPoint(point2);
            CP.AddContourPoint(point3);
            CP.Profile.ProfileString = "PL10";
            CP.Finish = "FOO";
            CP.Material.MaterialString = "Concrete_Undefined";
            CP.Name = "FOOSLAB";

            if (!CP.Insert())
                MessageBox.Show("Insert failed!");
            else
                ObjectList.Add(CP);

            if (!CP.Select())
                MessageBox.Show("Select failed!");

            if (!CP.Modify())
                MessageBox.Show("Modifiy failed!");

            WriteLine(CP.Identifier.ID + " Inserted");
            WriteLine("ContourPlateTest complete!");
        }

        private string BooleanPartTest()
        {

            TSG.Point point = new TSG.Point(0, 7000, 0);
            TSG.Point point2 = new TSG.Point(1000, 7000, 0);

            Beam beam1 = new Beam();
            beam1.StartPoint = point;
            beam1.EndPoint = point2;
            beam1.Profile.ProfileString = "HI400-15-20*400";
            beam1.Material.MaterialString = "C90";
            beam1.Finish = "PAINT";

            if (beam1.Insert())
                ObjectList.Add(beam1);

            Beam beam2 = new Beam();
            beam2.Profile.ProfileString = "HI100-10-10*100";
            beam2.StartPoint = new TSG.Point(500, 6000, 0);
            beam2.EndPoint = new TSG.Point(500, 8000, 0);
            beam2.Class = BooleanPart.BooleanOperativeClassName;

            if (beam2.Insert())
                ObjectList.Add(beam2);
            
            BooleanPart beam = new BooleanPart();
            beam.Father = beam1;
            beam.SetOperativePart(beam2);

            if (!beam.Insert())
                MessageBox.Show("Insert failed!");
            else
                ObjectList.Add(beam);

            beam2.Delete();

            if (!beam.Select())
                MessageBox.Show("Selecte failed!");

            beam.OperativePart.Profile.ProfileString = "HI200-15-10*200";

            if (!beam.Modify())
                MessageBox.Show("Modify failed!");

            return beam.Identifier.ID.ToString();
        }

        private string CutTest()
        {
            TSG.Point point = new TSG.Point(5000, 5000, 0);
            TSG.Point point2 = new TSG.Point(6000, 5000, 0);

            Beam beam = new Beam();
            beam.StartPoint = point;
            beam.EndPoint = point2;
            beam.Profile.ProfileString = "HI400-15-20*400";
            beam.Finish = "PAINT";

            if (beam.Insert())
                ObjectList.Add(beam);

            CutPlane cut = new CutPlane();
            cut.Father = beam;
            cut.Plane.Origin = new TSG.Point(5500, 0, 0);
            cut.Plane.AxisX = new Vector(0, 1.0, 0);
            cut.Plane.AxisY = new Vector(0, 0, 1.0);

            if (!cut.Insert())
                MessageBox.Show("Insert failed!");
            else
                ObjectList.Add(cut);

            if (!cut.Select())
                MessageBox.Show("Select failed!");

            cut.Plane.AxisX = new Vector(0, 500, 0);
            cut.Plane.AxisY = new Vector(0, 0, 500);

            if (!cut.Modify())
                MessageBox.Show("Modify failed!");

            return cut.Identifier.ID.ToString();
        }

        private string FittingTest()
        {
            TSG.Point point = new TSG.Point(5000, 6000, 0);
            TSG.Point point2 = new TSG.Point(6000, 6000, 0);

            Beam beam = new Beam();
            beam.StartPoint = point;
            beam.EndPoint = point2;
            beam.Profile.ProfileString = "HI400-15-20*400";
            beam.Finish = "PAINT";

            if (beam.Insert())
                ObjectList.Add(beam);

            Fitting fitting = new Fitting();
            fitting.Father = beam;
            fitting.Plane.Origin.X = 5800;
            fitting.Plane.Origin.Y = 5800;
            fitting.Plane.Origin.Z = -500;
            fitting.Plane.AxisX = new Vector(0, 6000, 1000);
            fitting.Plane.AxisY = new Vector(0, 0, 6000);

            if (!fitting.Insert())
                MessageBox.Show("Insert failed!");
            else
                ObjectList.Add(fitting);

            if (!fitting.Select())
                MessageBox.Show("Select failed!");

            fitting.Plane.AxisX = new Vector(0, 500, 0);
            fitting.Plane.AxisY = new Vector(3000, 0, 4000);

            if (!fitting.Modify())
                MessageBox.Show("Modifiy failed!");

            return fitting.Identifier.ID.ToString();
        }

        private void WeldTest()
        {
            WriteLine("Starting WeldTest...");

            TSG.Point beam1p1 = new TSG.Point(0, 12000, 0);
            TSG.Point beam1p2 = new TSG.Point(3000, 12000, 0);

            TSG.Point beam2p1 = new TSG.Point(3000, 12000, 0);
            TSG.Point beam2p2 = new TSG.Point(3000, 18000, 0);

            Beam beam1 = new Beam(beam1p1, beam1p2);
            Beam beam2 = new Beam(beam2p1, beam2p2);

            beam1.Profile.ProfileString = "HI400-15-20*400";
            beam1.Finish = "PAINT";
            beam1.Name = "Beam 1";
            beam2.Profile.ProfileString = "HI300-15-20*400";
            beam2.Name = "Beam 2";

            if (!beam1.Insert())
                WriteLine("Beam 1 Insert Failed");
            else
                ObjectList.Add(beam1);

            if (!beam2.Insert())
                WriteLine("Beam 2 Insert Failed");
            else
                ObjectList.Add(beam2);

            WriteLine("Weld Beams Inserted, Ids " + beam1.Identifier.ID.ToString() + " " + beam2.Identifier.ID.ToString());

            Weld weld = new Weld();
            weld.MainObject = beam1;
            weld.SecondaryObject = beam2;
            weld.TypeAbove = Weld.WeldTypeEnum.WELD_TYPE_SQUARE_GROOVE_SQUARE_BUTT;

            if (!weld.Insert())
                WriteLine("Weld Insert Failed!");
            else
                ObjectList.Add(weld);

            WriteLine(weld.Identifier.ID.ToString());

            if (!weld.Select())
                WriteLine("Weld Select failed!");

            WriteLine(weld.Identifier.ID.ToString());

            weld.LengthAbove = 12;
            weld.TypeBelow = BaseWeld.WeldTypeEnum.WELD_TYPE_SLOT;

            if (!weld.Modify())
                WriteLine("Weld Modify failed!");

            WriteLine(weld.Identifier.ID.ToString());
            WriteLine("WeldTest complete!");

        }

        private void CastUnitTest()
        {
            WriteLine("Starting CastUnitTest...");

            Beam beam1 = new Beam(new TSG.Point(6000, 0, 0), new TSG.Point(9000, 0, 0));
            Beam beam2 = new Beam(new TSG.Point(9000, 0, 0), new TSG.Point(9000, 6000, 0));
            Beam beam3 = new Beam(new TSG.Point(9000, 6000, 0), new TSG.Point(12000, 6000, 0));
            Beam beam4 = new Beam(new TSG.Point(12000, 6000, 0), new TSG.Point(12000, 12000, 0));

            beam1.Profile.ProfileString = "RHS100*100*4";
            beam1.Name = "Beam 1";
            beam1.Material.MaterialString = "Concrete_Undefined";

            beam2.Profile.ProfileString = "RHS200*100*4";
            beam2.Name = "Beam 2";
            beam2.Material.MaterialString = "Concrete_Undefined";

            beam3.Profile.ProfileString = "RHS300*100*4";
            beam3.Name = "Beam 3";
            beam3.Material.MaterialString = "Concrete_Undefined";

            beam4.Profile.ProfileString = "RHS400*100*4";
            beam4.Name = "Beam 4";
            beam4.Material.MaterialString = "Concrete_Undefined";

            if (!beam1.Insert())
                WriteLine("Beam 1 Insert Failed");
            else
                ObjectList.Add(beam1);

            if (!beam2.Insert())
                WriteLine("Beam 2 Insert Failed");
            else
                ObjectList.Add(beam2);

            if (!beam3.Insert())
                WriteLine("Beam 3 Insert Failed");
            else
                ObjectList.Add(beam3);

            if (!beam4.Insert())
                WriteLine("Beam 4 Insert Failed");
            else
                ObjectList.Add(beam4);

            WriteLine("CastUnit Beams Inserted, Ids " + " " + beam1.Identifier.ID.ToString()
                                                      + " " + beam2.Identifier.ID.ToString()
                                                      + " " + beam3.Identifier.ID.ToString()
                                                      + " " + beam4.Identifier.ID.ToString());

            Assembly As = beam1.GetAssembly();
            WriteLine(As.Identifier.ID.ToString());
            As.Add(beam2);

            if (!As.Modify())
                WriteLine("CastUnit Insert Failed!");

            WriteLine(As.Identifier.ID.ToString());

            if (!As.Select())
                WriteLine("CastUniut Select Failed!");

            WriteLine(As.Identifier.ID.ToString());

            As.Remove(beam1);
            As.Add(beam3);
            As.Add(beam4);

            if (!As.Modify())
                WriteLine("CastUnit Modify Failed!");

            WriteLine(As.Identifier.ID.ToString());

            if (!As.Select())
                WriteLine("CastUnit Selct Failed!");

            WriteLine(As.Identifier.ID.ToString());

            WriteLine("CastUnitTest Complete!");

        }

        private void ControlPlaneTest()
        {
            WriteLine("Starting ContorlPlaneTest...");

            ControlPlane controlPlane = new ControlPlane();

            Plane plane = new Plane();
            plane.Origin = new TSG.Point(4500, 4500, 0);
            plane.AxisX = new Vector(-2000, 0, 0);
            plane.AxisY = new Vector(0, 5000, 0);

            controlPlane.Plane = plane;
            controlPlane.IsMagnetic = true;

            if (!controlPlane.Insert())
                WriteLine("ContorlPlane Insert failed!");
            else
                ObjectList.Add(controlPlane);
            WriteLine(controlPlane.Identifier.ID.ToString());

            if (!controlPlane.Select())
                WriteLine("ContorlPlane Select failed!");
            WriteLine(controlPlane.Identifier.ID.ToString());

            controlPlane.Name = "Plane name changed";
            if (!controlPlane.Modify())
                WriteLine("ControlPlane Modify failed!");
            WriteLine(controlPlane.Identifier.ID.ToString());
            WriteLine("ControlPlaneTest Complete!");
        }

        private Grid GridTest()
        {
            WriteLine("Starting GridTest...");

            Grid grid = new Grid();

            grid.CoordinateX = "0.00 4*3000.00";
            grid.CoordinateY = "0.00 5*6000.00";
            grid.CoordinateZ = "0.00 6000.00 8000.00 9000.00";
            grid.LabelX = "A B C D E";
            grid.LabelY = "1 2 3 4 5 6";
            grid.LabelZ = "+0 +6000 8000 9000";

            grid.ExtensionLeftX = 2000.0;
            grid.ExtensionLeftY = 2000.0;
            grid.ExtensionLeftZ = 2000.0;
            grid.ExtensionRightX = 2000.0;
            grid.ExtensionRightY = 2000.0;
            grid.ExtensionRightZ = 2000.0;
            grid.IsMagnetic = true;

            if (!grid.Insert())
                WriteLine("Grid Insert failed!");
            else
                ObjectList.Add(grid);
            WriteLine(grid.Identifier.ID.ToString());

            if (!grid.Select())
                WriteLine("Grid Select failed!");
            WriteLine(grid.Identifier.ID.ToString());

            grid.CoordinateX = "0.00 4*5000.00";
            grid.CoordinateY = "0.00 5*1000.00";
            grid.CoordinateZ = "0.00 3000.0 4000.00 4500.00";
            grid.LabelX = "X Y Z M N";
            grid.LabelY = "6 5 4 3 2 1";
            grid.LabelZ = "+0 +3000 +4000 +4500";
            grid.ExtensionLeftX = 5000.0;
            grid.ExtensionLeftY = 5000.0;
            grid.ExtensionLeftZ = 5000.0;
            grid.ExtensionRightX = 5000.0;
            grid.ExtensionRightY = 5000.0;
            grid.ExtensionRightZ = 5000.0;
            grid.IsMagnetic = false;

            if (!grid.Modify())
                WriteLine("Grid Modifty failed!");
            WriteLine(grid.Identifier.ID.ToString());
            WriteLine("Grid complete");

            return grid;
        }

        private void TransformationPlaneTest(Model model)
        {
            WriteLine("Starting TransformationPlaneTest...");

            WorkPlaneHandler PlaneHandler = model.GetWorkPlaneHandler();
            TransformationPlane CurrentPlane = PlaneHandler.GetCurrentTransformationPlane();

            WriteLine("Current plane in the model : ");
            WriteLine(CurrentPlane.ToString());

            Beam beam = new Beam(new TSG.Point(0, 7000, 0), new TSG.Point(0, 8000, 0));

            beam.Profile.ProfileString = "HI400-15-20*400";
            beam.Finish = "PAINT";
            if (beam.Insert())
                ObjectList.Add(beam);
            beam.Select();

            WriteLine("Change current plane to object " + beam.Identifier.ID + " plane");
            TransformationPlane Plane = new TransformationPlane(beam.GetCoordinateSystem());
            PlaneHandler.SetCurrentTransformationPlane(Plane);

            Plane = PlaneHandler.GetCurrentTransformationPlane();
            WriteLine("Current plane in the model after change : ");
            WriteLine(Plane.ToString());

            WriteLine("Change plane to global:");
            TransformationPlane GlobalPlane = new TransformationPlane();
            WriteLine(GlobalPlane.ToString());
            PlaneHandler.SetCurrentTransformationPlane(GlobalPlane);

            WriteLine("And get it from model:");
            Plane = PlaneHandler.GetCurrentTransformationPlane();
            WriteLine(Plane.ToString());

            WriteLine("Then set plane back to original:");
            PlaneHandler.SetCurrentTransformationPlane(CurrentPlane);
            WriteLine(CurrentPlane.ToString());
        }

        private void SingleRebarTest()
        {
            WriteLine("Starting the SingleRebarTest...");

            Beam beam = new Beam(new TSG.Point(5000, 7000, 0), new TSG.Point(6000, 7000, 0));
            beam.Profile.ProfileString = "250*250";
            beam.Material.MaterialString = "Concrete_Undefined";
            beam.Finish = "PAINT";

            if (beam.Insert())
                ObjectList.Add(beam);

            double MinimumY = beam.GetSolid().MinimumPoint.Y;
            double MinimumX = beam.GetSolid().MinimumPoint.X;
            double MinimumZ = beam.GetSolid().MinimumPoint.Z;
            double MaximumX = beam.GetSolid().MaximumPoint.X;
            double MaximumY = beam.GetSolid().MaximumPoint.Y;
            double MaximumZ = beam.GetSolid().MaximumPoint.Z;

            // 1st single
            Polygon polygon = new Polygon();
            polygon.Points.Add(new TSG.Point(MinimumX, MaximumY, MaximumZ));
            polygon.Points.Add(new TSG.Point(MaximumX, MaximumY, MaximumZ));

            SingleRebar singleRebar = new SingleRebar();
            singleRebar.Polygon = polygon;
            singleRebar.Father = beam;
            singleRebar.Name = "SingleRebar1";
            singleRebar.Class = 9;
            singleRebar.Size = "12";
            singleRebar.NumberingSeries.StartNumber = 0;
            singleRebar.NumberingSeries.Prefix = "Single 1";
            singleRebar.Grade = "A500HW";
            singleRebar.OnPlaneOffsets.Add(25.00);
            singleRebar.FromPlaneOffset = 50;
            singleRebar.StartHook.Angle = -90;
            singleRebar.StartHook.Length = 10;
            singleRebar.StartHook.Radius = 10;
            singleRebar.StartHook.Shape = RebarHookData.RebarHookShapeEnum.CUSTOM_HOOK;
            singleRebar.EndHook.Angle = 90;
            singleRebar.EndHook.Length = 10;
            singleRebar.EndHook.Radius = 10;
            singleRebar.EndHook.Shape = RebarHookData.RebarHookShapeEnum.CUSTOM_HOOK;

            if (!singleRebar.Insert())
                WriteLine("singleRebar Insert failed!");
            else
                ObjectList.Add(singleRebar);

            WriteLine(singleRebar.Identifier.ID.ToString());

            //2nd single
            polygon.Points.Clear();
            polygon.Points.Add(new TSG.Point(MaximumX, MinimumY, MaximumZ));
            polygon.Points.Add(new TSG.Point(MaximumX, MinimumY, MaximumZ));
            SingleRebar singleRebar2 = new SingleRebar();
            singleRebar2.Polygon = polygon;
            singleRebar2.Father = beam;
            singleRebar2.Name = "SingleRebar2";
            singleRebar2.Class = 8;
            singleRebar2.Size = "12";
            singleRebar2.NumberingSeries.StartNumber = 0;
            singleRebar2.NumberingSeries.Prefix = "Single 2";
            singleRebar2.Grade = "A500HW";
            singleRebar2.OnPlaneOffsets.Add(65.00);
            singleRebar2.OnPlaneOffsets.Add(65.00);
            singleRebar2.OnPlaneOffsets.Add(65.00);
            singleRebar2.FromPlaneOffset = -30;
            singleRebar2.StartPointOffsetType = Reinforcement.RebarOffsetTypeEnum.OFFSET_TYPE_COVER_THICKNESS;
            singleRebar2.StartPointOffsetValue = 15;
            singleRebar2.EndPointOffsetType = Reinforcement.RebarOffsetTypeEnum.OFFSET_TYPE_COVER_THICKNESS;
            singleRebar2.EndPointOffsetValue = 15;
            singleRebar2.StartHook.Angle = 50;
            singleRebar2.StartHook.Length = 50;
            singleRebar2.StartHook.Radius = 30;
            singleRebar2.StartHook.Shape = RebarHookData.RebarHookShapeEnum.CUSTOM_HOOK;
            singleRebar2.EndHook.Angle = 50;
            singleRebar2.EndHook.Length = 50;
            singleRebar2.EndHook.Radius = 30;
            singleRebar2.EndHook.Radius = 30;
            singleRebar2.EndHook.Shape = RebarHookData.RebarHookShapeEnum.CUSTOM_HOOK;

            if (!singleRebar2.Insert())
                WriteLine("singleRebar2 Insert failed!");
            else
                ObjectList.Add(singleRebar2);

            WriteLine(singleRebar2.Identifier.ID.ToString());

            if (!singleRebar.Select())
                WriteLine("Select failed!");

            WriteLine(singleRebar.Identifier.ID.ToString());

            singleRebar.Class = 10;
            singleRebar.Name = "Modified single 1";

            if (!singleRebar.Modify())
                WriteLine("Modify failed!");

            WriteLine(singleRebar.Identifier.ID.ToString());
            WriteLine("SingleRebarTest complete!");
        }

        private void AssemblyTest()
        {
            WriteLine("Starting AssemblyTest...");

            TSG.Point beam1P1 = new TSG.Point(9000, 18000, 0);
            TSG.Point beam1P2 = new TSG.Point(12000, 18000, 0);

            TSG.Point beam2P1 = new TSG.Point(12000, 18000, 0);
            TSG.Point beam2P2 = new TSG.Point(12000, 24000, 0);

            Beam beam1 = new Beam(beam1P1, beam1P2);
            Beam beam2 = new Beam(beam2P1, beam2P2);

            beam1.Profile.ProfileString = "HI400-15-20*400";
            beam1.Finish = "PAINT";
            beam1.Name = "Beam 1";

            if (!beam1.Insert())
                WriteLine("Beam 1 Insert Failed!");
            else
                ObjectList.Add(beam1);

            beam2.Profile.ProfileString = "HI300-15-20*300";
            beam2.Name = "Beam 2";

            if (!beam2.Insert())
                WriteLine("Beam2 Insert failed!");
            else
                ObjectList.Add(beam2);

            WriteLine("Beam Inserted, Ids " + " " + beam1.Identifier.ID.ToString() + " " + beam2.Identifier.ID.ToString());

            Weld weld = new Weld();
            weld.MainObject = beam1;
            weld.SecondaryObject = beam2;
            weld.TypeAbove = Weld.WeldTypeEnum.WELD_TYPE_SQUARE_GROOVE_SQUARE_BUTT;

            if (!weld.Insert())
                WriteLine("Weld Insert Failed!");
            else
                ObjectList.Add(weld);
            WriteLine("Weld created. Id " + " " + weld.Identifier.ID.ToString());

            Assembly assembly = beam1.GetAssembly();
            if (assembly == null)
                WriteLine("GetAssembly failed!");
            WriteLine(assembly.Identifier.ID.ToString());
            assembly.AssemblyNumber.Prefix = "C3";
            assembly.AssemblyNumber.StartNumber = 402;
            assembly.Modify();
            WriteLine("AssemblyTest complete!");
        }

        private void GetPartMarkTest()
        {
            WriteLine("Starting GetPartMark Test... ");

            TSG.Point beam1P1 = new TSG.Point(9500, 20000, 0);
            TSG.Point beam1P2 = new TSG.Point(9500, 23000, 0);

            TSG.Point beam2P1 = new TSG.Point(10500, 20000, 0);
            TSG.Point beam2P2 = new TSG.Point(10500, 23000, 0);

            Beam beam1 = new Beam(beam1P1, beam1P2);
            Beam beam2 = new Beam(beam2P1, beam2P2);

            beam1.Profile.ProfileString = "HI400-15-20*400";
            beam1.Finish = "PAINT";
            beam1.Name = "Beam 1";

            beam2.Profile.ProfileString = "HI300-15-20*300";
            beam2.Finish = "PAINT";
            beam2.Name = "Beam 2";

            if (!beam1.Insert())
                WriteLine("Beam1 Insert Failed!");
            else
                ObjectList.Add(beam1);

            if (!beam2.Insert())
                WriteLine("Beam2 Insert Failed");
            else
                ObjectList.Add(beam2);

            WriteLine("Beams Inserted, Id " + " " + beam1.Identifier.ID.ToString() + " " + beam2.Identifier.ID.ToString());

            string mark = beam1.GetPartMark();
            string mark2 = beam2.GetPartMark();

            if (mark == null || mark2 == null)
                WriteLine("GetPartMark failed!");
            else
                WriteLine("PartMark is " + " " + mark + "\\" + mark2);
            WriteLine("GetPartMark Test complete!");

        }

        private void GetAndSetPropertyTest()
        {
            WriteLine("Starting GetAndSetPropertyTest...");

            TSG.Point point = new TSG.Point(3000, 0, 0);
            TSG.Point point2 = new TSG.Point(4000, 0, 0);

            Beam B = new Beam(point, point2);

            B.Profile.ProfileString = "HI400-15-20*400";
            B.Finish = "PAINT";
            if (!B.Insert())
                WriteLine("Insert failed!");
            else
                ObjectList.Add("Insert failed!");
            WriteLine(B.Identifier.ID.ToString());

            if (!B.SetUserProperty("comment", "Test comment"))
                WriteLine("SetProperty failed!");
            if (!B.SetUserProperty("fabricator", "Test fabricator"))
                WriteLine("SetProperty failed!");
            if (!B.SetUserProperty("AD_n_part_splits", 66))
                WriteLine("SetProperty failed!");

            string commentVal = "";
            string fabVal = "";
            int splitsVal = 0;
            if (!B.GetUserProperty("comment", ref commentVal))
                WriteLine("GetProperty failed!");
            if (!B.GetUserProperty("fabricator", ref fabVal))
                WriteLine("GetProperty failed!");
            if (!B.GetUserProperty("AD_n_part_splits", ref splitsVal))
                WriteLine("GetProperty failed!");

            if (!B.SetUserProperty("ASSMBLY_POS", ""))
                WriteLine("이거 맞?");
            if (!B.SetUserProperty("COG_X", 0.0))
                WriteLine("이거 맞는?");
            if (!B.SetUserProperty("PROJECT.CURRENT_PHASE", 0))
                WriteLine("Dlrj akw?");
            if (!B.SetUserProperty("PROJECT.NAME", "GG"))
                WriteLine("AKWSIRh?");


            // Test report GETTERS ( Setting 된 값이 없어서 안나오는? 테스트?? )
            string AssPos = "";
            double COG = 0.0;
            int CurrPhase = 0;
            string ProjName = "";
            if (!B.GetUserProperty("ASSEMBLY_POS", ref AssPos))
                WriteLine("GetReportProperty failed!!!");
            if(!B.GetUserProperty("COG_X", ref COG))
                WriteLine("GetReportProperty failed!!!");
            if (!B.GetUserProperty("PROJECT.CURRENT_PHASE", ref CurrPhase))
                WriteLine("GetReportProperty failed!!!");
            if(!B.GetUserProperty("PROJECT.NAME", ref ProjName))
                WriteLine("GetReportProperty failed!!!");

            WriteLine("GetAndSetPropertyTest complete");
        }

        private void SurfaceTreatmentTest()
        {
            WriteLine("Starting SurfaceTreatmentTest...");

            ContourPlate cp = new ContourPlate();
            cp.AddContourPoint(new ContourPoint(new TSG.Point(6000, 15000, 0), null));
            cp.AddContourPoint(new ContourPoint(new TSG.Point(9000, 15000, 0), null));
            cp.AddContourPoint(new ContourPoint(new TSG.Point(9000, 21000, 0), null));
            cp.AddContourPoint(new ContourPoint(new TSG.Point(10500, 24000, 0), null));
            cp.AddContourPoint(new ContourPoint(new TSG.Point(6000, 21000, 0), null));

            cp.Profile.ProfileString = "PL10";

            Contour c = new Contour();
            c.AddContourPoint(new ContourPoint(new TSG.Point(6000, 15000, 5), null));
            c.AddContourPoint(new ContourPoint(new TSG.Point(9000, 15000, 5), null));
            c.AddContourPoint(new ContourPoint(new TSG.Point(9000, 21000, 5), null));
            //c.AddContourPoint(new ContourPoint(new TSG.Point(9000, 21000, 5), new Chamfer(300, 300, Chamfer.ChamferTypeEnum.CHAMFER_LINE_AND_ARC)));
            c.AddContourPoint(new ContourPoint(new TSG.Point(10500, 24000, 5), null));
            c.AddContourPoint(new ContourPoint(new TSG.Point(7500, 21000, 5), null));

            if (!cp.Insert())
                WriteLine("ContourPlate Insert failed!");
            else
                ObjectList.Add(cp);
            WriteLine("ContourPlate ID " + " " + cp.Identifier.ID.ToString());

            SurfaceTreatment treatment = new SurfaceTreatment();
            treatment.Father = cp;
            treatment.Polygon = c;
            treatment.StartPoint = new TSG.Point(7500, 15000, 5);
            treatment.EndPoint = new TSG.Point(7500, 21000, 5);

            treatment.Position.Depth = Position.DepthEnum.MIDDLE;

            treatment.Name = "Treatment Test";
            treatment.Class = "66";
            treatment.Thickness = 40;
            treatment.Color = SurfaceTreatment.SurfaceColorEnum.CYAN;
            treatment.Type = SurfaceTreatment.SurfaceTypeEnum.TILE_SURFACE;
            treatment.Material.MaterialString = "Concreate_Undefined";

            if (!treatment.Insert())
                WriteLine("SurfaceTreatment Insert failed!");
            else
                ObjectList.Add(treatment);
            WriteLine(treatment.Identifier.ID.ToString());

            if (!treatment.Select())
                WriteLine("SurfaceTreatment Select failed!");
            WriteLine(treatment.Identifier.ID.ToString());

            treatment.Name = "Name modified";
            treatment.Class = "1";
            treatment.Color = SurfaceTreatment.SurfaceColorEnum.RED;
            treatment.Type = SurfaceTreatment.SurfaceTypeEnum.SPECIAL_MIX;
            if (treatment.Modify())
                WriteLine("Modifiy failed!");
            WriteLine(treatment.Identifier.ID.ToString());

            WriteLine("SurfaceTreatmentTest complete!");
        }

        private void BoltArrayTest()
        {
            WriteLine("Starting BoltArrayTest...");

            //Create for instance a contour plate that we can bolt to, insert it into the model
            ContourPlate cp = new ContourPlate();
            cp.AddContourPoint(new ContourPoint(new TSG.Point(0, 18000, 0), null));
            cp.AddContourPoint(new ContourPoint(new TSG.Point(1000, 18000, 0), null));
            cp.AddContourPoint(new ContourPoint(new TSG.Point(1000, 19000, 0), null));
            cp.AddContourPoint(new ContourPoint(new TSG.Point(0, 19000, 0), null));

            cp.Profile.ProfileString = "LP10";

            if (!cp.Insert())
                WriteLine("ContourPlate Insert failed!");
            else
                ObjectList.Add(cp);
            WriteLine("ContourPlate ID " + " " + cp.Identifier.ID.ToString());

            BoltArray B = new BoltArray();

            B.PartToBeBolted = cp;
            B.PartToBoltTo = cp;

            B.FirstPosition = new TSG.Point(0, 18000, 0);
            B.SecondPosition = new TSG.Point(1000, 19000, 0);

            B.BoltSize = 16;
            B.Tolerance = 3.00;
            B.BoltStandard = "NELSON";
            B.BoltType = BoltGroup.BoltTypeEnum.BOLT_TYPE_WORKSHOP;
            B.CutLength = 105;
            B.StartPointOffset.Dx = 1;
            B.EndPointOffset.Dx = 2;
            B.StartPointOffset.Dy = 3;
            B.EndPointOffset.Dy = 4;
            B.StartPointOffset.Dz = 5;
            B.EndPointOffset.Dz = 6;

            B.Length = 100;
            B.ExtraLength = 15;
            B.SlottedHoleX = 11;
            B.SlottedHoleY = 22;
            B.ThreadInMaterial = BoltGroup.BoltThreadInMaterialEnum.THREAD_IN_MATERIAL_NO;

            B.RotateSlots = BoltGroup.BoltRotateSlotsEnum.ROTATE_SLOTS_ODD;
            B.HoleType = BoltGroup.BoltHoleTypeEnum.HOLE_TYPE_OVERSIZED;

            B.Position.Depth = Position.DepthEnum.MIDDLE;
            B.Position.DepthOffset = 3;
            B.Position.Plane = Position.PlaneEnum.MIDDLE;
            B.Position.PlaneOffset = 1;
            B.Position.Rotation = Position.RotationEnum.FRONT;
            B.Position.RotationOffset = 2;

            B.Bolt = true;
            B.Washer1 = true;
            B.Washer2 = true;
            B.Washer3 = true;
            B.Nut1 = true;
            B.Nut2 = true;

            B.Hole1 = true;
            B.Hole2 = true;
            B.Hole3 = true;
            B.Hole4 = true;
            B.Hole5 = true;

            B.AddBoltDistX(100);
            B.AddBoltDistX(90);
            B.AddBoltDistX(80);

            B.AddBoltDistY(70);
            B.AddBoltDistY(60);
            B.AddBoltDistY(50);

            if (!B.Insert())
                WriteLine("BoltArray Insert Failed!");
            else
                ObjectList.Add(B);
            WriteLine(B.Identifier.ID.ToString());

            BoltArray BSel = new BoltArray();
            BSel.Identifier = B.Identifier;

            if (!BSel.Select())
                WriteLine("BoltArray Select failed!");
            else
                ObjectList.Add(B);
            WriteLine(B.Identifier.ID.ToString());

            B.FirstPosition = new TSG.Point(1000, 18000, 0);
            B.SecondPosition = new TSG.Point(0, 19000, 0);

            B.BoltSize = 20;
            B.Tolerance = 4.00;
            B.BoltStandard = "NELSON";
            B.BoltType = BoltGroup.BoltTypeEnum.BOLT_TYPE_SITE;
            B.CutLength = 155;
            B.StartPointOffset.Dx = 11;
            B.EndPointOffset.Dx = 12;
            B.StartPointOffset.Dy = 13;
            B.EndPointOffset.Dy = 14;
            B.StartPointOffset.Dz = 15;
            B.EndPointOffset.Dz = 16;

            B.Length = 50;
            B.ExtraLength = 45;
            B.SlottedHoleX = 55;
            B.SlottedHoleY = 66;
            B.ThreadInMaterial = BoltGroup.BoltThreadInMaterialEnum.THREAD_IN_MATERIAL_YES;

            B.RotateSlots = BoltGroup.BoltRotateSlotsEnum.ROTATE_SLOTS_EVEN;
            B.HoleType = BoltGroup.BoltHoleTypeEnum.HOLE_TYPE_SLOTTED;

            B.Position.Depth = Position.DepthEnum.FRONT;
            B.Position.DepthOffset = 13;
            B.Position.Plane = Position.PlaneEnum.LEFT;
            B.Position.PlaneOffset = 11;
            B.Position.Rotation = Position.RotationEnum.TOP;
            B.Position.RotationOffset = 12;

            B.Bolt = true;
            B.Washer1 = false;
            B.Washer2 = false;
            B.Washer3 = false;
            B.Nut1 = true;
            B.Nut2 = true;

            B.Hole1 = true;
            B.Hole2 = false;
            B.Hole3 = true;
            B.Hole4 = false;
            B.Hole5 = true;

            B.AddBoltDistX(150);
            B.AddBoltDistX(160);
            B.AddBoltDistY(170);

            if (!B.Modify())
                WriteLine("BoltArray Modify failed!");

            WriteLine(B.Identifier.ID.ToString());
            WriteLine("BoltArrayTest complete!");
        }

        private void BoltXYListTest()
        {
            WriteLine("Starting BoltXYListTest...");

            ContourPlate cp = new ContourPlate();
            cp.AddContourPoint(new ContourPoint(new TSG.Point(0, 19000, 0), null));
            cp.AddContourPoint(new ContourPoint(new TSG.Point(1000, 19000, 0), null));
            cp.AddContourPoint(new ContourPoint(new TSG.Point(1000, 20000, 0), null));
            cp.AddContourPoint(new ContourPoint(new TSG.Point(0, 2000, 0), null));

            if (cp.Insert())
                WriteLine("ContourPlate Insert failed!");
            else
                WriteLine("ContourPlate ID " + " " + cp.Identifier.ID.ToString());

            BoltXYList b = new BoltXYList();

            b.PartToBeBolted = cp;
            b.PartToBoltTo = cp;

            b.FirstPosition = new TSG.Point(0, 19000, 0);
            b.SecondPosition = new TSG.Point(1000, 20000, 0);

            b.BoltSize = 16;
            b.Tolerance = 3.00;
            b.BoltStandard = "7968";
            b.BoltType = BoltGroup.BoltTypeEnum.BOLT_TYPE_WORKSHOP;
            b.CutLength = 105;
            b.StartPointOffset.Dx = 1;
            b.EndPointOffset.Dx = 2;
            b.StartPointOffset.Dy = 3;
            b.EndPointOffset.Dy = 4;
            b.StartPointOffset.Dz = 5;
            b.EndPointOffset.Dz = 6;

            b.Length = 88;
            b.ExtraLength = 15;
            b.SlottedHoleX = 11;
            b.SlottedHoleY = 22;
            b.ThreadInMaterial = BoltGroup.BoltThreadInMaterialEnum.THREAD_IN_MATERIAL_NO;

            b.RotateSlots = BoltGroup.BoltRotateSlotsEnum.ROTATE_SLOTS_ODD;
            b.HoleType = BoltGroup.BoltHoleTypeEnum.HOLE_TYPE_OVERSIZED;

            b.Position.Depth = Position.DepthEnum.MIDDLE;
            b.Position.DepthOffset = 3;
            b.Position.Plane = Position.PlaneEnum.MIDDLE;
            b.Position.DepthOffset = 1;
            b.Position.Rotation = Position.RotationEnum.FRONT;
            b.Position.RotationOffset = 2;

            b.Bolt = true;
            b.Washer1 = true;
            b.Washer2 = true;
            b.Washer3 = true;
            b.Nut1 = true;
            b.Nut2 = true;

            b.Hole1 = true;
            b.Hole2 = false;
            b.Hole3 = true;
            b.Hole4 = false;
            b.Hole5 = true;

            b.AddBoltDistX(500);
            b.AddBoltDistY(500);

            if (!b.Modify())
                WriteLine("BoltXYList Modify failed!");
            WriteLine(b.Identifier.ID.ToString());
            WriteLine("BoltXYListTest complete");
        
        }

        private void BoltCircleTest()
        {
            WriteLine("Starting BoltCircleTest....");

            // Create for instance a contour plate that we can bolt to, insert it into the model
            ContourPlate cp = new ContourPlate();
            cp.AddContourPoint(new ContourPoint(new TSG.Point(0, 20000, 0), null));
            cp.AddContourPoint(new ContourPoint(new TSG.Point(1000, 20000, 0), null));
            cp.AddContourPoint(new ContourPoint(new TSG.Point(1000, 21000, 0), null));
            cp.AddContourPoint(new ContourPoint(new TSG.Point(0, 21000, 0), null));

            if (!cp.Insert())
                WriteLine("ContourPlate Insert failed!");
            else
                ObjectList.Add(cp);
            WriteLine("ContourPlate ID " + " " + cp.Identifier.ID.ToString());

            BoltCircle b = new BoltCircle();

            b.PartToBeBolted = cp;
            b.PartToBoltTo = cp;

            b.FirstPosition = new TSG.Point(0, 20000, 0);
            b.SecondPosition = new TSG.Point(1000, 21000, 0);

            b.BoltSize = 16;
            b.Tolerance = 3.00;
            b.BoltStandard = "7968";
            b.BoltType = BoltGroup.BoltTypeEnum.BOLT_TYPE_WORKSHOP;
            b.CutLength = 105;
            b.StartPointOffset.Dx = 1;
            b.EndPointOffset.Dx = 2;
            b.StartPointOffset.Dy = 3;
            b.EndPointOffset.Dy = 4;
            b.StartPointOffset.Dz = 5;
            b.EndPointOffset.Dz = 6;

            b.Length = 88;
            b.ExtraLength = 15;
            b.SlottedHoleX = 11;
            b.SlottedHoleY = 22;
            b.ThreadInMaterial = BoltGroup.BoltThreadInMaterialEnum.THREAD_IN_MATERIAL_NO;

            b.RotateSlots = BoltGroup.BoltRotateSlotsEnum.ROTATE_SLOTS_ODD;
            b.HoleType = BoltGroup.BoltHoleTypeEnum.HOLE_TYPE_OVERSIZED;

            b.Position.Depth = Position.DepthEnum.MIDDLE;
            b.Position.DepthOffset = 3;
            b.Position.Plane = Position.PlaneEnum.MIDDLE;
            b.Position.PlaneOffset = 1;
            b.Position.Rotation = Position.RotationEnum.FRONT;
            b.Position.RotationOffset = 2;

            b.Bolt = true;
            b.Washer1 = true;
            b.Washer2 = true;
            b.Washer3 = true;
            b.Nut1 = true;
            b.Nut2 = true;

            b.Hole1 = true;
            b.Hole2 = true;
            b.Hole3 = true;
            b.Hole4 = true;
            b.Hole5 = true;

            b.NumberOfBolts = 7;
            b.Diameter = 160;

            if (!b.Insert())
                WriteLine("BoltCircle Insert Failed!");
            else
                ObjectList.Add(b);
            WriteLine(b.Identifier.ID.ToString());

            BoltCircle Bsel = new BoltCircle();
            Bsel.Identifier = b.Identifier;

            if (!Bsel.Select())
                WriteLine("BoltCircle Select failed!");
            WriteLine(Bsel.Identifier.ID.ToString());

            b.BoltSize = 20;
            b.Tolerance = 4.00;
            b.BoltStandard = "7990";
            b.BoltType = BoltGroup.BoltTypeEnum.BOLT_TYPE_SITE;
            b.CutLength = 155;
            b.StartPointOffset.Dx = 11;
            b.EndPointOffset.Dx = 12;
            b.StartPointOffset.Dy = 13;
            b.EndPointOffset.Dy = 14;
            b.StartPointOffset.Dz = 15;
            b.EndPointOffset.Dz = 16;

            b.Length = 88;
            b.ExtraLength = 45;
            b.SlottedHoleX = 55;
            b.SlottedHoleY = 66;
            b.ThreadInMaterial = BoltGroup.BoltThreadInMaterialEnum.THREAD_IN_MATERIAL_YES;

            b.RotateSlots = BoltGroup.BoltRotateSlotsEnum.ROTATE_SLOTS_EVEN;
            b.HoleType = BoltGroup.BoltHoleTypeEnum.HOLE_TYPE_SLOTTED;

            b.Position.Depth = Position.DepthEnum.FRONT;
            b.Position.DepthOffset = 13;
            b.Position.Plane = Position.PlaneEnum.LEFT;
            b.Position.PlaneOffset = 11;
            b.Position.Rotation = Position.RotationEnum.TOP;
            b.Position.RotationOffset = 12;

            b.Bolt = true;
            b.Washer1 = false;
            b.Washer2 = false;
            b.Washer3 = false;
            b.Nut1 = true;
            b.Nut2 = true;

            b.Hole1 = true;
            b.Hole2 = false;
            b.Hole3 = true;
            b.Hole4 = false;
            b.Hole5 = true;

            b.NumberOfBolts = 9;
            b.Diameter = 240;

            if (!b.Modify())
                WriteLine("BoltCircle Modify failed!");
            WriteLine(b.Identifier.ID.ToString());
            WriteLine("BoltCircle complete!");
        }

        private void LoadPointTest()
        {
            WriteLine("Starting LoadPointTest...");
            Beam FatherBeam = new Beam(new TSG.Point(0, 24000, 0), new TSG.Point(1000, 24000, 0));
            FatherBeam.Profile.ProfileString = "HI400-15-20*400";
            if (FatherBeam.Insert())
                WriteLine("Father Beam Insert failed!");
            else
                ObjectList.Add(FatherBeam);
            WriteLine(FatherBeam.Identifier.ID.ToString());

            LoadPoint L = new LoadPoint();
            L.P = new Vector(3000, 4000, 5000);
            L.Moment = new Vector(6000, 7000, 8000);
            L.Position = new TSG.Point(0, 24000, 0);

            L.FatherId = FatherBeam.Identifier;

            L.AutomaticPrimaryAxisWeight = true;
            L.BoundingBoxDx = 500;
            L.BoundingBoxDy = 500;
            L.BoundingBoxDz = 500;
            L.LoadDispersionAngle = 0.77;
            L.PartFilter = "testing";
            L.PartNames = TSM.Load.LoadPartNamesEnum.LOAD_PART_NAMES_INCLUDE;
            L.PrimaryAxisDirection = new Vector(1000, 500, 0);
            L.Spanning = TSM.Load.LoadSpanningEnum.LOAD_SPANNING_SINGLE;
            L.Weight = 2;
            L.CreateFixedSupportConditionsAutomatically = true;

            L.LoadAttachment = TSM.Load.LoadAttachmentEnum.LOAD_ATTACHMENT_ATTACH_TO_MEMBER;

            if (!L.Insert())
                WriteLine("LoadPoint Insert failed!");
            else
                ObjectList.Add(L);
            WriteLine("LoadPoint ID " + " " + L.Identifier.ID.ToString());

            LoadPoint LSel = new LoadPoint();
            LSel.Identifier = L.Identifier;

            if (!LSel.Select())
                WriteLine("LoadPoint Select failed!");
            WriteLine(LSel.Identifier.ID.ToString());

            L.P = new Vector(13000, 14000, 15000);
            L.Moment = new Vector(16000, 17000, 18000);
            L.Position = new TSG.Point(1000, 24000, 0);

            L.AutomaticPrimaryAxisWeight = false;
            L.BoundingBoxDx = 1500;
            L.BoundingBoxDy = 1500;
            L.BoundingBoxDz = 1500;
            L.LoadDispersionAngle = 0.99;
            L.PartFilter = "testing modified";
            L.PartNames = TSM.Load.LoadPartNamesEnum.LOAD_PART_NAMES_EXCLUDE;
            L.PrimaryAxisDirection = new Vector(2000, 1500, 0);
            L.Spanning = TSM.Load.LoadSpanningEnum.LOAD_SPANNING_DOUBLE;
            L.Weight = 5;
            L.CreateFixedSupportConditionsAutomatically = false;

            L.LoadAttachment = TSM.Load.LoadAttachmentEnum.LOAD_ATTACHMENT_DONT_ATTACH;

            if (!L.Modify())
                WriteLine("LoadPoint Modify failed!");
            WriteLine(L.Identifier.ID.ToString());
            WriteLine("LoadPoint complete!");


        }

        #endregion
    }
}
