using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZZZ_MIS_UI
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

            Frm_Login frm = new Frm_Login();
            Application.Run(frm);

            if (frm.DialogResult == DialogResult.OK)
                Application.Run(new Frm_Main());
        }
    }
}
