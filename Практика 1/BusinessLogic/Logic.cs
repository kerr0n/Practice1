using System;
using System.Collections.Generic;
using System.Text;
using Model;

namespace BusinessLogic
{
    public class Logic
    {
        public List<Student> students { get; set; } = new List<Student>();

        public void AddStudent(string name, string speciality, string group)
        {
            students.Add(new Student(name, speciality, group));
        }
    }
}
