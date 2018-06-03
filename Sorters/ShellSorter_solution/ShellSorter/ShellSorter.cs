using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ISorterProject;

namespace ShellSorterProject
{
    public class ShellSorter : Sorter
    {
        public override void Sort(int[] array)
        {
            int step = array.Length / 2;
            while (step > 0)
            {
                int i, j;
                for (i = step; i < array.Length; i++)
                {
                    int current = array[i];
                    for (j = i - step; j >= 0 && array[j] > current; j -= step)
                        array[j + step] = array[j];
                    array[j + step] = current;
                }
                step /= 2;
            }

            SortedArrayEventArgs sortedArray = new SortedArrayEventArgs();

            sortedArray.SortedArray = array;

            OnSortingOverEvent(sortedArray);
        }

        public override string ToString()
        {
            return "Shell sort";
        }
    }
}
