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
using XScada_connCs_Test211123.UI;
using XScada_connCs_Test211123.UI.Status_Manager;

namespace XScada_connCs_Test211123
{
    public partial class MainForm : Form
    {
        protected delegate void BindDelegate(IDataTag tag);
        SCADA_page2 home = new SCADA_page2();
        SCADA_page3 page3 = new SCADA_page3();

        const string UC_NAME_PAGE2 = "SCADA_page2";
        const string UC_NAME_PAGE3 = "SCADA_page3";
        public MainForm()
        {
            InitializeComponent();
            controllView(home, UC_NAME_PAGE2);

            try
            {
                InitTag();
            } catch (Exception exp)
            {
                Trace.WriteLine(exp.GetStackTrace());
                MessageBox.Show(exp.GetStackTrace());
            }
        }
        public void controllView(UserControl uc, string viewName)
        {
            Main_panel.Controls.Clear();
            if (!Main_panel.Controls.ContainsKey(viewName))
            {
                uc.Dock = DockStyle.Fill;
                Main_panel.Controls.Add(uc);
            }
            Main_panel.Controls[viewName].BringToFront();
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
                    if (item.IsGroup())
                    {
                        if (item.Name.ToUpper().StartsWith("_SYSTEM")) continue;
                        if (item.Name.ToUpper().StartsWith("_DEVICES")) continue;
                        if (item.Name.ToUpper().StartsWith("_ALARMS")) continue;
                        if (item.Name.ToUpper().StartsWith("CMD")) continue;

                        var tags = Program.document.Tags.GetByFullName(item.Name);
                        
                        foreach(var tag in tags.Children)
                        {
                            if (tag.IsGroup())
                            {
                                continue;
                            }

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
            Debug.WriteLine(string.Format("DateTime:{0} tagName:{1} tagValue:{2}",
                DateTime.Now.ToString("g"),
                tag.Name,
                tag.Value)
                );

            BindData(tag);
        }

        void BindData(IDataTag tag)
        {
            if (InvokeRequired)
            {
                BindDelegate pDelegate = new BindDelegate(BindData);
                BeginInvoke(pDelegate, tag);
            }
            else
            {
                try
                {
                    if (tag == null) return;

                    tagNameTextBox.Text = tag.FullName;
                    tagValTextBox.Text = tag.Value.ToString();
                }
                catch (Exception exp)
                {
                    Debug.WriteLine(exp.GetStackTrace());
                }
            }
        }

        // 태그 상태 표시
        private void tagButton_Click_1(object sender, EventArgs e)
        {
            if (GetForm(typeof(TagStatusForm)) != null) return;

            TagStatusForm form = new TagStatusForm();
            form.Document = Program.document;
            form.Show(this);
        }

        Form GetForm(Type type)
        {
            foreach (Form f in Application.OpenForms)
            {
                if (f.IsDisposed == false && f.GetType() == type)
                {
                    return f;
                }
            }
            return null;
        }

        private void channelButton_Click(object sender, EventArgs e)
        {
            if (GetForm(typeof(ChannelStatusForm)) != null) return;

            ChannelStatusForm form = new ChannelStatusForm();
            form.Document = Program.document;
            form.Show(this);
        }

        private void page1_Click(object sender, EventArgs e)
        {
            controllView(home, UC_NAME_PAGE2);
        }

        private void page2_Click(object sender, EventArgs e)
        {
            controllView(page3, UC_NAME_PAGE3);
        }
    }
}
