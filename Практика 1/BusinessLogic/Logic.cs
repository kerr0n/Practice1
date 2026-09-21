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
            new Student("Ирдынеев Анжил", "Программная инженерия", "КИ25-10/1БГ"),
            new Student("Волынов Владислав", "Градостроительство", "ГРБ25-1"),
            new Student("Воробьёв Никита", "Градостроительство", "ГРБ25-1"),
            new Student("Енуленко Олег", "Градостроительство", "ГРБ25-1"),
            new Student("Ходырев Сергей", "Строительство", "ГРБ25-10"),
            new Student("Андреев Александр", "Инноватика", "САФ26-12")
        };

        public void AddStudent(string name, string speciality, string group)
        {
            students.Add(new Student(name, speciality, group));
        }
        public void DeleteStudent(int index)
        {
            if (index >= 0 && index < students.Count)
            {
                students.RemoveAt(index);
            }
        }
        public Histogram CreateHistogram()
        {
            Histogram histogram = new Histogram();
            histogram.CreateDictionary(students);
            return histogram;
        }
    }
}
