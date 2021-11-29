using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Xisom.Scada.Model;

namespace XScada_connCs_Test211123.UI.Status_Manager
{
    public partial class ChannelStatusForm : Form
    {
        IDocument document = null;

        public IDocument Document
        {
            get
            {
                return document;
            }
            set
            {
                if (this.IsDisposed == true)
                {
                    return;
                }
                if (document == value)
                {
                    return;
                }
                document = value;
            }
        }
        public ChannelStatusForm()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            channelStatusControl1.Document = this.document;
        }
    }
}
