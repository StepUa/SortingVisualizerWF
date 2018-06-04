using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using ISorterProject;

namespace QuickSorterProject
{
    public class QuickSorter : Sorter
    {
        public override void Sort(int[] array)
        {
            SortedArrayEventArgs sortedArrayArg = new SortedArrayEventArgs();

            try
            {
                _sortingTime.Restart();

                Quicksort(array, 0, array.Length - 1);
            }
            finally
            {
                _sortingTime.Stop();
            }

            sortedArrayArg.SortedArray = array;

            OnSortingOverEvent(sortedArrayArg);
        }

        private void Quicksort(int[] array, int left, int right)
        {
            ArrayIndexesEventArgs arrayIndexes = new ArrayIndexesEventArgs();

            int i = left, j = right;
            int pivot = array[left + (right - left) / 2];

            while (i <= j)
            {
                while (array[i].CompareTo(pivot) < 0)
                {
                    i++;
                }

                while (array[j].CompareTo(pivot) > 0)
                {
                    j--;
                }

                if (i <= j)
                {
                    // Swap
                    int tmp = array[i];
                    array[i] = array[j];
                    array[j] = tmp;

                    arrayIndexes.FirstIndex = i;
                    arrayIndexes.SecondIndex = j;

                    SwapCount++;
                    OnSwapRaisedEvent(arrayIndexes);

                    Thread.Sleep(SortingSpeedDelay);

                    i++;
                    j--;
                }
            }

            if (left < j)
            {
                Quicksort(array, left, j);
            }

            if (i < right)
            {
                Quicksort(array, i, right);
            }
        }

        public override string ToString()
        {
            return "QuickSorter";
        }
    }
}
