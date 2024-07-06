using System;

namespace Methods
{
    internal class BinarySearch
    {
        private int[] array;
        private int target;
        //search params
        public void SearchParams(int[] array, int target)
        {
            if (array == null || array.Length == 0)
            {
                throw new ArgumentException(nameof(array));
            }

            this.array = array;
            this.target = target;
        }

        public int PerformBinarySearch()
        {
            if (array == null || array.Length == 0)
            {
                throw new InvalidOperationException();

            }

            int left = 0;
            int right = array.Length - 1;

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
    }
}
