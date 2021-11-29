using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Xisom.Scada.Core;
using Xisom.Scada.Model;

namespace XScada_connCs_Test211123
{
    public partial class SCADA_page2 : UserControl
    {
        public SCADA_page2()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            try
            {
                initBrowser();
            }
            catch (Exception ex)
            {
                Trace.WriteLine(ex.GetStackTrace());
                MessageBox.Show(ex.GetStackTrace());
            }

        }

        void initBrowser()
        {
            if (Program.document == null) return;
            browser.Navigate(Program.document.Pages[5]);
            browser.FitToWindow = true;
        }
    }
}
