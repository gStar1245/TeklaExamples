using Tekla.Structures.Plugins;

namespace EllipsePlugin
{
    public class EllipsePluginData
    {
        [StructuresField("MajorAxis")] public double MajorAxis;

        [StructuresField("MinorAxis")] public double MinorAxis;

        [StructuresField("Percision")] public int Precision;

        [StructuresField("LineAttributes")] public string LineAttributes;

        internal void CheckDefaults(DrawingPluginBase dp)
        {
            if(dp.IsDefaultValue(MajorAxis))
            {
                MajorAxis = 100.0;
            }
            if(dp.IsDefaultValue(MinorAxis))
            {
                MinorAxis = 50.0;
            }
            if (dp.IsDefaultValue(Precision))
            {
                Precision = 36;
            }
            if (dp.IsDefaultValue(LineAttributes))
            {
                LineAttributes = "standard";
            }
        }
    }
}
