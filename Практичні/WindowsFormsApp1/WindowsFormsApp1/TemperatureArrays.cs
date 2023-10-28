using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class TemperatureArrays
    {
        float[] a;
        int size = 13;

        public int Size
        {
            get { return size; }
        }

        public float this[int i]
        {
            get
            {
                if (0 <= i && i < size)
                    return a[i];
                return 0;
            }
        }

        public TemperatureArrays()
        {
            Random random = new Random();
            a = new float[size];
            a[0] = random.Next(0, 101) / 10.0f;
            for (int i = 1; i < size; i++)
                a[i] = (float)Math.Round(a[i - 1] - random.Next(0, 21) / 10.0f, 1);
        }

        public TemperatureArrays(float t)
        {
            Random random = new Random();
            a = new float[size];
            a[0] = t;
            for (int i = 1; i < size; i++)
                a[i] = (float)Math.Round(a[i - 1] - random.Next(0, 21) / 10.0f, 1);
        }

        public (int, float) countt()
        {
            for(int i = 0; i < size; i++)
                if (a[i] < 0)
                    return (i, a[i]);
            return (14, 14); //Якщо повертається 0, то від'ємної температури не було
        }
    }
}
