using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Owl
{
    public partial class introduceOwl : Form
    {
        public introduceOwl()
        {
            InitializeComponent();
        }

        private void LeeHeewoongGithub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(@"https://github.com/PlanNoa");
        }

        private void JangHoseungGithub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(@"https://github.com/HoseungJang");
        }
    }
}
