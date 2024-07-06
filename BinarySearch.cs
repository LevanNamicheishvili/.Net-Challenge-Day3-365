using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class BinarySearch
    {
        private int[] array;
        private int target;
        private int resultIndex;

        public BinarySearch(int[] array, int target)
        {
            this.array = array;
            this.target = target;
            this.resultIndex = PerformBinarySearch(0, array.Length - 1);
        }

        private int PerformBinarySearch(int left, int right)
        {
            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (array[mid] == target)
                {
                    return mid;

                }

                if (array[mid] < target)
                {

                    left = mid + 1;
                }

                else
                {

                    right = mid - 1;
                }
            }

            return -1;
        }

        public int GetResultIndex()
        {
            return resultIndex;
        }
    }
}