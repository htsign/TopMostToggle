using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;

namespace MyApp
{
    public class ProcessInfoList : BindingList<ProcessInfo>
    {
        public ProcessInfoList()
        {
            var processes =
                from p in Process.GetProcesses()
                where p.MainWindowHandle != IntPtr.Zero
                let pi = new ProcessInfo(p)
                orderby pi.Name
                select pi;

            AddRange(processes);
        }

        public void AddRange(IEnumerable<ProcessInfo> collection)
            => collection.ToList().ForEach(Add);

        protected override bool SupportsSortingCore => true;
        private PropertyDescriptor prop;
        protected override PropertyDescriptor SortPropertyCore => prop;
        private ListSortDirection direction;
        protected override ListSortDirection SortDirectionCore => direction;
        private bool isSorted;
        protected override bool IsSortedCore => isSorted;

        protected override void ApplySortCore(PropertyDescriptor prop, ListSortDirection direction)
        {
            var items = (List<ProcessInfo>)Items;
            var comparer = new BindingListComparer<ProcessInfo>(prop, direction);
            items.Sort(comparer);
            isSorted = true;

            this.prop = prop;
            this.direction = direction;

            OnListChanged(new ListChangedEventArgs(ListChangedType.Reset, prop));
        }
    }
}
