using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrangChu.VIEW;

namespace TrangChu
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

            FormDangNhap formDangNhap = new FormDangNhap();
            Application.Run(new FormDangNhap());

            //FormGoiMon form = new FormGoiMon();
            //Application.Run(new FormGoiMon());
        }
    }
}
