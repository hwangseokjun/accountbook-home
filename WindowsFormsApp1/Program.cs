using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.DataAccess;
using WindowsFormsApp1.Presenters;
using WindowsFormsApp1.Views;

namespace WindowsFormsApp1
{
    static class Program
    {
        /// <summary>
        /// 해당 애플리케이션의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var form = new Form1();
            var repository = new Repository();
            var presenter = new FormPresenter(form, repository);
            presenter.Initialize();

            Application.Run(form);
        }
    }
}
