using BusinessLogic;
using System.Drawing.Printing;
namespace ViewWinForms
{
    public partial class Form1 : Form
    {
        private BusinessLogic.Logic logic = BusinessLogic.Logic.Create();
        public Form1()
        {

            InitializeComponent();
            RefreshStudents();
        }


        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            var form = new Form2(logic);
            if (form.ShowDialog(this) == DialogResult.OK)
            {
                RefreshStudents();
            }
        }

        private void btnDeleteStudent_Click(object sender, EventArgs e)
        {
            if (dgvStudents.CurrentRow?.DataBoundItem is not Model.Student student)
            {
                MessageBox.Show("Выберите студента.");
                return;
            }

            try
            {
                logic.DeleteStudent(student.Id);
                RefreshStudents();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Ошибка");
            }
        }

        private void dgvStudents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnShowHistogram_Click(object sender, EventArgs e)
        {
            var histogram = logic.CreateHistogram().GetHistogram();

            using var form = new Form3(histogram);
            form.ShowDialog(this);
        }

        private void RefreshStudents()
        {
            dgvStudents.DataSource = null;
            dgvStudents.DataSource = logic.GetStudents();
        }
    }
}
