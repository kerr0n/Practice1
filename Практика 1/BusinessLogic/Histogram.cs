using System;
using System.Collections.Generic;
using System.Text;
using Model;

namespace BusinessLogic
{
    public class Histogram
    {
        public Dictionary<string, int> specialityHistogram { get; set; } = new Dictionary<string, int>();
        public void CreateDictionary(List<Student> students)
        {
            foreach (var student in students)
            {
                if (specialityHistogram.ContainsKey(student.Speciality))
                {
                    specialityHistogram[student.Speciality]++;
                }
                else
                {
                    specialityHistogram[student.Speciality] = 1;
                }
            }
        }
    }
}
