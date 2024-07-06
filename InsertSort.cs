using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class InsertSort
    {
      private int[] array;

      public InsertSort(int[] array)
      {
          this.array = array;
          PerformInsertSort();
          Console.WriteLine("Insertion Sort performed");
          Console.WriteLine("Sorted array: ");
         for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
      }


      public void PerformInsertSort()
      {
          for (int i = 1; i < array.Length; i++)
          {
              int key = array[i];
              int j = i - 1;

              while (j >= 0 && array[j] > key)
              {
                  array[j + 1] = array[j];
                  j = j - 1;
              }

              array[j + 1] = key;
          }
      }
    }
}
