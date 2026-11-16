using System;
using System.Windows.Forms;
using Model;
using View;

namespace Presenter
{
    internal class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            StudentModel model = new StudentModel();
            Form1 view = new Form1();
            StudentPresenter presenter = new StudentPresenter(model, view);
            Application.Run(view);
        }
    }
}
