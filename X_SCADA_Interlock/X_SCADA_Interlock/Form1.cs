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

namespace X_SCADA_Interlock
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void InitTag()
        {
            try
            {
                if (Program.document == null) return;

                foreach (var item in Program.document.Tags)
                {
                    if (item.IsGroup())
                    {
                        var tags = Program.document.Tags.GetByFullName(item.Name);
                        foreach (var tag in tags.Children)
                        {
                            tag.LiveChanged += tag_LiveChanged;
                        }
                    }
                    else
                    {
                        item.LiveChanged += tag_LiveChanged;
                    }
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
            Debug.WriteLine(string.Format("DateTime:{0} tagName{1} tagValue:{2}",
                DateTime.Now.ToString("yyyy-mm-dd HH:mm:ss.fff"),
                tag.Name,
                tag.Value)
            );
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            if (Program.document == null) return;

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
    }
}
