using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Diagnostics;

using Xisom.Scada.Model;
using Xisom.Scada.Core;
using Xisom.Scada.Browser;

namespace Xisom.Vendor.Sample
{
	internal static class Program
	{
		public static DocumentContext documentContext = null;
		public static IDocument document = null;

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() {

            try
            {

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                // log4net 설정
                LoggerManager.ConfigureLog4Net("log4net.config");

                // ScadaContext 초기화
                ScadaContext.Initalize();

                Program.documentContext = DocumentContext.InitWith("xisom.xix");
                Program.document = Program.documentContext.Document;

                // start http server
                //StartHttpServer();

                // Main
                Application.Run(new MainForm());

            }
            catch (Exception e)
            {
                Trace.WriteLine(e.GetStackTrace());
                MessageBox.Show(e.GetStackTrace());
            }
            finally
            {
                // stop http server
                //StopHttpServer();

                // ScadaContext 종료
                MiscUtils.Dispose(Program.documentContext);
                ScadaContext.Uinitalize();
            }
		}

		/// <summary>
		/// HttpServer 시작
		/// </summary>
		private static void StartHttpServer() {
			var httpService = GetHttpService();
			if (httpService == null) return;

			try {

				httpService.Start();

			} catch (Exception e) {
				Debug.WriteLine(e.Message);
				Debug.WriteLine(e.StackTrace);

				StopHttpServer();
				MessageBox.Show("Failed to start the http server.");
			}
		}

		/// <summary>
		/// HttpServer 중지
		/// </summary>
		private static void StopHttpServer() {
			var httpService = GetHttpService();
			if (httpService == null) return;

			httpService.Stop();
		}

		/// <summary>
		/// IHttpService를 가져온다.
		/// </summary>
		private static IHttpService GetHttpService() {
			var context = Program.documentContext;
			if (context == null) return null;

			return context.GetService(typeof(IHttpService)) as IHttpService;
		}

	}

}

