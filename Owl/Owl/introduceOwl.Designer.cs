namespace Owl
{
    partial class introduceOwl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(introduceOwl));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LeeHeewoongGithub = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.JangHoseungGithub = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::Owl.Properties.Resources.Owl_icon;
            this.pictureBox1.Location = new System.Drawing.Point(97, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(292, 234);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 60F);
            this.label1.Location = new System.Drawing.Point(137, 249);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 100);
            this.label1.TabIndex = 1;
            this.label1.Text = "Owl";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 15F);
            this.label2.Location = new System.Drawing.Point(193, 349);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "버전 1.0";
            // 
            // LeeHeewoongGithub
            // 
            this.LeeHeewoongGithub.AutoSize = true;
            this.LeeHeewoongGithub.Location = new System.Drawing.Point(12, 414);
            this.LeeHeewoongGithub.Name = "LeeHeewoongGithub";
            this.LeeHeewoongGithub.Size = new System.Drawing.Size(189, 15);
            this.LeeHeewoongGithub.TabIndex = 3;
            this.LeeHeewoongGithub.TabStop = true;
            this.LeeHeewoongGithub.Text = "https://github.com/PlanNoa";
            this.LeeHeewoongGithub.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LeeHeewoongGithub_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 399);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "개발자 깃허브 주소";
            // 
            // JangHoseungGithub
            // 
            this.JangHoseungGithub.AutoSize = true;
            this.JangHoseungGithub.Location = new System.Drawing.Point(12, 429);
            this.JangHoseungGithub.Name = "JangHoseungGithub";
            this.JangHoseungGithub.Size = new System.Drawing.Size(223, 15);
            this.JangHoseungGithub.TabIndex = 5;
            this.JangHoseungGithub.TabStop = true;
            this.JangHoseungGithub.Text = "https://github.com/HoseungJang";
            this.JangHoseungGithub.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.JangHoseungGithub_LinkClicked);
            // 
            // introduceOwl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(482, 453);
            this.Controls.Add(this.JangHoseungGithub);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LeeHeewoongGithub);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "introduceOwl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Owl 소개";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel LeeHeewoongGithub;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel JangHoseungGithub;
    }
}