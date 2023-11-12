using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace WindowsFormsApp1.p5
{
    internal class Students
    {
        public List<Student> students = new List<Student>();
        XmlSerializer serializer = new XmlSerializer(typeof(List<Student>));
        public void add(Student student) { students.Add(student); }
        public void remove(Student student) { students.Remove(student); }
        public void sort()
        {
            SortByCourse sbc = new SortByCourse();
            students.Sort(sbc);
        }
        public void writeFile(string fileName)
        {
            FileStream fstream = new FileStream(fileName, FileMode.Create, FileAccess.Write, FileShare.None);   
            serializer.Serialize(fstream, students);
            fstream.Close();
        }
        public void readFile(string fileName) 
        {
            FileStream fstream = new FileStream(fileName, FileMode.Open, FileAccess.Read, FileShare.None);
            students = serializer.Deserialize(fstream) as List<Student>;
            fstream.Close();
        }
    }
}
 