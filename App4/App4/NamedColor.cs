using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

using Xamarin.Forms;

namespace App4
{
    public class NamedColor
    {
        private NamedColor()
        {
        }
        public string Name { private set; get; }
        public string FriendName { private set; get; }
        public Color Color { private set; get; }
        
        static NamedColor()
        {
            List<NamedColor> all = new List<NamedColor>();
            StringBuilder stringbuilder = new StringBuilder();
            foreach (FieldInfo fieldInfo in typeof(Color).GetRuntimeFields())
            {
                if (fieldInfo.IsPublic && fieldInfo.IsStatic && fieldInfo.FieldType == typeof(Color))
                {
                    string name = fieldInfo.Name;
                    stringbuilder.Clear();
                    int index = 0;

                    foreach (char ch in name)
                    {
                        if (index != 0 && char.IsUpper(ch))
                        {
                            stringbuilder.Append(" ");
                        }
                        stringbuilder.Append(ch);
                        index++;
                    }
                    NamedColor namedcolor = new NamedColor
                    {
                        Name = name,
                        FriendName = stringbuilder.ToString(),
                        Color = (Color)fieldInfo.GetValue(null)
                    };
                    all.Add(namedcolor);

                }
            }
            all.TrimExcess();

            All = all;
        }

        public static IEnumerable<NamedColor> All { private set; get; }
    }
}