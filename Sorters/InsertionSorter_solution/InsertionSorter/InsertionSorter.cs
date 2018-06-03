using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using ISorterProject;

namespace InsertionSorterProject
{
    public class InsertionSorter : Sorter
    {
        public override void Sort(int[] array)
        {
            ArrayIndexesEventArgs arrayIndexes = new ArrayIndexesEventArgs();
            SortedArrayEventArgs sortedArrayArg = new SortedArrayEventArgs();

            try
            {
                _sortingTime.Restart();

                for (int counter = 0; counter < array.Length - 1; counter++)
                {
                    int index = counter + 1;

                    while (index > 0)
                    {
                        if (array[index - 1] > array[index])
                        {
                            int temp = array[index - 1];

                            array[index - 1] = array[index];

                            array[index] = temp;

                            arrayIndexes.FirstIndex = index - 1;
                            arrayIndexes.SecondIndex = index;

                            OnSwapRaisedEvent(arrayIndexes);

                            Thread.Sleep(SortingSpeedDelay);
                        }
                        index--;
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
            return "Insertion sorter";
        }
    }
}
