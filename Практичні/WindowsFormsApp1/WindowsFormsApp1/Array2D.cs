using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Array2D
    {
        private int[,] B;
        int xl = 5;
        int yl = 5;

        public int X_length
        {
            get { return xl; }
            set { xl = value; }
        }

        public int Y_length
        {
            get { return yl; }
            set { yl = value; }
        }

        public int this[int i, int j]
        {
            get
            {
                if (0 <= i && i < xl && 0 <= j && j < yl)
                    return B[i, j];
                return 0;
            }
        }
        public Array2D()
        {
            Random random = new Random();
            B = new int[5, 5];
            for (int i = 0; i < xl; i++)
                for (int j = 0; j < yl; j++)
                    B[i, j] = random.Next(-100, 100);
        }

        public Array2D(int al, int bl)
        {
            Random random = new Random();
            xl = al;
            yl = bl;
            B = new int[xl, yl];
            for (int i = 0; i < xl; i++)
                for (int j = 0; j < yl; j++)
                    B[i, j] = random.Next(-100, 100);
        }
        public void FindMaxElement(out int maxElement, out string p)
        {
            maxElement = 0;
            int rowOfMaxElement = 0;
            int colOfMaxElement = 0;

            for (int i = 0; i < xl; i++)
            {
                for (int j = 0; j < yl; j++)
                {
                    if (B[i, j] > maxElement)
                    {
                        maxElement = B[i, j];
                        rowOfMaxElement = i;
                        colOfMaxElement = j;
                    }
                }
            }

            // Визначаємо розташування щодо лівої діагоналі.
            if (rowOfMaxElement < colOfMaxElement)
                p = "над лівою діагоналлю.";
            else if (rowOfMaxElement > colOfMaxElement)
                p = "під лівою діагоналлю.";
            else
                p = "на лівій діагоналі.";
        }
    }
}
