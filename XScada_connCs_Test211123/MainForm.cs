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
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
        }

        private void InitTag()
        {
            try
            {
                if (Program.document == null)
                {
                    return;
                }

                foreach (var item in Program.document.Tags)
                {
                    item.LiveChanged += tag_LiveChanged;
                }
            }
            catch (Exception exp)
            {
                Trace.WriteLine(exp.GetStackTrace());
                MessageBox.Show(exp.GetStackTrace());
            }
        }

        private void tag_LiveChanged(object sender, EventArgs e)
        {
            IDataTag tag = sender as IDataTag;
            Debug.WriteLine(string.Format("DateTime:{0} tagName:{1} tagValue:{2}",
                DateTime.Now.ToString("g"),
                tag.Name,
                tag.Value)
                );
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            if (Program.document == null)
            {
                return;
            }

            try
            {
                browser.Navigate(Program.document.Pages[0]);
                browser.FitToWindow = true;
            }
            catch (Exception ex)
            {
                Trace.WriteLine(ex.GetStackTrace());
                MessageBox.Show(ex.GetStackTrace());
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form_SCADA2 SCADA_page2 = new Form_SCADA2();
            SCADA_page2.Show();
        }
    }
}
