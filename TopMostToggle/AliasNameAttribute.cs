using System;

namespace MyApp
{
    public class AliasNameAttribute : Attribute
    {
        public string Name { get; }

        public AliasNameAttribute(string name)
        {
            Name = name;
        }

        public override string ToString() => Name;
    }
}
