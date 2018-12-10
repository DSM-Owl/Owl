using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace Owl
{
    public partial class Owl : Form
    {
        public Owl()
        {
            InitializeComponent();
        }

        private void GithubLink1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(@"https://github.com/HoseungJang");
        }

        private void GithubLink2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(@"https://github.com/PlanNoa");
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            startWatch setPathForm = new startWatch();
            setPathForm.ShowDialog();
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            Process[] checkFILEMON = Process.GetProcessesByName("Owl-monitor");

            if (checkFILEMON.Length > 0)
            {
                foreach (var process in checkFILEMON)
                {
                    process.Kill();
                }
                MessageBox.Show("감시를 종료했습니다.", "감시 멈춤");
            }
            else
            {
                MessageBox.Show("감시가 시작되지 않았습니다.", "오류");
            }
        }

        private void 종료ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Owl_FormClosing(object sender, FormClosingEventArgs e)
        {
            Process[] checkFILEMON = Process.GetProcessesByName("Owl-monitor");

            if(checkFILEMON.Length > 0)
            {
                foreach (var process in checkFILEMON)
                {
                    process.Kill();
                }
            }
        }

        private void Owl소개ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            introduceOwl introduceForm = new introduceOwl();
            introduceForm.ShowDialog();
        }

        private void 도움말ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            help helpForm = new help();
            helpForm.ShowDialog();
        }

        private void Owltab_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(Owltab.SelectedIndex == 1)
            {
                Process[] checkFILEMON = Process.GetProcessesByName("Owl-monitor");

                if (checkFILEMON.Length > 0)
                {
                    Owltab.SelectedIndex = 0;
                    MessageBox.Show("감시가 종료되지 않았습니다.", "오류");
                }
                else
                {
                    while(logFileList.Items.Count > 0)
                    {
                        logFileList.Items[0].Remove();
                    }

                    if(Directory.Exists(Environment.CurrentDirectory + @"\log"))
                    {
                        DirectoryInfo log = new DirectoryInfo(Environment.CurrentDirectory + @"\log");
                        foreach (var item in log.GetFiles())
                        {
                            logFileList.Items.Add(item.Name);
                        }
                    }
                }
            }
        }

        private void logFileList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            logList.Clear();
            if(logFileList.SelectedItems.Count == 1)
            {
                ListView.SelectedListViewItemCollection items = logFileList.SelectedItems;
                string fileName = items[0].Text;

                logList.AppendText(File.ReadAllText(Environment.CurrentDirectory + @"\log\" + fileName, Encoding.UTF8));
            }
        }
    }
}