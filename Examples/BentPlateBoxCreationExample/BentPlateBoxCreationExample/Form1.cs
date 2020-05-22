using System;
using System.Windows.Forms;

using Tekla.Structures.Model;
using Tekla.Structures.Geometry3d;

namespace BentPlateBoxCreationExample
{
    public partial class Form1 : Form
    {
        BentPlate bentPlate;
        ContourPlate bottomPlate, sidePlate1, sidePlate2, sidePlate3, sidePlate4;
        Model model;

        public Form1()
        {
            InitializeComponent();

            this.bentPlate = null;
            this.bottomPlate = null;
            this.sidePlate1 = null;
            this.sidePlate2 = null;
            this.sidePlate3 = null;
            this.sidePlate4 = null;
            this.model = new Model();

            CreateContourPlates.Click += CreateContourPlates_Click;
            CreateBends.Click += CreateBends_Click;
            CreateBoxUsingGeometry.Click += CreateBoxUsingGeometry_Click;
            CreateBoxUsingGeometryAndRadius.Click += CreateBoxUsingGeometryAndRadius_Click;
        }

        #region Event : Click

        private void CreateContourPlates_Click(object sender, EventArgs e)
        {
            if (bentPlate != null)
            {
                bentPlate.Delete();
                bentPlate = null;
            }

            CreatePlatesForBox();
            CreateBends.Enabled = true;
            CreateBoxWithCustomRadius.Enabled = true;
        }

        private void CreateBends_Click(object sender, EventArgs e)
        {
            CreateBends.Enabled = false;
            CreateBoxWithCustomRadius.Enabled = false;

            if (bentPlate != null)
            {
                bentPlate.Delete();
                bentPlate = null;
            }

            if (bottomPlate != null && sidePlate1 != null && sidePlate2 != null && sidePlate3 != null && sidePlate4 != null)
            {
                var bottomFacesEnum = bottomPlate.GetSolid().GetFaceEnumerator();
                while (bottomFacesEnum.MoveNext())
                {
                    if (bottomFacesEnum.Current.Normal.Y > 0 )
                    {
                        var plateBottomFace = GetPlateBottomFace(sidePlate2.GetSolid().GetFaceEnumerator());
                        CreateBend(bottomPlate, bottomFacesEnum.Current, sidePlate2, plateBottomFace);
                    }
                    else if (bottomFacesEnum.Current.Normal.Y < 0)
                    {
                        var plateBottomFace = GetPlateBottomFace(sidePlate4.GetSolid().GetFaceEnumerator());
                        CreateBend(bottomPlate, bottomFacesEnum.Current, sidePlate4, plateBottomFace);
                    }
                    if (bottomFacesEnum.Current.Normal.X > 0)
                    {
                        var plateBottomFace = GetPlateBottomFace(sidePlate3.GetSolid().GetFaceEnumerator());
                        CreateBend(bottomPlate, bottomFacesEnum.Current, sidePlate3, plateBottomFace);
                    }
                    else if (bottomFacesEnum.Current.Normal.X < 0)
                    {
                        var plateBottomFace = GetPlateBottomFace(sidePlate1.GetSolid().GetFaceEnumerator());
                        CreateBend(bottomPlate, bottomFacesEnum.Current, sidePlate1, plateBottomFace);
                    }
                }

                model.CommitChanges();
            }
        }

        private void CreateBoxUsingGeometry_Click(object sender, EventArgs e)
        {
            if (bentPlate != null)
            {
                bentPlate.Delete();
                bentPlate = null;
            }

            var bottomContour = new Contour();
            bottomContour.AddContourPoint(new ContourPoint(new Point(6000.0, 6000.0, 0), null));
            bottomContour.AddContourPoint(new ContourPoint(new Point(6000.0, 12000.0, 0), null));
            bottomContour.AddContourPoint(new ContourPoint(new Point(12000.0,12000.0, 0), null));
            bottomContour.AddContourPoint(new ContourPoint(new Point(12000.0, 6000.0, 0), null));

            var contour1 = new Contour();
            contour1.AddContourPoint(new ContourPoint(new Point(3000.0, 6000.0, 1500.0), null));
            contour1.AddContourPoint(new ContourPoint(new Point(3000.0, 12000.0, 1500.0), null));
            contour1.AddContourPoint(new ContourPoint(new Point(3000.0, 12000.0, 4500.0), null));
            contour1.AddContourPoint(new ContourPoint(new Point(3000.0, 6000.0, 4500.0), null));

            var contour2 = new Contour();
            contour2.AddContourPoint(new ContourPoint(new Point(6000.0, 15000.0, 1500.0), null));
            contour2.AddContourPoint(new ContourPoint(new Point(12000.0, 15000.0, 1500.0), null));
            contour2.AddContourPoint(new ContourPoint(new Point(12000.0, 15000.0, 4500.0), null));
            contour2.AddContourPoint(new ContourPoint(new Point(6000.0, 15000.0, 4500.0), null));

            var contour3 = new Contour();
            contour3.AddContourPoint(new ContourPoint(new Point(15000.0, 6000.0, 1500.0), null));
            contour3.AddContourPoint(new ContourPoint(new Point(15000.0, 12000.0, 1500.0), null));
            contour3.AddContourPoint(new ContourPoint(new Point(15000.0, 12000.0, 4500.0), null));
            contour3.AddContourPoint(new ContourPoint(new Point(15000.0, 6000.0, 4500.0), null));

            var contour4 = new Contour();
            contour4.AddContourPoint(new ContourPoint(new Point(6000.0, 3000.0, 1500.0), null));
            contour4.AddContourPoint(new ContourPoint(new Point(12000.0, 3000.0, 1500.0), null));
            contour4.AddContourPoint(new ContourPoint(new Point(12000.0, 3000.0, 4500.0), null));
            contour4.AddContourPoint(new ContourPoint(new Point(6000.0, 3000.0, 4500.0), null));

            ConnectiveGeometry geometry = new ConnectiveGeometry(bottomContour);

            BentPlateGeometrySolver solver = new BentPlateGeometrySolver();

            LineSegment segment1 = new LineSegment(new Point(6000.0, 6000.0, 0), new Point(6000.0, 12000.0, 0));
            LineSegment segment2 = new LineSegment(new Point(3000.0, 6000.0, 1500.0), new Point(3000.0, 12000.0, 1500.0));

            geometry = solver.AddLeg(geometry, segment1, contour1, segment2);

            segment1 = new LineSegment(new Point(6000.0, 12000.0, 0), new Point(12000.0, 12000.0, 0));
            segment2 = new LineSegment(new Point(6000.0, 15000.0, 1500.0), new Point(12000.0, 15000.0, 1500.0));

            geometry = solver.AddLeg(geometry, segment1, contour2, segment2);

            segment1 = new LineSegment(new Point(12000.0, 6000.0, 0), new Point(12000.0, 12000.0, 0));
            segment2 = new LineSegment(new Point(15000.0, 6000.0, 1500.0), new Point(15000.0, 12000.0, 1500.0));

            geometry = solver.AddLeg(geometry, segment1, contour3, segment2);

            segment1 = new LineSegment(new Point(6000.0, 6000.0, 0), new Point(12000.0, 6000.0, 0));
            segment2 = new LineSegment(new Point(6000.0, 3000.0, 1500.0), new Point(12000.0, 3000.0, 1500.0));

            geometry = solver.AddLeg(geometry, segment1, contour4, segment2);

            bentPlate = new BentPlate
            {
                Name = "Plate",
                Material = { MaterialString = "S235JR" },
                Profile = { ProfileString = "PL100" }
            };

            bentPlate.Geometry = geometry;
            bentPlate.Insert();
            model.CommitChanges();
        }

        private void CreateBoxUsingGeometryAndRadius_Click(object sender, EventArgs e)
        {
            if (bentPlate != null)
            {
                bentPlate.Delete();
                bentPlate = null;
            }

            double radius = (double)this.RadiusValueForAddLeg.Value;

            var bottomContour = new Contour();
            bottomContour.AddContourPoint(new ContourPoint(new Point(6000.0, 6000.0, 0), null));
            bottomContour.AddContourPoint(new ContourPoint(new Point(6000.0, 12000.0, 0), null));
            bottomContour.AddContourPoint(new ContourPoint(new Point(12000.0, 12000.0, 0), null));
            bottomContour.AddContourPoint(new ContourPoint(new Point(12000.0, 6000.0, 0), null));

            var contour1 = new Contour();
            contour1.AddContourPoint(new ContourPoint(new Point(3000.0, 6000.0, 1500.0), null));
            contour1.AddContourPoint(new ContourPoint(new Point(3000.0, 12000.0, 1500.0), null));
            contour1.AddContourPoint(new ContourPoint(new Point(3000.0, 12000.0, 4500.0), null));
            contour1.AddContourPoint(new ContourPoint(new Point(3000.0, 6000.0, 4500.0), null));

            var contour2 = new Contour();
            contour2.AddContourPoint(new ContourPoint(new Point(6000.0, 15000.0, 1500.0), null));
            contour2.AddContourPoint(new ContourPoint(new Point(12000.0, 15000.0, 1500.0), null));
            contour2.AddContourPoint(new ContourPoint(new Point(12000.0, 15000.0, 4500.0), null));
            contour2.AddContourPoint(new ContourPoint(new Point(6000.0, 15000.0, 4500.0), null));

            var contour3 = new Contour();
            contour3.AddContourPoint(new ContourPoint(new Point(15000.0, 6000.0, 1500.0), null));
            contour3.AddContourPoint(new ContourPoint(new Point(15000.0, 12000.0, 1500.0), null));
            contour3.AddContourPoint(new ContourPoint(new Point(15000.0, 12000.0, 4500.0), null));
            contour3.AddContourPoint(new ContourPoint(new Point(15000.0, 6000.0, 4500.0), null));

            var contour4 = new Contour();
            contour4.AddContourPoint(new ContourPoint(new Point(6000.0, 3000.0, 1500.0), null));
            contour4.AddContourPoint(new ContourPoint(new Point(12000.0, 3000.0, 1500.0), null));
            contour4.AddContourPoint(new ContourPoint(new Point(12000.0, 3000.0, 4500.0), null));
            contour4.AddContourPoint(new ContourPoint(new Point(6000.0, 3000.0, 4500.0), null));

            ConnectiveGeometry geometry = new ConnectiveGeometry(bottomContour);

            BentPlateGeometrySolver solver = new BentPlateGeometrySolver();

            LineSegment segment1 = new LineSegment(new Point(6000.0, 6000.0, 0), new Point(6000.0, 12000.0, 0));
            LineSegment segment2 = new LineSegment(new Point(3000.0, 6000.0, 1500.0), new Point(3000.0, 12000.0, 1500.0));

            geometry = solver.AddLeg(geometry, segment1, contour1, segment2, radius);

            segment1 = new LineSegment(new Point(6000.0, 12000.0, 0), new Point(12000.0, 12000.0, 0));
            segment2 = new LineSegment(new Point(6000.0, 15000.0, 1500.0), new Point(12000.0, 15000.0, 1500.0));

            geometry = solver.AddLeg(geometry, segment1, contour2, segment2, radius);

            segment1 = new LineSegment(new Point(12000.0, 6000.0, 0), new Point(12000.0, 12000.0, 0));
            segment2 = new LineSegment(new Point(15000.0, 6000.0, 1500.0), new Point(15000.0, 12000.0, 1500.0));

            geometry = solver.AddLeg(geometry, segment1, contour3, segment2, radius);

            segment1 = new LineSegment(new Point(6000.0, 6000.0, 0), new Point(12000.0, 6000.0, 0));
            segment2 = new LineSegment(new Point(6000.0, 3000.0, 1500.0), new Point(12000.0, 3000.0, 1500.0));

            geometry = solver.AddLeg(geometry, segment1, contour4, segment2, radius);

            bentPlate = new BentPlate
            {
                Name = "Plate",
                Material = { MaterialString = "S235JR" },
                Profile = { ProfileString = "PL100" }
            };

            bentPlate.Geometry = geometry;
            bentPlate.Insert();
            model.CommitChanges();
        }

        #endregion


        #region Private

        private void CreateBend(ContourPlate plate1, Tekla.Structures.Solid.Face face1, ContourPlate plate2, Tekla.Structures.Solid.Face face2)
        {
            if (bentPlate == null)
            {
                bentPlate = Tekla.Structures.Model.Operations.Operation.CreateBentPlateByFaces(plate1, face1, plate2, face2);
            }
            else
            {
                bentPlate = Tekla.Structures.Model.Operations.Operation.CreateBentPlateByFaces(bentPlate, face1, plate2, face2);
            }
        }

        private void CreateBendWithRadius(ContourPlate plate1, Tekla.Structures.Solid.Face face1, ContourPlate plate2, Tekla.Structures.Solid.Face face2, double radius)
        {
            if (bentPlate == null)
            {
                bentPlate = Tekla.Structures.Model.Operations.Operation.CreateBentPlateByFaces(plate1, face1, plate2, face2, radius);
            }
            else
            {
                bentPlate = Tekla.Structures.Model.Operations.Operation.CreateBentPlateByFaces(bentPlate, face1, plate2, face2, radius);
            }
        }

        private Tekla.Structures.Solid.Face GetPlateBottomFace(Tekla.Structures.Solid.FaceEnumerator faceEnumerator)
        {
            while(faceEnumerator.MoveNext())
            {
                if(faceEnumerator.Current.Normal.Z < 0)
                {
                    return faceEnumerator.Current;
                }
            }

            return null;
        }

        private void CreatePlatesForBox()
        {
            var bottomContour = new Contour();
            bottomContour.AddContourPoint(new ContourPoint(new Point(6000.0, 6000.0, 0), null));
            bottomContour.AddContourPoint(new ContourPoint(new Point(6000.0, 12000.0, 0), null));
            bottomContour.AddContourPoint(new ContourPoint(new Point(12000.0, 12000.0, 0), null));
            bottomContour.AddContourPoint(new ContourPoint(new Point(12000.0, 6000.0, 0), null));

            bottomPlate = new ContourPlate
            {
                Name = "Plate",
                Material = { MaterialString = "S2345JR" },
                Profile = { ProfileString = "PL100" },
                Position = { Depth = Position.DepthEnum.MIDDLE, DepthOffset = 0 },
                Contour = bottomContour
            };

            var contour1 = new Contour();
            contour1.AddContourPoint(new ContourPoint(new Point(3000.0, 6000.0, 1500.0), null));
            contour1.AddContourPoint(new ContourPoint(new Point(3000.0, 12000.0, 1500.0), null));
            contour1.AddContourPoint(new ContourPoint(new Point(3000.0, 12000.0, 4500.0), null));
            contour1.AddContourPoint(new ContourPoint(new Point(3000.0, 6000.0, 4500.0), null));

            sidePlate1 = new ContourPlate
            {
                Name = "Plate",
                Material = { MaterialString = "S235JR" },
                Profile = { ProfileString = "PL100" },
                Position = { Depth = Position.DepthEnum.MIDDLE, DepthOffset = 0 },
                Contour = contour1
            };

            var contour2 = new Contour();
            contour2.AddContourPoint(new ContourPoint(new Point(6000.0, 15000.0, 1500.0), null));
            contour2.AddContourPoint(new ContourPoint(new Point(12000.0, 15000.0, 1500.0), null));
            contour2.AddContourPoint(new ContourPoint(new Point(12000.0, 15000.0, 4500.0), null));
            contour2.AddContourPoint(new ContourPoint(new Point(6000.0, 15000.0, 4500.0), null));

            this.sidePlate2 = new ContourPlate
            {
                Name = "Plate",
                Material = { MaterialString = "S235JR" },
                Profile = { ProfileString = "PL100" },
                Position = { Depth = Position.DepthEnum.MIDDLE, DepthOffset = 0 },
                Contour = contour2
            };

            var contour3 = new Contour();
            contour3.AddContourPoint(new ContourPoint(new Point(15000.0, 6000.0, 1500.0), null));
            contour3.AddContourPoint(new ContourPoint(new Point(15000.0, 12000.0, 1500.0), null));
            contour3.AddContourPoint(new ContourPoint(new Point(15000.0, 12000.0, 4500.0), null));
            contour3.AddContourPoint(new ContourPoint(new Point(15000.0, 6000.0, 4500.0), null));

            sidePlate3 = new ContourPlate
            {
                Name = "Plate",
                Material = { MaterialString = "S235JR" },
                Profile = { ProfileString = "PL100" },
                Position = { Depth = Position.DepthEnum.MIDDLE, DepthOffset = 0 },
                Contour = contour3
            };

            var contour4 = new Contour();
            contour4.AddContourPoint(new ContourPoint(new Point(6000.0, 3000.0, 1500.0), null));
            contour4.AddContourPoint(new ContourPoint(new Point(12000.0, 3000.0, 1500.0), null));
            contour4.AddContourPoint(new ContourPoint(new Point(12000.0, 3000.0, 4500.0), null));
            contour4.AddContourPoint(new ContourPoint(new Point(6000.0, 3000.0, 4500.0), null));

            sidePlate4 = new ContourPlate
            {
                Name = "Plate",
                Material = { MaterialString = "S235JR" },
                Profile = { ProfileString = "PL100" },
                Position = { Depth = Position.DepthEnum.MIDDLE, DepthOffset = 0 },
                Contour = contour4
            };

            bottomPlate.Insert();
            sidePlate1.Insert();
            sidePlate2.Insert();
            sidePlate3.Insert();
            sidePlate4.Insert();
            model.CommitChanges();
        }


        #endregion
    }
}
