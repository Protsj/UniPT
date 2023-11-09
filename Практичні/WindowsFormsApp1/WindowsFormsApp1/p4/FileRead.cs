using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.p4
{
    internal class FileRead : IRead
    {
        public void read(string path, PointInCircle p)
        {
            using (StreamReader sr = new StreamReader(path, System.Text.Encoding.Default))
            {
                string lineX = "";
                string lineY = "";
                try
                {
                    if ((lineX = sr.ReadLine()) != null)
                    {
                        string[] xValues = lineX.Split(' ');
                        for (int i = 0; i < xValues.Length; i++)
                            p.x[i] = Convert.ToInt32(xValues[i]);
                        
                    }

                    if ((lineY = sr.ReadLine()) != null)
                    {
                        string[] yValues = lineY.Split(' ');
                        for (int i = 0; i < yValues.Length; i++)
                            p.y[i] = Convert.ToInt32(yValues[i]);
                    }

                    sr.Close();
                }
                catch
                {
                    throw new AccessViolationException("File error!");
                }
            }
        }
    }
}
