using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ISorterProject;

namespace Task5.Tools
{
    class ThreadParameters
    {
        private int[] _array;
        private ISorterProject.Sorter _sortMethod;

        public ThreadParameters(int[] array, ISorterProject.Sorter sortMethod)
        {
            _array = new int[array.Length];

            Array.Copy(array, _array, array.Length);

            _sortMethod = sortMethod;
        }

        public int[] ArrayForSorting
        {
            get
            {
                return _array;
            }

            set
            {
                if (value != null)
                {
                    _array = new int[value.Length];

                    Array.Copy(value, _array, value.Length);
                }
                else
                {
                    _array = value;
                }
            }
        }
        public ISorterProject.Sorter SortMethod
        {
            get
            {
                return _sortMethod;
            }

            set
            {
                _sortMethod = value;
            }
        }
    }
}
