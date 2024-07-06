using Methods;

namespace Methods
{
    class Program
    {
    
        static void Main(string[] args)
        {
           //Matrix
           Matrix matrix = new Matrix(3, 3, 3);
           matrix.PrintMatrix();


          //BinarySearch
          int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
          int target = 5;
          BinarySearch binarySearch = new BinarySearch(array, target);
          int resultIndex = binarySearch.GetResultIndex();
          System.Console.WriteLine("index at {0}", resultIndex);
          

          //InsertionSort
          int[] array2 = { 12, 11, 13, 5, 6 };
          InsertSort insertSort = new InsertSort(array2);
          
          Console.WriteLine("Foreach meth");

          //ForEach
          int[] array3 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
          string [] stringArr = {"a", "b", "c", "d", "e"};
          ArrEach<int> arrEach = new ArrEach<int>(array3, item =>
          {
              item *= 2;
              System.Console.WriteLine(item);
          }
          );
          

          
          

        }
    }
}
