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
            dgvStudents.Location = new Point(22, 26);
            dgvStudents.Margin = new Padding(6, 6, 6, 6);
            dgvStudents.Name = "dgvStudents";
            dgvStudents.RowHeadersWidth = 82;
            dgvStudents.Size = new Size(784, 649);
            dgvStudents.TabIndex = 0;
            dgvStudents.CellContentClick += dgvStudents_CellContentClick;
            // 
            // btnAddStudent
            // 
            btnAddStudent.Location = new Point(834, 58);
            btnAddStudent.Margin = new Padding(6, 6, 6, 6);
            btnAddStudent.Name = "btnAddStudent";
            btnAddStudent.Size = new Size(275, 83);
            btnAddStudent.TabIndex = 1;
            btnAddStudent.Text = "добавить студента";
            btnAddStudent.UseVisualStyleBackColor = true;
            btnAddStudent.Click += btnAddStudent_Click;
            // 
            // btnDeleteStudent
            // 
            btnDeleteStudent.Location = new Point(834, 316);
            btnDeleteStudent.Margin = new Padding(6, 6, 6, 6);
            btnDeleteStudent.Name = "btnDeleteStudent";
            btnDeleteStudent.Size = new Size(275, 81);
            btnDeleteStudent.TabIndex = 2;
            btnDeleteStudent.Text = "удалить студента";
            btnDeleteStudent.UseVisualStyleBackColor = true;
            btnDeleteStudent.Click += btnDeleteStudent_Click;
            // 
            // btnShowHistogram
            // 
            btnShowHistogram.Location = new Point(834, 585);
            btnShowHistogram.Margin = new Padding(6, 6, 6, 6);
            btnShowHistogram.Name = "btnShowHistogram";
            btnShowHistogram.Size = new Size(275, 90);
            btnShowHistogram.TabIndex = 3;
            btnShowHistogram.Text = "показать гистограмму";
            btnShowHistogram.UseVisualStyleBackColor = true;
            btnShowHistogram.Click += btnShowHistogram_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1170, 747);
            Controls.Add(btnShowHistogram);
            Controls.Add(btnDeleteStudent);
            Controls.Add(btnAddStudent);
            Controls.Add(dgvStudents);
            Margin = new Padding(6, 6, 6, 6);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
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
