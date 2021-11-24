using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using Xisom.Scada.Model;
using Xisom.Scada.Core;
using Xisom.Scada.Browser;
using System.Diagnostics;

namespace X_SCADA_Interlock
{
    static class Program
    {

        public static DocumentContext documentContext = null;
        public static IDocument document = null;

        /// <summary>
        /// 해당 애플리케이션의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                // ScadaContext 초기화
                ScadaContext.Initalize();

                Program.documentContext = DocumentContext.InitWith(@"C:\Users\User\Desktop\SCADA\X_SCADA_Interlock\monitoring.xix");
                Program.document = Program.documentContext.Document;

                Application.Run(new Form1());
            }
            catch(Exception e)
            {
                Trace.WriteLine(e.GetStackTrace());
            }

            // ScadaContext 종료
            MiscUtils.Dispose(Program.documentContext);
            ScadaContext.Uinitalize();
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
        }
    }
}
