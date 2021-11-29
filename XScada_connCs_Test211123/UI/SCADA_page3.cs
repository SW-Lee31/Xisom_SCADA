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

namespace XScada_connCs_Test211123.UI
{
    public partial class SCADA_page3 : UserControl
    {
        public SCADA_page3()
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
            browser.Navigate(Program.document.Pages[1]);
            browser.FitToWindow = true;
        }
    }
}
