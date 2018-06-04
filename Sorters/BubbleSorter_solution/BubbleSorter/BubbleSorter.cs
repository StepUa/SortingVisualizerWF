using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ISorterProject;
using System.Threading;

namespace BubbleSorterProject
{
    public class BubbleSorter : Sorter
    {
        // with each iteration j moves a maximum or minimum element (depending on the sign > or < at if) to the end of the array
        public override void Sort(int[] array)
        {
            SortedArrayEventArgs sortedArrayArg = new SortedArrayEventArgs();
            ArrayIndexesEventArgs arrayIndexes = new ArrayIndexesEventArgs();

            bool wasSwapped = true; // nothing has changed, which means that the array is already sorted

            try
            {                
                _sortingTime.Restart();

                for (int i = 1; (i <= array.Length) && wasSwapped; i++)
                {
                    wasSwapped = false;
                    for (int j = 0; j < array.Length - i; j++)
                    {
                        if (array[j] > array[j + 1])
                        {
                            int tmp = array[j];
                            array[j] = array[j + 1];
                            array[j + 1] = tmp;
                            wasSwapped = true;

                            arrayIndexes.FirstIndex = j;
                            arrayIndexes.SecondIndex = j + 1;

                            SwapCount++;
                            OnSwapRaisedEvent(arrayIndexes);

                            Thread.Sleep(SortingSpeedDelay);
                        }
                    }
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
            return "Bubble sorter";
        }
    }
}
