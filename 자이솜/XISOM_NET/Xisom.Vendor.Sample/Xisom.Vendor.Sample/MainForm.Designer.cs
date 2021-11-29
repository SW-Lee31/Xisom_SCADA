namespace Xisom.Vendor.Sample
{
    partial class MainForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tagValTextBox = new System.Windows.Forms.Label();
            this.tagNameTextBox = new System.Windows.Forms.Label();
            this.tagSentButton = new System.Windows.Forms.Button();
            this.tagButton = new System.Windows.Forms.Button();
            this.channelButton = new System.Windows.Forms.Button();
            this.tagSentTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // scadaBrowser1
            // 
            this.scadaBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scadaBrowser1.Location = new System.Drawing.Point(0, 10);
            this.scadaBrowser1.Name = "scadaBrowser1";
            this.scadaBrowser1.Size = new System.Drawing.Size(962, 573);
            this.scadaBrowser1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(2, 10, 2, 0);
            this.panel1.Size = new System.Drawing.Size(966, 701);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.scadaBrowser1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(2, 118);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.panel2.Size = new System.Drawing.Size(962, 583);
            this.panel2.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Black;
            this.groupBox1.Controls.Add(this.tagValTextBox);
            this.groupBox1.Controls.Add(this.tagNameTextBox);
            this.groupBox1.Controls.Add(this.tagSentButton);
            this.groupBox1.Controls.Add(this.tagButton);
            this.groupBox1.Controls.Add(this.channelButton);
            this.groupBox1.Controls.Add(this.tagSentTextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(2, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(962, 108);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tag 정보 ";
            // 
            // tagValTextBox
            // 
            this.tagValTextBox.BackColor = System.Drawing.Color.White;
            this.tagValTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tagValTextBox.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.tagValTextBox.ForeColor = System.Drawing.Color.Red;
            this.tagValTextBox.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tagValTextBox.Location = new System.Drawing.Point(474, 32);
            this.tagValTextBox.Name = "tagValTextBox";
            this.tagValTextBox.Size = new System.Drawing.Size(142, 24);
            this.tagValTextBox.TabIndex = 10;
            this.tagValTextBox.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tagNameTextBox
            // 
            this.tagNameTextBox.BackColor = System.Drawing.Color.White;
            this.tagNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tagNameTextBox.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.tagNameTextBox.ForeColor = System.Drawing.Color.Black;
            this.tagNameTextBox.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tagNameTextBox.Location = new System.Drawing.Point(127, 32);
            this.tagNameTextBox.Name = "tagNameTextBox";
            this.tagNameTextBox.Size = new System.Drawing.Size(185, 24);
            this.tagNameTextBox.TabIndex = 9;
            this.tagNameTextBox.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tagSentButton
            // 
            this.tagSentButton.Font = new System.Drawing.Font("Tahoma", 9F);
            this.tagSentButton.ForeColor = System.Drawing.Color.Black;
            this.tagSentButton.Location = new System.Drawing.Point(656, 64);
            this.tagSentButton.Name = "tagSentButton";
            this.tagSentButton.Size = new System.Drawing.Size(125, 26);
            this.tagSentButton.TabIndex = 8;
            this.tagSentButton.Text = "Write Tag Value";
            this.tagSentButton.UseVisualStyleBackColor = true;
            this.tagSentButton.Click += new System.EventHandler(this.tagSentButton_Click);
            // 
            // tagButton
            // 
            this.tagButton.Font = new System.Drawing.Font("굴림", 9F);
            this.tagButton.ForeColor = System.Drawing.Color.Black;
            this.tagButton.Location = new System.Drawing.Point(656, 29);
            this.tagButton.Name = "tagButton";
            this.tagButton.Size = new System.Drawing.Size(125, 26);
            this.tagButton.TabIndex = 7;
            this.tagButton.Text = "Tag 상태";
            this.tagButton.UseVisualStyleBackColor = true;
            this.tagButton.Click += new System.EventHandler(this.tagButton_Click);
            // 
            // channelButton
            // 
            this.channelButton.ForeColor = System.Drawing.Color.Black;
            this.channelButton.Location = new System.Drawing.Point(797, 29);
            this.channelButton.Name = "channelButton";
            this.channelButton.Size = new System.Drawing.Size(125, 26);
            this.channelButton.TabIndex = 6;
            this.channelButton.Text = "Channel 상태";
            this.channelButton.UseVisualStyleBackColor = true;
            this.channelButton.Click += new System.EventHandler(this.channelButton_Click);
            // 
            // tagSentTextBox
            // 
            this.tagSentTextBox.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tagSentTextBox.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.tagSentTextBox.Location = new System.Drawing.Point(474, 66);
            this.tagSentTextBox.Name = "tagSentTextBox";
            this.tagSentTextBox.Size = new System.Drawing.Size(142, 25);
            this.tagSentTextBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(378, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tag Value";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(378, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tag Value";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(33, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tag Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 701);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.Text = "Sample";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Scada.Browser.ScadaBrowser scadaBrowser1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tagSentTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button tagButton;
        private System.Windows.Forms.Button channelButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button tagSentButton;
        private System.Windows.Forms.Label tagValTextBox;
        private System.Windows.Forms.Label tagNameTextBox;

    }
}

