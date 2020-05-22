using System;
using System.Windows.Forms;

using Tekla.Structures;
using Tekla.Structures.Filtering;
using Tekla.Structures.Filtering.Categories;
using Tekla.Structures.Model;

namespace FilterExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            BtnPourObject.Click += BtnPourObject_Click;
            BtnPourUnits.Click += BtnPourUnits_Click;
            BtnFilterSurface.Click += BtnFilterSurface_Click;
        }

        private void BtnPourObject_Click(object sender, EventArgs e)
        {
            var filterDefinition = new BinaryFilterExpressionCollection();
            // CheckBox_PourNumber 가 체크됬고, textBox에 값이 존재할 때,
            if(checkBox_pourNumber.Checked && textBox_pourNumber != null && !string.IsNullOrEmpty(textBox_pourNumber.Text))
            {
                var filterExpression1 = new BinaryFilterExpression
                    (
                        new PourObjectFilterExpressions.PourNumber(), StringOperatorType.IS_EQUAL,
                        new StringConstantFilterExpression(textBox_pourNumber.Text)
                    );

                filterDefinition.Add(new BinaryFilterExpressionItem(filterExpression1, BinaryFilterOperatorType.BOOLEAN_AND));
            }

            if (checkBox_pourType.Checked && textBox_pourType != null && !string.IsNullOrEmpty(textBox_pourType.Text))
            {
                var filterExpression2 = new BinaryFilterExpression
                    (
                        new PourObjectFilterExpressions.PourType(), StringOperatorType.IS_EQUAL,
                        new StringConstantFilterExpression(textBox_pourType.Text)
                    );
                filterDefinition.Add(new BinaryFilterExpressionItem(filterExpression2, BinaryFilterOperatorType.BOOLEAN_AND));
            }

            if (checkBox_pourCM.Checked && textBox_CM != null && !string.IsNullOrEmpty(textBox_CM.Text))
            {
                var filterExpression3 = new BinaryFilterExpression
                    (
                        new PourObjectFilterExpressions.ConcreteMixture(), StringOperatorType.IS_EQUAL,
                        new StringConstantFilterExpression(textBox_CM.Text)
                    );
                filterDefinition.Add(new BinaryFilterExpressionItem(filterExpression3, BinaryFilterOperatorType.BOOLEAN_AND));
            }

            var filterExpression4 = new BinaryFilterExpression
                (
                    new ObjectFilterExpressions.Type(), NumericOperatorType.IS_EQUAL,
                    new NumericConstantFilterExpression(TeklaStructuresDatabaseTypeEnum.DB_POUR_OBJECT)
                );
            filterDefinition.Add(new BinaryFilterExpressionItem(filterExpression4));

            var model = new Model();
            var selector = model.GetModelObjectSelector();
            var enumerator = selector.GetObjectsByFilter(filterDefinition);
            if (enumerator != null)
                filteredPours.Text = enumerator.GetSize().ToString();
        }

        private void BtnPourUnits_Click(object sender, EventArgs e)
        {
            var filterDefinition = new BinaryFilterExpressionCollection();
            if(checkBox_PUName.Checked && textBox_PUName != null && !string.IsNullOrEmpty(textBox_PUName.Text))
            {
                var filterExpression1 = new BinaryFilterExpression
                    (
                        new PourUnitFilterExpressions.Name(), StringOperatorType.IS_EQUAL,
                        new StringConstantFilterExpression(textBox_PUName.Text)
                    );
                filterDefinition.Add(new BinaryFilterExpressionItem(filterExpression1, BinaryFilterOperatorType.BOOLEAN_AND));
            }

            var filterExpression2 = new BinaryFilterExpression
                (
                    new ObjectFilterExpressions.Type(), NumericOperatorType.IS_EQUAL,
                    new NumericConstantFilterExpression(TeklaStructuresDatabaseTypeEnum.DB_POUR_UNIT)
                );
            filterDefinition.Add(new BinaryFilterExpressionItem(filterExpression2));

            var model = new Model();
            var selector = model.GetModelObjectSelector();
            var enumerator = selector.GetObjectsByFilter(filterDefinition);
            if (enumerator != null)
                filteredPU.Text = enumerator.GetSize().ToString();
        }

        private void BtnFilterSurface_Click(object sender, EventArgs e)
        {
            var filterDefinition = new BinaryFilterExpressionCollection();
            if(checkBox_surfaceName.Checked && textBox_surfaceName != null && !string.IsNullOrEmpty(this.textBox_surfaceName.Text))
            {
                var filterExpression1 = new BinaryFilterExpression(
                    new SurfaceFilterExpressions.Name(), StringOperatorType.IS_EQUAL,
                    new StringConstantFilterExpression(this.textBox_surfaceName.Text));
                filterDefinition.Add(new BinaryFilterExpressionItem(filterExpression1, BinaryFilterOperatorType.BOOLEAN_AND));
            }

            if(checkBox_surfaceType.Checked && textBox_surfaceType != null && !string.IsNullOrEmpty(textBox_surfaceType.Text))
            {
                var filterExpression2 = new BinaryFilterExpression(
                    new SurfaceFilterExpressions.Type(), StringOperatorType.IS_EQUAL,
                    new StringConstantFilterExpression(textBox_surfaceType.Text));
                filterDefinition.Add(new BinaryFilterExpressionItem(filterExpression2, BinaryFilterOperatorType.BOOLEAN_AND));
            }

            if(checkBox_surfaceClass.Checked && textBox_surfaceClass != null && !string.IsNullOrEmpty(textBox_surfaceClass.Text))
            {
                var filterExpression3 = new BinaryFilterExpression(
                    new SurfaceFilterExpressions.Class(), NumericOperatorType.IS_EQUAL,
                    new NumericConstantFilterExpression(Int32.Parse(textBox_surfaceClass.Text)));
                filterDefinition.Add(new BinaryFilterExpressionItem(filterExpression3, BinaryFilterOperatorType.BOOLEAN_AND));
            }

            var filterExpression4 = new BinaryFilterExpression(new ObjectFilterExpressions.Type(),
                NumericOperatorType.IS_EQUAL, new NumericConstantFilterExpression(TeklaStructuresDatabaseTypeEnum.SURFACE_OBJECT));
            filterDefinition.Add(new BinaryFilterExpressionItem(filterExpression4));

            var model = new Model();
            var selector = model.GetModelObjectSelector();
            var enumerator = selector.GetObjectsByFilter(filterDefinition);
            if (enumerator != null)
                filteredSurfaces.Text = enumerator.GetSize().ToString();
        }
    }
}
