using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;

using Xisom.Scada.Model;
using Xisom.Scada.Core;
using Xisom.Scada.WinForm;

namespace Xisom.Vendor.Sample
{
    public partial class TagStatusForm : Form
    {
        private IDocument document = null;
        public IDocument Document
        {
            get { return document; }
            set
            {
                if (this.IsDisposed == true) return;
                if (document == value) return;
                document = value;
            }
        }

        public TagStatusForm()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            tagStatusControl1.Document = this.document;
        }
    }
}
