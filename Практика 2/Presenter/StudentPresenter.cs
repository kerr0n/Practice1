
using System;
using System.Collections.Generic;
using System.Linq;
using Model;
using View;

namespace Presenter
{
    public class StudentPresenter
    {
        private IModel<Student> model;
        private IView view;

        public StudentPresenter(IModel<Student> model, IView view)
        {
            this.model = model;
            this.view = view;

            view.AddDataEvent += OnAddData;
            view.DeleteDataEvent += OnDeleteData;
            model.DataChanged += OnDataChanged;
        }

        private void OnAddData(IEnumerable<object> data)
        {
            object[] values = data.ToArray();

            Student student = new Student
            {
                Name = (string)values[0],
                Speciality = (string)values[1],
                Group = (string)values[2]
            };

            model.Insert(student);
        }

        private void OnDeleteData(int index)
        {
            model.Delete(index);
        }

        private void OnDataChanged(IEnumerable<IEnumerable<object>> data)
        {
            view.RedrawForm(data);
        }
    }
}
