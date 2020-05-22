using System;
using System.Collections.Generic;
using System.Windows.Forms;

using Tekla.Structures.Catalogs;
using Tekla.Structures.Geometry3d;
using Tekla.Structures.Model;

namespace BRepExample
{
    public partial class Form1 : Form
    {
        const string ShapeName = "SimpleBoxShape";
        double Length { get; set; }

        public Form1()
        {
            #region Initialize

            InitializeComponent();
            Length = 500.0;

            #endregion

            #region Event : Click

            BtnInsertCube.Click += BtnInsertCube_Click;
            BtnInsertCutCube.Click += BtnInsertCutCube_Click;
            BtnModifyPyramid.Click += BtnModifyPyramid_Click;
            BtnAddCurrentModel.Click += BtnAddCurrentModel_Click;
            BtnValidateCube.Click += BtnValidateCube_Click;
            #endregion
        }

        #region Event : Click

        private void BtnInsertCube_Click(object sender, EventArgs e)
        {
            if(shapeSize != null && !string.IsNullOrEmpty(shapeSize.Text))
            {
                Length = double.Parse(shapeSize.Text);
            }

            var polymesh = CreateBrepCube(Length);

            var shapeItem = new ShapeItem
            {
                Name = ShapeName,
                ShapeFacetedBrep = polymesh,
                UpAxis = ShapeUpAxis.Z_Axis
            };

            shapeItem.Delete();

            var result = shapeItem.Insert();
            BtnModifyPyramid.Enabled = true;
            BtnAddCurrentModel.Enabled = true;

            shapeTypeBox.Text = "Cube";
        }

        private void BtnInsertCutCube_Click(object sender, EventArgs e)
        {
            if (shapeSize != null && !string.IsNullOrEmpty(shapeSize.Text))
            {
                Length = double.Parse(shapeSize.Text);
            }

            var polymesh = CreateCutBrepCube(Length);

            var shapeItem = new ShapeItem
            {
                Name = ShapeName,
                ShapeFacetedBrep = polymesh,
                UpAxis = ShapeUpAxis.Z_Axis
            };

            shapeItem.Delete();
            var result = shapeItem.Insert();
            BtnModifyPyramid.Enabled = true;
            BtnAddCurrentModel.Enabled = true;

            shapeTypeBox.Text = "CutCube";
        }

        private void BtnModifyPyramid_Click(object sender, EventArgs e)
        {
            if(shapeSize != null && !string.IsNullOrEmpty(shapeSize.Text))
            {
                Length = double.Parse(shapeSize.Text);
            }

            var pyramidBrep = CreateBrepPyramid(Length);

            var modifyShapeItem = new ShapeItem
            {
                Name = ShapeName,
                ShapeFacetedBrep = pyramidBrep,
                UpAxis = ShapeUpAxis.Z_Axis
            };

            var resultOfModify = modifyShapeItem.Modify();
            shapeTypeBox.Text = "Pyramid";
        }

        private void BtnAddCurrentModel_Click(object sender, EventArgs e)
        {
            var xPos = 0.0;
            if(this.xPos != null && !string.IsNullOrEmpty(this.xPos.Text))
            {
                xPos = double.Parse(this.xPos.Text);
            }

            var yPos = 0.0;
            if(this.yPos != null && !string.IsNullOrEmpty(this.yPos.Text) )
            {
                yPos = double.Parse(this.yPos.Text);
            }

            var brep = new Brep();
            brep.StartPoint = new Point(xPos, yPos, 0);
            brep.EndPoint = new Point(xPos + Length, yPos, 0);
            brep.Profile.ProfileString = ShapeName;
            brep.Insert();

            var model = new Model();
            model.CommitChanges();
        }

        private void BtnValidateCube_Click(object sender, EventArgs e)
        {
            var cubeBRep = CreateBrepCube(500.0);

            var invalidInfo = new List<KeyValuePair<int, Polymesh.PolymeshHealthCheckEnum>>();
            var result = Polymesh.Validate(cubeBRep, Polymesh.PolymeshCheckerFlags.All, ref invalidInfo);

            if(result)
            {
                validateResult.Text = "The cube has valid geometry";
            }
            else
            {
                validateResult.Text = "The cube has invalid geometry";
            }
        }

        #endregion

        private FacetedBrep CreateBrepCube(double length)
        {
            var vertices = new[]
            {
                new Vector(0, 0, 0)
                , new Vector(length, 0, 0)
                , new Vector(length, length, 0)
                , new Vector(0, length, 0)
                , new Vector(0, 0, length)
                , new Vector(length, 0, length)
                , new Vector(length, length, length)
                , new Vector(0, length, length)
            };

            var outloop = new[]
            {
                new[] {0,3,2,1}
                , new[] {0,1,5,4}
                , new[] {1,2,6,5}
                , new[] {2,3,7,6}
                , new[] {3,0,4,7}
                , new[] {4,5,6,7}
            };

            var innerLoop = new Dictionary<int, int[][]> { };

            return new FacetedBrep(vertices, outloop, innerLoop);
        }

        private FacetedBrep CreateCutBrepCube(double length)
        {
            var vertices = new[]
            {
                new Vector(0, 0, 0),
                new Vector(length, 0, 0),
                new Vector(length, length, 0),
                new Vector(0, length, 0),
                new Vector(0, 0, length ),
                new Vector(length, 0, length),
                new Vector(length, length, length),
                new Vector(0, length, length),

                new Vector(length/4, length/4, 0),
                new Vector(length*3/4, length / 4, 0),
                new Vector(length*3/4, length *3/4, 0),
                new Vector(length/4, length *3/4, 0),
                new Vector(length/4, length/4, length ),
                new Vector(length*3/4, length/4, length),
                new Vector(length*3/4, length*3/4, length),
                new Vector(length/4, length*3/4, length)
            };

            var outloop = new[] { new[] { 0, 3, 2, 1 },
                                  new[] { 0, 1, 5, 4 },
                                  new[] { 1, 2, 6, 5 },
                                  new[] { 2, 3, 7, 6 },
                                  new[] { 3, 0, 4, 7 },
                                  new[] { 4, 5, 6, 7 },
                                  new[] {8, 12, 13, 9},
                                  new[] {11, 15, 12, 8},
                                  new[] {10, 14, 15, 11},
                                  new[] {9, 13, 14, 10}};

            var innerLoop = new Dictionary<int, int[][]>();
            innerLoop.Add(0, new[] { new[] { 8, 9, 10, 11 }, });
            innerLoop.Add(5, new[] { new[] { 12, 15, 14, 13 } });

            return new FacetedBrep(vertices, outloop, innerLoop);
        }

        private FacetedBrep CreateBrepPyramid(double length)
        {
            var vertices = new[]
            {
                new Vector(0, 0, 0)
                , new Vector(length, 0, 0)
                , new Vector(length, length, 0)
                , new Vector(0, length, 0)
                , new Vector(length/2, length/2, length )
            };

            var outloop = new[]
            {
                new[] {0,3,2,1 }
                , new[] {0,3,4 }
                , new[] {3,2,4}
                , new[] {2,1,4}
                , new[] {1,0,4}
            };
            var innerLoop = new Dictionary<int, int[][]> { };

            return new FacetedBrep(vertices, outloop, innerLoop);
        }
    }
}
