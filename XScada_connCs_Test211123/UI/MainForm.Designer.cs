
namespace XScada_connCs_Test211123
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.Main_panel = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tagButton = new System.Windows.Forms.Button();
            this.channelButton = new System.Windows.Forms.Button();
            this.tagSentButton = new System.Windows.Forms.Button();
            this.tagValTextBox = new System.Windows.Forms.Label();
            this.tagSentTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tagNameTextBox = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.page1 = new System.Windows.Forms.Button();
            this.page2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Main_panel
            // 
            this.Main_panel.Location = new System.Drawing.Point(0, 136);
            this.Main_panel.Name = "Main_panel";
            this.Main_panel.Size = new System.Drawing.Size(794, 505);
            this.Main_panel.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Gray;
            this.groupBox1.Controls.Add(this.tagButton);
            this.groupBox1.Controls.Add(this.channelButton);
            this.groupBox1.Controls.Add(this.tagSentButton);
            this.groupBox1.Controls.Add(this.tagValTextBox);
            this.groupBox1.Controls.Add(this.tagSentTextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tagNameTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(0, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(794, 99);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tag Info";
            // 
            // tagButton
            // 
            this.tagButton.Font = new System.Drawing.Font("굴림", 9F);
            this.tagButton.ForeColor = System.Drawing.Color.Black;
            this.tagButton.Location = new System.Drawing.Point(663, 20);
            this.tagButton.Name = "tagButton";
            this.tagButton.Size = new System.Drawing.Size(125, 26);
            this.tagButton.TabIndex = 18;
            this.tagButton.Text = "Tag Status";
            this.tagButton.UseVisualStyleBackColor = true;
            this.tagButton.Click += new System.EventHandler(this.tagButton_Click_1);
            // 
            // channelButton
            // 
            this.channelButton.ForeColor = System.Drawing.Color.Black;
            this.channelButton.Location = new System.Drawing.Point(663, 57);
            this.channelButton.Name = "channelButton";
            this.channelButton.Size = new System.Drawing.Size(125, 26);
            this.channelButton.TabIndex = 17;
            this.channelButton.Text = "Channel Status";
            this.channelButton.UseVisualStyleBackColor = true;
            this.channelButton.Click += new System.EventHandler(this.channelButton_Click);
            // 
            // tagSentButton
            // 
            this.tagSentButton.Font = new System.Drawing.Font("Tahoma", 9F);
            this.tagSentButton.ForeColor = System.Drawing.Color.Black;
            this.tagSentButton.Location = new System.Drawing.Point(523, 24);
            this.tagSentButton.Name = "tagSentButton";
            this.tagSentButton.Size = new System.Drawing.Size(94, 58);
            this.tagSentButton.TabIndex = 16;
            this.tagSentButton.Text = "Write Tag Value";
            this.tagSentButton.UseVisualStyleBackColor = true;
            // 
            // tagValTextBox
            // 
            this.tagValTextBox.BackColor = System.Drawing.Color.White;
            this.tagValTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tagValTextBox.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.tagValTextBox.ForeColor = System.Drawing.Color.Red;
            this.tagValTextBox.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tagValTextBox.Location = new System.Drawing.Point(375, 23);
            this.tagValTextBox.Name = "tagValTextBox";
            this.tagValTextBox.Size = new System.Drawing.Size(142, 24);
            this.tagValTextBox.TabIndex = 15;
            this.tagValTextBox.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tagSentTextBox
            // 
            this.tagSentTextBox.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tagSentTextBox.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.tagSentTextBox.Location = new System.Drawing.Point(375, 57);
            this.tagSentTextBox.Name = "tagSentTextBox";
            this.tagSentTextBox.Size = new System.Drawing.Size(142, 25);
            this.tagSentTextBox.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(279, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 23);
            this.label3.TabIndex = 13;
            this.label3.Text = "Set Value";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(279, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 23);
            this.label2.TabIndex = 12;
            this.label2.Text = "Current Value";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tagNameTextBox
            // 
            this.tagNameTextBox.BackColor = System.Drawing.Color.White;
            this.tagNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tagNameTextBox.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.tagNameTextBox.ForeColor = System.Drawing.Color.Black;
            this.tagNameTextBox.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tagNameTextBox.Location = new System.Drawing.Point(82, 42);
            this.tagNameTextBox.Name = "tagNameTextBox";
            this.tagNameTextBox.Size = new System.Drawing.Size(156, 24);
            this.tagNameTextBox.TabIndex = 11;
            this.tagNameTextBox.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 23);
            this.label1.TabIndex = 10;
            this.label1.Text = "Tag Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.page1);
            this.panel1.Controls.Add(this.page2);
            this.panel1.Location = new System.Drawing.Point(0, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(794, 38);
            this.panel1.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Left;
            this.button1.Location = new System.Drawing.Point(260, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 38);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // page1
            // 
            this.page1.Dock = System.Windows.Forms.DockStyle.Left;
            this.page1.Location = new System.Drawing.Point(130, 0);
            this.page1.Name = "page1";
            this.page1.Size = new System.Drawing.Size(130, 38);
            this.page1.TabIndex = 1;
            this.page1.Text = "home";
            this.page1.UseVisualStyleBackColor = true;
            this.page1.Click += new System.EventHandler(this.page1_Click);
            // 
            // page2
            // 
            this.page2.Dock = System.Windows.Forms.DockStyle.Left;
            this.page2.Location = new System.Drawing.Point(0, 0);
            this.page2.Name = "page2";
            this.page2.Size = new System.Drawing.Size(130, 38);
            this.page2.TabIndex = 0;
            this.page2.Text = "page2";
            this.page2.UseVisualStyleBackColor = true;
            this.page2.Click += new System.EventHandler(this.page2_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 643);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Main_panel);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel Main_panel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button tagButton;
        private System.Windows.Forms.Button channelButton;
        private System.Windows.Forms.Button tagSentButton;
        private System.Windows.Forms.Label tagValTextBox;
        private System.Windows.Forms.TextBox tagSentTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label tagNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button page1;
        private System.Windows.Forms.Button page2;
    }
}

