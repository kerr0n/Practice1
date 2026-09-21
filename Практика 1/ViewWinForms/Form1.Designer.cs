namespace ViewWinForms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvStudents = new DataGridView();
            btnAddStudent = new Button();
            btnDeleteStudent = new Button();
            btnShowHistogram = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvStudents).BeginInit();
            SuspendLayout();
            // 
            // dgvStudents
            // 
            dgvStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudents.Location = new Point(12, 12);
            dgvStudents.Name = "dgvStudents";
            dgvStudents.Size = new Size(422, 304);
            dgvStudents.TabIndex = 0;
            dgvStudents.CellContentClick += dgvStudents_CellContentClick;
            // 
            // btnAddStudent
            // 
            btnAddStudent.Location = new Point(449, 27);
            btnAddStudent.Name = "btnAddStudent";
            btnAddStudent.Size = new Size(148, 39);
            btnAddStudent.TabIndex = 1;
            btnAddStudent.Text = "добавить студента";
            btnAddStudent.UseVisualStyleBackColor = true;
            btnAddStudent.Click += btnAddStudent_Click;
            // 
            // btnDeleteStudent
            // 
            btnDeleteStudent.Location = new Point(449, 148);
            btnDeleteStudent.Name = "btnDeleteStudent";
            btnDeleteStudent.Size = new Size(148, 38);
            btnDeleteStudent.TabIndex = 2;
            btnDeleteStudent.Text = "удалить студента";
            btnDeleteStudent.UseVisualStyleBackColor = true;
            btnDeleteStudent.Click += btnDeleteStudent_Click;
            // 
            // btnShowHistogram
            // 
            btnShowHistogram.Location = new Point(449, 274);
            btnShowHistogram.Name = "btnShowHistogram";
            btnShowHistogram.Size = new Size(148, 42);
            btnShowHistogram.TabIndex = 3;
            btnShowHistogram.Text = "показать гистограмму";
            btnShowHistogram.UseVisualStyleBackColor = true;
            btnShowHistogram.Click += btnShowHistogram_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(630, 350);
            Controls.Add(btnShowHistogram);
            Controls.Add(btnDeleteStudent);
            Controls.Add(btnAddStudent);
            Controls.Add(dgvStudents);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvStudents).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvStudents;
        private Button btnAddStudent;
        private Button btnDeleteStudent;
        private Button btnShowHistogram;
    }
}
