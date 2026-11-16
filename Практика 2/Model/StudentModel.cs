using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class StudentModel : IModel<Student>
    {
        private List<Student> students = new List<Student>();
        public event DataChangedDelegate DataChanged;
        public void Delete(int index)
        {
            if (index >= 0 && index < students.Count)
            {
                students.RemoveAt(index);
                InvokeDataChanged();
            }
        }
        public void Insert(Student item)
        {
            students.Add(item);
            InvokeDataChanged();
        }
        private void InvokeDataChanged()
        {
            List<List<object>> list = new List<List<object>>();
            for (int i = 0; i < students.Count; i++)
            {
                list.Add(new List<object> { students[i].Name, students[i].Speciality, students[i].Group });
            }
            DataChanged?.Invoke(list);
        }
    }
}
