using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Task5.MVC;
using Task5.Forms;

namespace Task5
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Model formModel = Model.GetModel();
            MainFormView formView = MainFormView.GetMainForm(formModel);
            
            Application.Run(formView);
        }
    }
}
