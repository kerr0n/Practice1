using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ViewWinForms
{
    public partial class Form2 : Form
    {
        private BusinessLogic.Logic logic;
        public Form2(BusinessLogic.Logic logic)
        {
            InitializeComponent();
            this.logic = logic;
            btnAdd.DialogResult = DialogResult.None;
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = txtFullName.Text.Trim();
            string speciality = txtSpeciality.Text.Trim();
            string group = txtGroup.Text.Trim();

            if (name == "" || speciality == "" || group == "")
            {
                MessageBox.Show("Заполните все поля.");
                return;
            }

            logic.AddStudent(name, speciality, group);
            DialogResult = DialogResult.OK;
        }
    }
}
