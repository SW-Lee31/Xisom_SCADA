using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using Xisom.Scada.Model;
using Xisom.Scada.Core;
using Xisom.Scada.Browser;


namespace XScada_connCs_Test211123
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
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            

            try
            {
                ScadaContext.Initalize();

                Program.documentContext = DocumentContext.InitWith(@"C:\Users\User\Desktop\SCADA\XScada_connCs_Test211123\test211122.xix");
                Program.document = Program.documentContext.Document;
                Application.Run(new MainForm());

            }
            catch (Exception e)
            {
                Console.WriteLine(e.GetStackTrace());
            }

            MiscUtils.Dispose(Program.documentContext);
            ScadaContext.Uinitalize();
        }

    }


}
