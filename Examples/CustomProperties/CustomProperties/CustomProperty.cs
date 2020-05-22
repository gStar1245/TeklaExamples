using System.ComponentModel.Composition;

using Tekla.Structures.Model;
using Tekla.Structures.CustomPropertyPlugin;

namespace CustomProperties
{
    [Export(typeof(ICustomPropertyPlugin))]
    [ExportMetadata("CustomProperty", "CUSTOM.FATHERCOMPONET")]
    public class CustomProperty : ICustomPropertyPlugin
    {
        private Model model = new Model();

        public int GetIntegerProperty(int objectID)
        {
            BaseComponent father = SelectFatherComponent(objectID);

            if (father != null)
                return father.Number;
            else
                return 0;
        }

        public string GetStringProperty(int objectID)
        {
            BaseComponent father = SelectFatherComponent(objectID);

            if (father != null)
                return father.Name;
            else
                return string.Empty;
        }

        public double GetDoubleProperty(int objectID)
        {
            BaseComponent father = SelectFatherComponent(objectID);

            if (father != null)
                return (double)father.Number;
            else
                return 0.0;
        }

        public BaseComponent SelectFatherComponent(int objectID)
        {
            BaseComponent result = null;

            ModelObject modelObject = model.SelectModelObject(new Tekla.Structures.Identifier(objectID));
            if (modelObject != null)
                result = modelObject.GetFatherComponent();

            return result;
        }

    }
}
