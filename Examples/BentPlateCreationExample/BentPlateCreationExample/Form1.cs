using System;
using System.Collections.Generic;
using System.Windows.Forms;

using Tekla.Structures.Geometry3d;
using Tekla.Structures.Model;

namespace BentPlateCreationExample
{
    public partial class Form1 : Form
    {
        #region Field
        BentPlate bentPlate;
        ContourPlate samplePlate1, samplePlate2;
        Model model;
        #endregion

        public Form1()
        {
            #region Initialize
            InitializeComponent();
            bentPlate = null;
            samplePlate1 = null;
            samplePlate2 = null;
            model = new Model();
            #endregion

            #region Event : Click
            CreateSamplePlatesButton.Click += CreateSamplePlatesButton_Click;
            CreateMaxRadiusBendPlate.Click += CreateMaxRadiusBendPlate_Click;

            CreateSamplePlatesButton2.Click += CreateSamplePlatesButton2_Click;
            CreateBentPlateWithGivenRadius.Click += CreateBentPlateWithGivenRadius_Click;

            CreateByFacesSamplePlates.Click += CreateByFacesSamplePlates_Click;
            CreateSampleBentPlateByFaces.Click += CreateSampleBentPlateByFaces_Click;

            SimpleCreateByAddLeg.Click += SimpleCreateByAddLeg_Click;
            CreateByAddLegWithRadius.Click += CreateByAddLegWithRadius_Click;
            CreateByAddLegUsingSegments.Click += CreateByAddLegUsingSegments_Click;

            #endregion
        }

        #region Evnet : Click

        private void CreateSamplePlatesButton_Click(object sender, EventArgs e)
        {
            CheckAndCreateSamplePlates();
        }

        private void CreateMaxRadiusBendPlate_Click(object sender, EventArgs e)
        {
            try
            {
                if (samplePlate1 != null && samplePlate2 != null)
                {
                    bentPlate = Tekla.Structures.Model.Operations.Operation.CreateBentPlateByParts(samplePlate1, samplePlate2);
                    model.CommitChanges();
                }
                else
                {
                    CreateMaxRadiusBendPlate.Enabled = false;
                }
            }
            catch (Exception Ex)
            {
                Console.WriteLine("Exception : " + Ex.ToString());
            }
        }

        private void CreateSamplePlatesButton2_Click(object sender, EventArgs e)
        {
            CreateBentPlateWithGivenRadius.Enabled = true;
            CheckAndCreateSamplePlates();
        }

        private void CreateBentPlateWithGivenRadius_Click(object sender, EventArgs e)
        {
            try
            {
                if (samplePlate1 != null && samplePlate2 != null)
                {
                    double radius = (double)this.radiusValue.Value;
                    if(radius < 100.0 && radius > 1500.0)
                    {
                        bentPlate = Tekla.Structures.Model.Operations.Operation.CreateBentPlateByParts(samplePlate1, samplePlate2, 600.0);
                    }
                    else
                    {
                        bentPlate = Tekla.Structures.Model.Operations.Operation.CreateBentPlateByParts(samplePlate1, samplePlate2, radius);
                    }

                    model.CommitChanges();
                }
                else
                {
                    CreateMaxRadiusBendPlate.Enabled = false;
                }
            }
            catch(Exception Ex)
            {
                Console.WriteLine("Exception : " + Ex.ToString());
            }
        }

        private void CreateByFacesSamplePlates_Click(object sender, EventArgs e)
        {
            CreateSampleBentPlateByFaces.Enabled = true;
            CheckAndCreateSamplePlates();
        }

        private void CreateSampleBentPlateByFaces_Click(object sender, EventArgs e)
        {
            try
            {
                IList<Point> face1 = new List<Point>
                {
                    new Point(0, 3000.0, -10.0),
                    new Point(0, 3000.0, 10.0),
                    new Point(3000.0, 3000.0, 10.0),
                    new Point(30000.0, 3000.0, -10)
                };

                IList<Point> face2 = new List<Point>
                {
                    new Point(0, 6010.0, 1500.0),
                    new Point(0, 5990.0, 1500.0),
                    new Point(3000.0, 5990.0, 1500.0),
                    new Point (3000.0, 6010.0, 1500.0)
                };

                if (samplePlate1 != null && samplePlate2 != null)
                {
                    bentPlate = Tekla.Structures.Model.Operations.Operation.CreateBentPlateByFaces(samplePlate1, face1, samplePlate2, face2);
                    model.CommitChanges();
                }
                else
                {
                    CreateMaxRadiusBendPlate.Enabled = false;
                }
            }
            catch (Exception Ex)
            {
                Console.WriteLine("Exception : ", Ex.ToString());
            }
        }

        private void SimpleCreateByAddLeg_Click(object sender, EventArgs e)
        {
            try
            {
                if(bentPlate != null)
                {
                    bentPlate.Delete();
                }

                var contour1 = new Contour();
                contour1.AddContourPoint(new ContourPoint(new Point(0, 0, 0), null));
                contour1.AddContourPoint(new ContourPoint(new Point(3000.0, 0, 0), null));
                contour1.AddContourPoint(new ContourPoint(new Point(3000.0, 3000.0, 0), null));
                contour1.AddContourPoint(new ContourPoint(new Point(0, 3000.0, 0), null));

                ConnectiveGeometry geometry = new ConnectiveGeometry(contour1);

                var contour2 = new Contour();
                contour2.AddContourPoint(new ContourPoint(new Point(0, 6000.0, 1500.0), null));
                contour2.AddContourPoint(new ContourPoint(new Point(3000.0, 6000.0, 1500.0), null));
                contour2.AddContourPoint(new ContourPoint(new Point(3000.0, 6000.0, 4500.0), null));
                contour2.AddContourPoint(new ContourPoint(new Point(0, 6000.0, 4500.0), null));

                BentPlateGeometrySolver solver = new BentPlateGeometrySolver();
                geometry = solver.AddLeg(geometry, contour2);

                bentPlate = new BentPlate
                {
                    Name = "Plate",
                    Material = { MaterialString = "S235JR" },
                    Profile = { ProfileString = "PL20" }
                };

                bentPlate.Geometry = geometry;
                bentPlate.Insert();
                model.CommitChanges();
            }
            catch(Exception Ex)
            {
                Console.WriteLine("Exception : ", Ex.ToString());
            }
        }

        private void CreateByAddLegWithRadius_Click(object sender, EventArgs e)
        {
            try
            {
                if (bentPlate != null)
                {
                    bentPlate.Delete();
                }

                var contour1 = new Contour();
                contour1.AddContourPoint(new ContourPoint(new Point(0, 0, 0), null));
                contour1.AddContourPoint(new ContourPoint(new Point(3000.0, 0, 0), null));
                contour1.AddContourPoint(new ContourPoint(new Point(3000.0, 3000.0, 0), null));
                contour1.AddContourPoint(new ContourPoint(new Point(0, 3000.0, 0), null));

                ConnectiveGeometry geometry = new ConnectiveGeometry(contour1);

                var contour2 = new Contour();
                contour2.AddContourPoint(new ContourPoint(new Point(0, 6000.0, 1500.0), null));
                contour2.AddContourPoint(new ContourPoint(new Point(3000.0, 6000.0, 1500.0), null));
                contour2.AddContourPoint(new ContourPoint(new Point(3000.0, 6000.0, 4500.0), null));
                contour2.AddContourPoint(new ContourPoint(new Point(0, 6000.0, 4500.0), null));

                double radius = (double)RadiusForAddLegCreation.Value;

                BentPlateGeometrySolver solver = new BentPlateGeometrySolver();
                geometry = solver.AddLeg(geometry, contour2, radius);

                bentPlate = new BentPlate
                {
                    Name = "Plate",
                    Material = { MaterialString = "S235JR" },
                    Profile = { ProfileString = "PL20" },
                };

                bentPlate.Geometry = geometry;
                bentPlate.Insert();
                model.CommitChanges();
            }
            catch (Exception Ex)
            {
                Console.WriteLine("Exception : ", Ex.ToString());
            }
        }

        private void CreateByAddLegUsingSegments_Click(object sender, EventArgs e)
        {
            try
            {
                if (bentPlate != null)
                {
                    bentPlate.Delete();
                }

                var contour1 = new Contour();
                contour1.AddContourPoint(new ContourPoint(new Point(0, 0, 0), null));
                contour1.AddContourPoint(new ContourPoint(new Point(3000.0, 0, 0), null));
                contour1.AddContourPoint(new ContourPoint(new Point(3000.0, 3000.0, 0), null));
                contour1.AddContourPoint(new ContourPoint(new Point(0, 3000.0, 0), null));

                ConnectiveGeometry geometry = new ConnectiveGeometry(contour1);

                var contour2 = new Contour();
                contour2.AddContourPoint(new ContourPoint(new Point(0, 6000.0, 1500.0), null));
                contour2.AddContourPoint(new ContourPoint(new Point(3000.0, 6000.0, 1500.0), null));
                contour2.AddContourPoint(new ContourPoint(new Point(3000.0, 6000.0, 4500.0), null));
                contour2.AddContourPoint(new ContourPoint(new Point(0, 6000.0, 4500.0), null));

                double radius = (double)RadiusForAddLegWithSegments.Value;

                LineSegment faceSegment1 = new LineSegment(new Point(500.0, 3000.0, 0), new Point(2500.0, 3000.0, 0));
                LineSegment faceSegment2 = new LineSegment(new Point(500.0, 6000.0, 1500.0), new Point(2500.0, 6000.0, 1500.0));

                BentPlateGeometrySolver solver = new BentPlateGeometrySolver();
                geometry = solver.AddLeg(geometry, faceSegment1, contour2, faceSegment2, radius);

                bentPlate = new BentPlate
                {
                    Name = "Plate",
                    Material = {MaterialString ="S235JR"},
                    Profile = { ProfileString = "PL20" }
                };

                bentPlate.Geometry = geometry;
                bentPlate.Insert();
                model.CommitChanges();
            }
            catch(Exception Ex)
            {
                Console.WriteLine("Exception : ", Ex.ToString());
            }
        }

        #endregion

        #region Private

        private void CheckAndCreateSamplePlates()
        {
            if(!CreateMaxRadiusBendPlate.Enabled)
            {
                CreateMaxRadiusBendPlate.Enabled = true;
            }

            if (bentPlate != null)
            {
                bentPlate.Delete();
                bentPlate = null;
            }

            CreateSamplePlates();
        }

        private void CreateSamplePlates()
        {
            var contour1 = new Contour();
            contour1.AddContourPoint(new ContourPoint(new Point(0, 0, 0), null));
            contour1.AddContourPoint(new ContourPoint(new Point(3000.0, 0, 0), null));
            contour1.AddContourPoint(new ContourPoint(new Point(3000.0, 3000.0, 0), null));
            contour1.AddContourPoint(new ContourPoint(new Point(0, 3000.0, 0), null));

            samplePlate1 = new ContourPlate
            {
                Name = "Plate",
                Material = { MaterialString = "S235JR" },
                Profile = { ProfileString = "PL20" },
                Position = { Depth = Position.DepthEnum.MIDDLE, DepthOffset = 0 }
            };

            samplePlate1.Contour = contour1;
            samplePlate1.Insert();

            var contour2 = new Contour();
            contour2.AddContourPoint(new ContourPoint(new Point(0, 6000.0, 1500.0), null));
            contour2.AddContourPoint(new ContourPoint(new Point(3000.0, 6000.0, 1500.0), null));
            contour2.AddContourPoint(new ContourPoint(new Point(3000.0, 6000.0, 4500.0), null));
            contour2.AddContourPoint(new ContourPoint(new Point(0, 6000.0, 4500.0), null));

            samplePlate2 = new ContourPlate
            {
                Name = "Plate",
                Material = { MaterialString = "S235JR" },
                Profile = { ProfileString = "PL20" },
                Position = { Depth = Position.DepthEnum.MIDDLE, DepthOffset = 0 }
            };

            samplePlate2.Contour = contour2;
            samplePlate2.Insert();

            model.CommitChanges();
        }

        #endregion

    }
}
