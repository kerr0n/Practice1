using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ViewWinForms
{
    public partial class Form3 : Form
    {
        public Form3(Dictionary<string, int> histogram)
        {
            InitializeComponent();

            Text = "Гистограмма направлений";
            ClientSize = new Size(900, 550);
            AutoScroll = true;

            int y = 40;

            foreach (var entry in histogram)
            {
                Label lblSpeciality = new Label();
                lblSpeciality.Text = entry.Key;
                lblSpeciality.Location = new Point(15, y);
                lblSpeciality.Size = new Size(400, 40);

                ProgressBar progressBar = new ProgressBar();
                progressBar.Location = new Point(420, y);
                progressBar.Size = new Size(290, 23);
                progressBar.Minimum = 0;
                progressBar.Maximum = 100;
                progressBar.Value = entry.Value;

                Label lblPercent = new Label();
                lblPercent.Text = $"{entry.Value}%";
                lblPercent.Location = new Point(720, y);
                lblPercent.Size = new Size(50, 40);

                Controls.Add(lblSpeciality);
                Controls.Add(progressBar);
                Controls.Add(lblPercent);

                y += 80;
            }
        }
    }
}