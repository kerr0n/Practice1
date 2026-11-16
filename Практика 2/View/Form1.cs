namespace View
{
    public partial class Form1 : Form, IView
    {
        public event AddDataDelegate AddDataEvent;
        public event DeleteDataDelegate DeleteDataEvent;
        public Form1()
        {
            InitializeComponent();

            dataGridView1.ColumnCount = 3;
            dataGridView1.Columns[0].HeaderText = "ФИО";
            dataGridView1.Columns[1].HeaderText = "Специальность";
            dataGridView1.Columns[2].HeaderText = "Группа";

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            AddDataEvent?.Invoke(new object[]
            {
                textBoxName.Text,
                textBoxSpeciality.Text,
                textBoxGroup.Text
            });
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                DeleteDataEvent?.Invoke(
                    dataGridView1.CurrentRow.Index);
            }

        }
        public void RedrawForm(IEnumerable<IEnumerable<object>> data)
        {
            dataGridView1.Rows.Clear();

            foreach (IEnumerable<object> student in data)
            {
                dataGridView1.Rows.Add(student.ToArray());
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
