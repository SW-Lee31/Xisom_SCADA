
namespace XScada_connCs_Test211123
{
    partial class Form_SCADA2
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
            this.scadaBrowser1 = new Xisom.Scada.Browser.ScadaBrowser();
            this.SuspendLayout();
            // 
            // scadaBrowser1
            // 
            this.scadaBrowser1.Location = new System.Drawing.Point(-4, 46);
            this.scadaBrowser1.Name = "scadaBrowser1";
            this.scadaBrowser1.Size = new System.Drawing.Size(799, 405);
            this.scadaBrowser1.TabIndex = 0;
            // 
            // Form_SCADA2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.scadaBrowser1);
            this.Name = "Form_SCADA2";
            this.Text = "Form_SCADA2";
            this.ResumeLayout(false);

        }

        #endregion

        private Xisom.Scada.Browser.ScadaBrowser scadaBrowser1;
    }
}