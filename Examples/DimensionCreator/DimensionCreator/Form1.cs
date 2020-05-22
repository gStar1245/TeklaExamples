using System;
using System.Windows.Forms;

namespace DimensionCreator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            #region Event
            angleDimensionButton.Click += AngleDimensionButton_Click;
            radiusDimensionButton.Click += RadiusDimensionButton_Click;
            straightDimensionButton.Click += StraightDimensionButton_Click;
            curvedRadialDimensionButton.Click += CurvedRadialDimensionButton_Click;
            curvedOrthogonalDimensionButton.Click += CurvedOrthogonalDimensionButton_Click;
            repeatCheckBox.CheckedChanged += RepeatCheckBox_CheckedChanged;
            numberOfPointsToPickNumericUpDown.ValueChanged += NumberOfPointsToPickNumericUpDown_ValueChanged;
            quitButton.Click += QuitButton_Click;

            #endregion
        }

        #region Event

        private void AngleDimensionButton_Click(object sender, EventArgs e)
        {
            try
            {
                DimensionCreator.CreateAngleDimension();
            }
            catch (Exception) { }
        }

        private void RadiusDimensionButton_Click(object sender, System.EventArgs e)
        {
            try
            {
                DimensionCreator.CreateRadiusDimension((double)this.distanceNumericUpDown.Value);
            }
            catch (Exception)
            {

            }
        }

        private void StraightDimensionButton_Click(object sender, System.EventArgs e)
        {
            try
            {
                DimensionCreator.CreateStraightDimension((double)this.distanceNumericUpDown.Value);
            }
            catch(Exception)
            {

            }
        }

        private void CurvedRadialDimensionButton_Click(object sender, System.EventArgs e)
        {
            try
            {
                DimensionCreator.CreateCurvedRadialDimension((double)this.distanceNumericUpDown.Value);
            }
            catch(Exception)
            {

            }
        }

        private void CurvedOrthogonalDimensionButton_Click(object sender, System.EventArgs e)
        {
            try
            {
                DimensionCreator.CreateCurvedOrthoDimension((double)this.numberOfPointsToPickNumericUpDown.Value);
            }
            catch (Exception)
            {

            }
        }

        private void NumberOfPointsToPickNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            DimensionCreator.Points = (int)this.numberOfPointsToPickNumericUpDown.Value;
        }

        private void RepeatCheckBox_CheckedChanged(object sender, System.EventArgs e)
        {
            DimensionCreator.Repeat = !DimensionCreator.Repeat;
        }

        private void QuitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion


    }
}
