using System;
using System.Collections.Generic;
using System.Text;
using Model;

namespace BusinessLogic
{
    public class Logic
    {
        public List<Student> students { get; set; } = new List<Student>
        {
            new Student("Томилов Станислав", "Прикладная информатика", "КИ25-20Б"),
            new Student("Ганеев Иван", "Прикладная информатика", "КИ25-20Б"),
            new Student("Ирдынеев Анжил", "Программная инженерия", "КИ25-10/1БГ")
        };

        public void AddStudent(string name, string speciality, string group)
        {
            students.Add(new Student(name, speciality, group));
        }
        public void DeleteStudent(string name, string speciality, string group, Guid id)
        {
            students.RemoveAll(s => s.Name == name && s.Speciality == speciality && s.Group == group && s.Id == id);
        }
        public List<Student> GetStudents()
        {
            return students;
        }
        public Histogram CreateHistogram()
        {
            Histogram histogram = new Histogram();
            histogram.CreateDictionary(students);
            return histogram;
        }
    }
}
