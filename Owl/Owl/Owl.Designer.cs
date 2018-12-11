namespace Owl
{
    partial class Owl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Owl));
            this.Owltab = new System.Windows.Forms.TabControl();
            this.watchtab = new System.Windows.Forms.TabPage();
            this.stopButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.logtab = new System.Windows.Forms.TabPage();
            this.logList = new System.Windows.Forms.TextBox();
            this.logFileList = new System.Windows.Forms.ListView();
            this.logFileName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.파일ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.종료ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.도움말ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.owl소개ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.도움말ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.Owltab.SuspendLayout();
            this.watchtab.SuspendLayout();
            this.logtab.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Owltab
            // 
            this.Owltab.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Owltab.Controls.Add(this.watchtab);
            this.Owltab.Controls.Add(this.logtab);
            this.Owltab.Location = new System.Drawing.Point(12, 31);
            this.Owltab.Name = "Owltab";
            this.Owltab.SelectedIndex = 0;
            this.Owltab.Size = new System.Drawing.Size(758, 410);
            this.Owltab.TabIndex = 3;
            this.Owltab.SelectedIndexChanged += new System.EventHandler(this.Owltab_SelectedIndexChanged);
            // 
            // watchtab
            // 
            this.watchtab.BackColor = System.Drawing.Color.LightGray;
            this.watchtab.Controls.Add(this.stopButton);
            this.watchtab.Controls.Add(this.startButton);
            this.watchtab.Location = new System.Drawing.Point(4, 25);
            this.watchtab.Name = "watchtab";
            this.watchtab.Padding = new System.Windows.Forms.Padding(3);
            this.watchtab.Size = new System.Drawing.Size(750, 381);
            this.watchtab.TabIndex = 0;
            this.watchtab.Text = "감시";
            // 
            // stopButton
            // 
            this.stopButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.stopButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.stopButton.Image = global::Owl.Properties.Resources.Nowatch;
            this.stopButton.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.stopButton.Location = new System.Drawing.Point(118, 227);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(500, 150);
            this.stopButton.TabIndex = 1;
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // startButton
            // 
            this.startButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.startButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.startButton.Image = global::Owl.Properties.Resources.watch;
            this.startButton.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.startButton.Location = new System.Drawing.Point(118, 13);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(500, 150);
            this.startButton.TabIndex = 0;
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // logtab
            // 
            this.logtab.BackColor = System.Drawing.Color.LightGray;
            this.logtab.Controls.Add(this.logList);
            this.logtab.Controls.Add(this.logFileList);
            this.logtab.Location = new System.Drawing.Point(4, 25);
            this.logtab.Name = "logtab";
            this.logtab.Padding = new System.Windows.Forms.Padding(3);
            this.logtab.Size = new System.Drawing.Size(750, 381);
            this.logtab.TabIndex = 1;
            this.logtab.Text = "로그";
            // 
            // logList
            // 
            this.logList.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.logList.BackColor = System.Drawing.Color.Gainsboro;
            this.logList.Location = new System.Drawing.Point(258, 7);
            this.logList.Multiline = true;
            this.logList.Name = "logList";
            this.logList.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.logList.Size = new System.Drawing.Size(486, 368);
            this.logList.TabIndex = 1;
            // 
            // logFileList
            // 
            this.logFileList.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.logFileList.BackColor = System.Drawing.Color.Gainsboro;
            this.logFileList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.logFileName});
            this.logFileList.GridLines = true;
            this.logFileList.Location = new System.Drawing.Point(7, 7);
            this.logFileList.Name = "logFileList";
            this.logFileList.Size = new System.Drawing.Size(245, 368);
            this.logFileList.TabIndex = 0;
            this.logFileList.UseCompatibleStateImageBehavior = false;
            this.logFileList.View = System.Windows.Forms.View.Details;
            this.logFileList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.logFileList_MouseDoubleClick);
            // 
            // logFileName
            // 
            this.logFileName.Text = "로그파일명";
            this.logFileName.Width = 245;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.파일ToolStripMenuItem,
            this.도움말ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(782, 28);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 파일ToolStripMenuItem
            // 
            this.파일ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.종료ToolStripMenuItem});
            this.파일ToolStripMenuItem.Name = "파일ToolStripMenuItem";
            this.파일ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.파일ToolStripMenuItem.Text = "메뉴";
            // 
            // 종료ToolStripMenuItem
            // 
            this.종료ToolStripMenuItem.Name = "종료ToolStripMenuItem";
            this.종료ToolStripMenuItem.Size = new System.Drawing.Size(114, 26);
            this.종료ToolStripMenuItem.Text = "종료";
            this.종료ToolStripMenuItem.Click += new System.EventHandler(this.종료ToolStripMenuItem_Click);
            // 
            // 도움말ToolStripMenuItem
            // 
            this.도움말ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.owl소개ToolStripMenuItem,
            this.도움말ToolStripMenuItem1});
            this.도움말ToolStripMenuItem.Name = "도움말ToolStripMenuItem";
            this.도움말ToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.도움말ToolStripMenuItem.Text = "도움말";
            // 
            // owl소개ToolStripMenuItem
            // 
            this.owl소개ToolStripMenuItem.Name = "owl소개ToolStripMenuItem";
            this.owl소개ToolStripMenuItem.Size = new System.Drawing.Size(146, 26);
            this.owl소개ToolStripMenuItem.Text = "Owl 소개";
            this.owl소개ToolStripMenuItem.Click += new System.EventHandler(this.Owl소개ToolStripMenuItem_Click);
            // 
            // 도움말ToolStripMenuItem1
            // 
            this.도움말ToolStripMenuItem1.Name = "도움말ToolStripMenuItem1";
            this.도움말ToolStripMenuItem1.Size = new System.Drawing.Size(146, 26);
            this.도움말ToolStripMenuItem1.Text = "도움말";
            this.도움말ToolStripMenuItem1.Click += new System.EventHandler(this.도움말ToolStripMenuItem1_Click);
            // 
            // Owl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(782, 453);
            this.Controls.Add(this.Owltab);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "Owl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Owl";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Owl_FormClosing);
            this.Owltab.ResumeLayout(false);
            this.watchtab.ResumeLayout(false);
            this.logtab.ResumeLayout(false);
            this.logtab.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl Owltab;
        private System.Windows.Forms.TabPage watchtab;
        private System.Windows.Forms.TabPage logtab;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 파일ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 종료ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 도움말ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem owl소개ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 도움말ToolStripMenuItem1;
        private System.Windows.Forms.TextBox logList;
        private System.Windows.Forms.ListView logFileList;
        private System.Windows.Forms.ColumnHeader logFileName;
    }
}

