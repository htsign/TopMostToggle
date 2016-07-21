using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Reflection;

namespace MyApp
{
    class BindingListComparer<T> : IComparer<T>
    {
        private PropertyDescriptor prop;
        private ListSortDirection direction;

        public BindingListComparer(PropertyDescriptor prop, ListSortDirection direction)
        {
            this.prop = prop;
            this.direction = direction;
        }

        public int Compare(T a, T b)
        {
            PropertyInfo p = typeof(T).GetProperty(this.prop.Name);

            if (p.PropertyType.GetInterfaces().Contains(typeof(IComparable)))
            {
                var objA = (IComparable)p.GetValue(a, null);
                var objB = (IComparable)p.GetValue(b, null);

                return objA.CompareTo(objB) * ((this.direction == ListSortDirection.Ascending) ? 1 : -1);
            }
            return 0;
        }
    }
}
