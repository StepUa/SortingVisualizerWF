using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ISorterProject
{
    public interface ISorter
    {
        void Sort(int[] array);
    }

    public abstract class Sorter : ISorter
    {        
        /// <summary>
        /// Sorting speed delay in milliseconds
        /// </summary>
        protected int _sortingSpeedDelay;        
        /// <summary>
        /// Sorting time
        /// </summary>        
        protected Stopwatch _sortingTime = new Stopwatch();
        private object _syncSortingSpeedDelay = new object();

        public abstract void Sort(int[] array);

        public event EventHandler<SortedArrayEventArgs> SortingOver;
        public event EventHandler<ArrayIndexesEventArgs> SwapRaised;

        /// <summary>
        /// Sorting speed delay in milliseconds
        /// </summary>
        public int SortingSpeedDelay
        {
            get
            {
                lock (_syncSortingSpeedDelay)
                {
                    return _sortingSpeedDelay;
                }                
            }
            set
            {
                lock (_syncSortingSpeedDelay)
                {
                    _sortingSpeedDelay = value;
                }
            }
        }
        /// <summary>
        /// Sorting time
        /// </summary>
        public TimeSpan SortingTime
        {
            get
            {
                return _sortingTime.Elapsed;
            }
        }

        protected virtual void OnSortingOverEvent(SortedArrayEventArgs arg)
        {
            EventHandler<SortedArrayEventArgs> handler = SortingOver;

            if (handler != null)
            {
                handler(this, arg);
            }
        }
        protected virtual void OnSwapRaisedEvent(ArrayIndexesEventArgs arg)
        {
            EventHandler<ArrayIndexesEventArgs> handler = SwapRaised;

            if (handler != null)
            {
                handler(this, arg);
            }
        }
    }

    public class SortedArrayEventArgs : EventArgs
    {
        private int[] _sortedArray;

        public int[] SortedArray
        {
            get
            {
                return _sortedArray;
            }
            set
            {
                _sortedArray = value;
            }
        }
    }

    public class ArrayIndexesEventArgs : EventArgs
    {
        private int _firstIndex;
        private int _secondIndex;

        public int FirstIndex
        {
            get
            {
                return _firstIndex;
            }
            set
            {
                _firstIndex = value;
            }
        }
        public int SecondIndex
        {
            get
            {
                return _secondIndex;
            }
            set
            {
                _secondIndex = value;
            }
        }
    }
}
