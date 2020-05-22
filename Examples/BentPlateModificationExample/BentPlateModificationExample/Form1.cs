using System;
using System.Windows.Forms;

using Tekla.Structures.Model;
using Tekla.Structures.Geometry3d;

namespace BentPlateModificationExample
{
    public partial class Form1 : Form
    {
        BentPlate bentPlate;
        Model model;

        public Form1()
        {
            #region Initialize
            InitializeComponent();
            bentPlate = null;
            model = new Model();
            #endregion

            #region Event : Click
            CreateSimpleBentPlate1.Click += CreateSimpleBentPlate1_Click;
            ModifyPlateSide.Click += ModifyPlateSide_Click;

            CreateSimpleBentPlate2.Click += CreateSimpleBentPlate2_Click;
            ModifyRadius.Click += ModifyRadius_Click;

            CreateSimpleBentPlate3.Click += CreateSimpleBentPlate3_Click;
            ModifyCylindricalSide.Click += ModifyCylindricalSide_Click;

            #endregion
        }

        #region Event : Click

        private void CreateSimpleBentPlate1_Click(object sender, EventArgs e)
        {
            ModifyPlateSide.Enabled = true;
            CreateSimpleBentPlate();
        }

        private void ModifyPlateSide_Click(object sender, EventArgs e)
        {
            ModifyPlateSide.Enabled = false;

            var geometryEnumerator = bentPlate.Geometry.GetGeometryEnumerator();

            while(geometryEnumerator.MoveNext())
            {
                if(geometryEnumerator.Current.GeometryNode is PolygonNode)
                {
                    break;
                }
            }

            if (geometryEnumerator.Current != null)
            {
                var contour1 = new Contour();
                contour1.AddContourPoint(new ContourPoint(new Point(500.0, 0, 0), null));
                contour1.AddContourPoint(new ContourPoint(new Point(2000.0, 0, 0), null));
                contour1.AddContourPoint(new ContourPoint(new Point(2000.0, 3000.0, 0), null));
                contour1.AddContourPoint(new ContourPoint(new Point(500.0, 3000.0, 0), null));

                try
                {
                    BentPlateGeometrySolver solver = new BentPlateGeometrySolver();

                    var changedGeoMetry = solver.ModifyPolygon(bentPlate.Geometry, geometryEnumerator.Current, contour1);

                    bentPlate.Geometry = changedGeoMetry;
                    bentPlate.Modify();
                    model.CommitChanges();
                }
                catch(Exception Ex)
                {
                    Console.WriteLine("Exception : ", Ex.ToString());
                }

            }
        }

        private void CreateSimpleBentPlate2_Click(object sender, EventArgs e)
        {
            ModifyRadius.Enabled = true;
            CreateSimpleBentPlate();
        }

        private void ModifyRadius_Click(object sender, EventArgs e)
        {
            ModifyRadius.Enabled = false;

            double radiusValue = (double)RadiusValue.Value;

            var geometryEnumerator = bentPlate.Geometry.GetGeometryEnumerator();

            while(geometryEnumerator.MoveNext())
            {
                if(geometryEnumerator.Current.GeometryNode is CylindricalSurfaceNode)
                {
                    break;
                }
            }

            if (geometryEnumerator.Current != null)
            {
                try
                {
                    BentPlateGeometrySolver solver = new BentPlateGeometrySolver();

                    var changedGeometry = solver.ModifyRadius(bentPlate.Geometry, geometryEnumerator.Current, radiusValue);

                    bentPlate.Geometry = changedGeometry;
                    bentPlate.Modify();
                    model.CommitChanges();
                }
                catch (Exception Ex)
                {
                    Console.WriteLine("Exception : ", Ex.ToString());
                }
            }
        }

        private void CreateSimpleBentPlate3_Click(object sender, EventArgs e)
        {
            ModifyCylindricalSide.Enabled = true;
            CreateSimpleBentPlate();
        }

        private void ModifyCylindricalSide_Click(object sender, EventArgs e)
        {
            ModifyCylindricalSide.Enabled = false;

            var geometryEnumerator = bentPlate.Geometry.GetGeometryEnumerator();

            CylindricalSurfaceNode cylindricalSection = null;
            while(geometryEnumerator.MoveNext())
            {
                if(geometryEnumerator.Current.GeometryNode is CylindricalSurfaceNode)
                {
                    cylindricalSection = geometryEnumerator.Current.GeometryNode as CylindricalSurfaceNode;
                    break;
                }
            }
            
            if (cylindricalSection != null)
            {
                try
                {
                    Vector endFaceNormal1 = cylindricalSection.Surface.EndFaceNormal1;
                    Vector endFaceNormal2 = cylindricalSection.Surface.EndFaceNormal2;
                    LineSegment sideBoundary1 = new LineSegment(new Point(500.0, 4500.0, 0), new Point(2500.0, 4500.0, 0));
                    LineSegment sideBoundary2 = new LineSegment(new Point(500.0, 6000.0, 1500.0), new Point(2500.0, 6000.0, 1500.0));

                    CylindricalSurface newCylindricalSurface = new CylindricalSurface(endFaceNormal1, endFaceNormal2, sideBoundary1, sideBoundary2);

                    BentPlateGeometrySolver solver = new BentPlateGeometrySolver();

                    var changedGeometry = solver.ModifyCylindricalSurface(bentPlate.Geometry, geometryEnumerator.Current, newCylindricalSurface);

                    bentPlate.Geometry = changedGeometry;
                    bentPlate.Modify();
                    model.CommitChanges();
                }
                catch (Exception Ex)
                {
                    Console.WriteLine("Exception : ", Ex.ToString());
                }
            }
        }

        #endregion


        #region Private

        private void CreateSimpleBentPlate()
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
                    Name = "Plate"
                    , Material = { MaterialString = "S235JR" }
                    , Profile = { ProfileString = "PL20" }
                };

                bentPlate.Geometry = geometry;
                bentPlate.Insert();
                model.CommitChanges();
            }
            catch(Exception EX)
            {
                Console.WriteLine("Exception : ", EX.ToString());
            }
        }

        #endregion
    }
}
