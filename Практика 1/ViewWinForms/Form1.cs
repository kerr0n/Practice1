using BusinessLogic;
using System.Drawing.Printing;
namespace ViewWinForms
{
    public partial class Form1 : Form
    {
        private BusinessLogic.Logic logic = new BusinessLogic.Logic();
        public Form1()
        {

            InitializeComponent();
            dgvStudents.DataSource = logic.students;
        }


        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            var form = new Form2(logic);
            if (form.ShowDialog(this) == DialogResult.OK)
            {
                dgvStudents.DataSource = null;
                dgvStudents.DataSource = logic.students;
            }
        }

        private void btnDeleteStudent_Click(object sender, EventArgs e)
        {
            if (dgvStudents.CurrentRow == null)
            {
                MessageBox.Show("Выберите студента.");
                return;
            }

            int index = dgvStudents.CurrentRow.Index;
            logic.DeleteStudent(index);

            dgvStudents.DataSource = null;
            dgvStudents.DataSource = logic.students;
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
    }
}
