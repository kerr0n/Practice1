using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class Student
    {
        public string Name { get; set; }
        public string Speciality { get; set; }
        public string Group { get; set; }
        public Student(string name, string speciality, string group)
        {
            Name = name;
            Speciality = speciality;
            Group = group;
        }
        public override string ToString()
        {
            return $"Имя: {Name}, Специальность: {Speciality}, Группа: {Group}";
        }
    }
}
