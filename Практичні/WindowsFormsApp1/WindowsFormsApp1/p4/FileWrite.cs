using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.p4
{
    internal class FileWrite : IWrite
    {
        public void write(string path, PointInCircle p)
        {
            using (StreamWriter sw = new StreamWriter(path, false, System.Text.Encoding.Default))
            {
                if (p.pointsAreInCircle())
                    sw.WriteLine("Всі точки знаходяться в колі! :)");
                else
                    sw.WriteLine("Не всі точки знаходяться в колі! :/");
                sw.Close();
            }
        }
    }
}
