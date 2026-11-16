namespace View
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
            textBoxName = new TextBox();
            textBoxSpeciality = new TextBox();
            textBoxGroup = new TextBox();
            buttonAdd = new Button();
            buttonDelete = new Button();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(51, 37);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(336, 31);
            textBoxName.TabIndex = 0;
            // 
            // textBoxSpeciality
            // 
            textBoxSpeciality.Location = new Point(455, 37);
            textBoxSpeciality.Name = "textBoxSpeciality";
            textBoxSpeciality.Size = new Size(308, 31);
            textBoxSpeciality.TabIndex = 1;
            // 
            // textBoxGroup
            // 
            textBoxGroup.Location = new Point(51, 115);
            textBoxGroup.Name = "textBoxGroup";
            textBoxGroup.Size = new Size(336, 31);
            textBoxGroup.TabIndex = 2;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(43, 166);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(136, 34);
            buttonAdd.TabIndex = 3;
            buttonAdd.Text = "добавить";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(243, 166);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(205, 34);
            buttonDelete.TabIndex = 4;
            buttonDelete.Text = "удалить выбранного";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(43, 223);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(720, 225);
            dataGridView1.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(51, 9);
            label1.Name = "label1";
            label1.Size = new Size(52, 25);
            label1.TabIndex = 6;
            label1.Text = "ФИО";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(455, 9);
            label2.Name = "label2";
            label2.Size = new Size(118, 25);
            label2.TabIndex = 6;
            label2.Text = "направление";
            label2.Click += label1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(51, 87);
            label3.Name = "label3";
            label3.Size = new Size(68, 25);
            label3.TabIndex = 7;
            label3.Text = "группа";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(buttonDelete);
            Controls.Add(buttonAdd);
            Controls.Add(textBoxGroup);
            Controls.Add(textBoxSpeciality);
            Controls.Add(textBoxName);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxName;
        private TextBox textBoxSpeciality;
        private TextBox textBoxGroup;
        private Button buttonAdd;
        private Button buttonDelete;
        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
