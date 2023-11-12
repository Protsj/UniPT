using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.p5
{
    public class Student : IComparable
    {
        string lastName, faculty;
        int course, group;
        int[] appraisals = new int[5];

        public Student(string lastName, string faculty, int course, int group, int[] appraisals)
        {
            if (course < 0 && course > 5)
                throw new ArgumentException("Курс має бути більшим за 0 та меньшим за 5!");
            else if (group < 0 && group > 3)
                throw new ArgumentException("Група має бути від 1 до 3!");
            bool isGood = true;
            foreach (int i in this.appraisals)
                if (i > 12 && i < 2)
                    isGood = false;
            if (!isGood)
                throw new ArgumentException("Оцінка має бути від 2 до 12");
            this.lastName = lastName;
            this.faculty = faculty;
            this.course = course;
            this.group = group;
            this.appraisals = appraisals;
        }

        public Student()
        {
            Random random = new Random();
            this.lastName = "Проценко";
            this.faculty = "ФІТ";
            this.course = random.Next(1, 5);
            this.course = random.Next(1, 3);
            foreach (int i in appraisals)
                this.appraisals[i] = random.Next(1, 13);
        }

        public string LastName 
        { 
            get { return this.lastName; }
            set { this.lastName = value; }
        }

        public string Faculty
        { 
            get { return this.faculty;}
            set { this.faculty = value;}
        }

        public int Course
        { 
            get { return this.course; } 
            set 
            {
                if (value > 0 && value < 5)
                    this.course = value;
                else throw new ArgumentException("Курс має бути більшим за 0 та меньшим за 5!");
            } 
        }

        public int Group
        { 
            get { return this.group; } 
            set 
            {
                if (value > 0 && value < 4)
                    this.group = value;
                else throw new ArgumentException("Група має бути від 1 до 3!");
            }
        }

        public int[] Appraisals
        {
            get { return this.appraisals;}
            set 
            {
                bool isGood = true;
                foreach(int i in this.appraisals)
                    if (i > 12 && i < 2)
                        isGood = false;
                if (isGood)
                    this.appraisals = value;
                else throw new ArgumentException("Оцінка має бути від 2 до 12");
            }
        }
        public int CompareTo(object obj)
        {
            Student student = obj as Student;
            return course.CompareTo(student.course);
        }
    }
}
