using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Matrix
    {

        private int Rows;
        private int Cols;
        private int Value;
        private int[,] matrix;


       
        public Matrix(int rows, int cols , int value)
        {
             Console.WriteLine("Matrix created");
             this.Rows = rows;
             this.Cols = cols;
             this.Value = value;
             this.matrix = new int[rows, cols];


                
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    this.matrix[i, j] = Value;
                }
            }
        }

        public void PrintMatrix()
        {
            for (int i = 0; i < this.Rows; i++)
            {
                for (int j = 0; j < this.Cols; j++)
                {
                    Console.Write(this.matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

    }
}
