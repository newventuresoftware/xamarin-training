using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using Xamarin.Forms;

namespace XamlPlayground
{
    public static class ColorGenerator
    {
        public static IEnumerable<Tuple<string, Color>> GetColors()
        {
            foreach (FieldInfo info in typeof(Color).GetRuntimeFields())
            {
                // Skip the obsolete (i.e. misspelled) colors.
                if (info.GetCustomAttribute<ObsoleteAttribute>() != null)
                    continue;

                if (info.IsPublic && info.IsStatic && info.FieldType == typeof(Color) && info.Name != "Default")
                {
                    yield return new Tuple<string, Color>(info.Name, ((Color)info.GetValue(null)));
                }
            }
        }
    }
}
