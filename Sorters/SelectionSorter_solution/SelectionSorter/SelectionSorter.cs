using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using ISorterProject;

namespace SelectionSorterProject
{
    public class SelectionSorter : Sorter
    {
        public override void Sort(int[] array)
        {
            SortedArrayEventArgs sortedArrayArg = new SortedArrayEventArgs();
            ArrayIndexesEventArgs arrayIndexes = new ArrayIndexesEventArgs();

            int tmp;
            int smallestIndex;

            try
            {
                _sortingTime.Restart();

                for (int index = 0; index < array.Length - 1; index++)
                {
                    smallestIndex = index;

                    for (int minIndex = index + 1; minIndex < array.Length; minIndex++)
                    {
                        if (array[minIndex] < array[smallestIndex])
                        {
                            smallestIndex = minIndex;
                        }
                    }

                    tmp = array[smallestIndex];
                    array[smallestIndex] = array[index];
                    array[index] = tmp;

                    arrayIndexes.FirstIndex = smallestIndex;
                    arrayIndexes.SecondIndex = index;

                    OnSwapRaisedEvent(arrayIndexes);

                    Thread.Sleep(SortingSpeedDelay);
                }                
            }
            finally
            {
                _sortingTime.Stop();
            }

            sortedArrayArg.SortedArray = array;

            OnSortingOverEvent(sortedArrayArg);
        }

        public override string ToString()
        {
            return "Selection sorter";
        }
    }
}
