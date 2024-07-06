using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Methods
{
    internal class ArrEach<T>
    {
        private T[] array;
        private Action<T> action;

        public ArrEach(int[] array, Action<int> action)
        {
            this.array = Array.ConvertAll(array, item => (T)Convert.ChangeType(item, typeof(T)));
            this.action = item => action((int)(object)item);
            PerformArrEach();
        }

        public ArrEach(string[] array, Action<string> action)
        {
            this.array = Array.ConvertAll(array, item => (T)Convert.ChangeType(item, typeof(T)));
            this.action = item => action((string)(object)item);
            PerformArrEach();
        }

        private void PerformArrEach()
        {
            foreach (var item in array)
            {
                action(item);
            }
        }
    }
}
