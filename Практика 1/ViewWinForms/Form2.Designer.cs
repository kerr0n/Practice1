namespace ViewWinForms
{
    partial class Form2
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblFullName = new Label();
            txtFullName = new TextBox();
            lblGroup = new Label();
            txtGroup = new TextBox();
            lblSpeciality = new Label();
            txtSpeciality = new TextBox();
            btnAdd = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Location = new Point(12, 15);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(34, 15);
            lblFullName.TabIndex = 0;
            lblFullName.Text = "ФИО";
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(12, 33);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(360, 23);
            txtFullName.TabIndex = 1;
            // 
            // lblGroup
            // 
            lblGroup.AutoSize = true;
            lblGroup.Location = new Point(12, 68);
            lblGroup.Name = "lblGroup";
            lblGroup.Size = new Size(46, 15);
            lblGroup.TabIndex = 2;
            lblGroup.Text = "Группа";
            // 
            // txtGroup
            // 
            txtGroup.Location = new Point(12, 86);
            txtGroup.Name = "txtGroup";
            txtGroup.Size = new Size(360, 23);
            txtGroup.TabIndex = 3;
            // 
            // lblSpeciality
            // 
            lblSpeciality.AutoSize = true;
            lblSpeciality.Location = new Point(12, 121);
            lblSpeciality.Name = "lblSpeciality";
            lblSpeciality.Size = new Size(147, 15);
            lblSpeciality.TabIndex = 4;
            lblSpeciality.Text = "Направление подготовки";
            // 
            // txtSpeciality
            // 
            txtSpeciality.Location = new Point(12, 139);
            txtSpeciality.Name = "txtSpeciality";
            txtSpeciality.Size = new Size(360, 23);
            txtSpeciality.TabIndex = 5;
            // 
            // btnAdd
            // 
            btnAdd.DialogResult = DialogResult.OK;
            btnAdd.Location = new Point(216, 181);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "Добавить";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnCancel
            // 
            btnCancel.CausesValidation = false;
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Location = new Point(297, 181);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "Отмена";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // Form2
            // 
            AcceptButton = btnAdd;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(384, 216);
            Controls.Add(lblFullName);
            Controls.Add(txtFullName);
            Controls.Add(lblGroup);
            Controls.Add(txtGroup);
            Controls.Add(lblSpeciality);
            Controls.Add(txtSpeciality);
            Controls.Add(btnAdd);
            Controls.Add(btnCancel);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form2";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Добавление студента";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFullName;
        private TextBox txtFullName;
        private Label lblGroup;
        private TextBox txtGroup;
        private Label lblSpeciality;
        private TextBox txtSpeciality;
        private Button btnAdd;
        private Button btnCancel;
    }
}
