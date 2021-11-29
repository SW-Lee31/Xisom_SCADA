namespace Xisom.Vendor.Sample
{
    partial class ChannelStatusForm
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
            this.channelStatusControl1 = new Xisom.Scada.WinForm.ChannelStatusControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();

            // 
            // channelStatusControl1
            // 
            this.channelStatusControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.channelStatusControl1.Location = new System.Drawing.Point(2, 2);
            this.channelStatusControl1.Name = "channelStatusControl1";
            this.channelStatusControl1.Size = new System.Drawing.Size(665, 364);
            this.channelStatusControl1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.channelStatusControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(2);
            this.panel1.Size = new System.Drawing.Size(669, 368);
            this.panel1.TabIndex = 1;
            // 
            // ChannelStatusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 368);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "ChannelStatusForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Channel Status";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion


        private Scada.WinForm.ChannelStatusControl channelStatusControl1;
        private System.Windows.Forms.Panel panel1;


    }
}