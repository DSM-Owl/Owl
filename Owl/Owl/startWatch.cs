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
    public partial class startWatch : Form
    {
        public startWatch()
        {
            InitializeComponent();
        }

        private void DirectoryDropbox_DragDrop(object sender, DragEventArgs e)
        {
            directoryDropbox.Clear();
            foreach (var path in (string[])e.Data.GetData(DataFormats.FileDrop))
            {
                directoryDropbox.AppendText(path);
            }
        }

        private void DirectoryDropbox_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            string path = directoryDropbox.Text;

            if (path != "")
            {
                File.WriteAllText(Environment.CurrentDirectory + @"\path.txt", path, Encoding.UTF8);
                Process.Start(Environment.CurrentDirectory + @"\Owl-monitor.exe");
                Close();
            }
            else
            {
                MessageBox.Show("감시할 폴더를 설정하지 않았습니다.\n", "오류");
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}