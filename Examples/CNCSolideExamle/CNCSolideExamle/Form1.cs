using System;
using System.Collections.Generic;
using System.Windows.Forms;

using Tekla.Structures.Model;
using Tekla.Structures.Solid;

namespace CNCSolideExamle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            button1.Click += Button1_Click;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Model model = new Model();
            double MaximumOffset = double.Parse(textBox1.Text);

            Dictionary<Plane, Face> FirstBeamPlanes = new Dictionary<Plane, Face>();
            Dictionary<Plane, Face> SecondaryBeamPlane = new Dictionary<Plane, Face>();

            CNCSolidLogic.GetParts(ref FirstBeamPlanes, ref SecondaryBeamPlane);
            CNCSolidLogic.CompareNormals(FirstBeamPlanes, SecondaryBeamPlane, MaximumOffset);

            model.CommitChanges();
        }
    }
}
