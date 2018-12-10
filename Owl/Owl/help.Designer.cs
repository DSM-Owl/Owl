namespace Owl
{
    partial class help
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(help));
            this.helpControl = new System.Windows.Forms.TabControl();
            this.skill = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.caution = new System.Windows.Forms.TabPage();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.helpControl.SuspendLayout();
            this.skill.SuspendLayout();
            this.caution.SuspendLayout();
            this.SuspendLayout();
            // 
            // helpControl
            // 
            this.helpControl.Controls.Add(this.skill);
            this.helpControl.Controls.Add(this.caution);
            this.helpControl.Location = new System.Drawing.Point(10, 12);
            this.helpControl.Name = "helpControl";
            this.helpControl.SelectedIndex = 0;
            this.helpControl.Size = new System.Drawing.Size(460, 429);
            this.helpControl.TabIndex = 0;
            // 
            // skill
            // 
            this.skill.BackColor = System.Drawing.Color.LightGray;
            this.skill.Controls.Add(this.textBox1);
            this.skill.Location = new System.Drawing.Point(4, 25);
            this.skill.Name = "skill";
            this.skill.Padding = new System.Windows.Forms.Padding(3);
            this.skill.Size = new System.Drawing.Size(452, 400);
            this.skill.TabIndex = 0;
            this.skill.Text = "기능";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.LightGray;
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(452, 400);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // caution
            // 
            this.caution.BackColor = System.Drawing.Color.LightGray;
            this.caution.Controls.Add(this.textBox2);
            this.caution.Location = new System.Drawing.Point(4, 25);
            this.caution.Name = "caution";
            this.caution.Padding = new System.Windows.Forms.Padding(3);
            this.caution.Size = new System.Drawing.Size(452, 400);
            this.caution.TabIndex = 1;
            this.caution.Text = "주의";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.LightGray;
            this.textBox2.Location = new System.Drawing.Point(0, 0);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(452, 400);
            this.textBox2.TabIndex = 0;
            this.textBox2.Text = resources.GetString("textBox2.Text");
            // 
            // help
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(482, 453);
            this.Controls.Add(this.helpControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "help";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "도움말";
            this.helpControl.ResumeLayout(false);
            this.skill.ResumeLayout(false);
            this.skill.PerformLayout();
            this.caution.ResumeLayout(false);
            this.caution.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl helpControl;
        private System.Windows.Forms.TabPage skill;
        private System.Windows.Forms.TabPage caution;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}