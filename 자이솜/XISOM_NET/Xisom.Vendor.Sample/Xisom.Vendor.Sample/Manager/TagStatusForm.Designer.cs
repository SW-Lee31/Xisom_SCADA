namespace Xisom.Vendor.Sample
{
    partial class TagStatusForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tagStatusControl1 = new Xisom.Scada.WinForm.TagStatusControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();

            // 
            // tagStatusControl1
            // 
            this.tagStatusControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tagStatusControl1.Location = new System.Drawing.Point(2, 2);
            this.tagStatusControl1.Name = "tagStatusControl1";
            this.tagStatusControl1.Size = new System.Drawing.Size(730, 305);
            this.tagStatusControl1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tagStatusControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(2);
            this.panel1.Size = new System.Drawing.Size(734, 309);
            this.panel1.TabIndex = 1;
            // 
            // TagStatusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 309);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "TagStatusForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Tag Status";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion


        private Scada.WinForm.TagStatusControl tagStatusControl1;
        private System.Windows.Forms.Panel panel1;

    }
}