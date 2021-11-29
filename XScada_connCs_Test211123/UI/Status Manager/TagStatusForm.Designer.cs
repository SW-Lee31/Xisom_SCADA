
namespace XScada_connCs_Test211123.UI.Status_Manager
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
            this.tagStatusControl = new Xisom.Scada.WinForm.TagStatusControl();
            this.SuspendLayout();
            // 
            // tagStatusControl
            // 
            this.tagStatusControl.Font = new System.Drawing.Font("Tahoma", 9F);
            this.tagStatusControl.Location = new System.Drawing.Point(3, 1);
            this.tagStatusControl.Name = "tagStatusControl";
            this.tagStatusControl.Size = new System.Drawing.Size(513, 449);
            this.tagStatusControl.TabIndex = 0;
            // 
            // TagStatusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 450);
            this.Controls.Add(this.tagStatusControl);
            this.Name = "TagStatusForm";
            this.Text = "TagStatusForm";
            this.ResumeLayout(false);

        }

        #endregion

        private Xisom.Scada.WinForm.TagStatusControl tagStatusControl;
    }
}