using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Xisom.Scada.Model;
using Xisom.Scada.Core;
using Xisom.Scada.Browser;
using Xisom.Scada.WinForm;

namespace XScada_connCs_Test211123
{
    static class Program
    {
        public static DocumentContext documentContext = null;
        public static ID
        /// <summary>
        /// 해당 애플리케이션의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
