namespace Owl
{
    partial class startWatch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(startWatch));
            this.checkButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.directoryDropbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // checkButton
            // 
            this.checkButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkButton.Location = new System.Drawing.Point(64, 131);
            this.checkButton.Name = "checkButton";
            this.checkButton.Size = new System.Drawing.Size(200, 40);
            this.checkButton.TabIndex = 0;
            this.checkButton.Text = "확인";
            this.checkButton.UseVisualStyleBackColor = true;
            this.checkButton.Click += new System.EventHandler(this.checkButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cancelButton.Location = new System.Drawing.Point(270, 131);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(200, 40);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "취소";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "↓감시할 폴더를 끌어다 놓으세요↓";
            // 
            // directoryDropbox
            // 
            this.directoryDropbox.AllowDrop = true;
            this.directoryDropbox.Location = new System.Drawing.Point(12, 27);
            this.directoryDropbox.Multiline = true;
            this.directoryDropbox.Name = "directoryDropbox";
            this.directoryDropbox.ReadOnly = true;
            this.directoryDropbox.Size = new System.Drawing.Size(458, 98);
            this.directoryDropbox.TabIndex = 3;
            this.directoryDropbox.DragDrop += new System.Windows.Forms.DragEventHandler(this.DirectoryDropbox_DragDrop);
            this.directoryDropbox.DragEnter += new System.Windows.Forms.DragEventHandler(this.DirectoryDropbox_DragEnter);
            // 
            // startWatch
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(482, 183);
            this.Controls.Add(this.directoryDropbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.checkButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "startWatch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "감시 시작";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button checkButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox directoryDropbox;
    }
}