using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RJCodeAdvance;
using RJCodeAdvance.ControlEmployees;
using System.Windows.Forms;
using RJCodeAdvance.ControlBeverages;

namespace LoginForm
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmLogin());
        }
    }
}
