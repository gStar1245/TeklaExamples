using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tekla.Structures.Model;
using TSG = Tekla.Structures.Geometry3d;

namespace BeamApplication
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
            Model myModel = new Model();

            Beam myBeam = new Beam(new TSG.Point(1000, 1000, 1000),
                                   new TSG.Point(6000, 6000, 1000));
            myBeam.Material.MaterialString = "S235JR";
            myBeam.Profile.ProfileString = "HEA400";
            myBeam.Insert();
            myModel.CommitChanges();
        }
    }
}
