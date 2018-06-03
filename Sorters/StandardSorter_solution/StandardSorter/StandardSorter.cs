using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ISorterProject;

namespace StandardSorterProject
{
    public class StandardSorter : Sorter
    {
        public override void Sort(int[] array)
        {
            Array.Sort(array);

            SortedArrayEventArgs sortedArray = new SortedArrayEventArgs();

            sortedArray.SortedArray = array;

            OnSortingOverEvent(sortedArray);
        }

        public override string ToString()
        {
            return "Standard sort";
        }
    }
}
