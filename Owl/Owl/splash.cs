using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Owl
{
    public partial class splash : Form
    {
        private delegate void progressDelegate(int newValue);
        private delegate void closeDelegate();

        public splash()
        {
            InitializeComponent();
        }

        private void splash_Load(object sender, EventArgs e)
        {
            Thread splashThread = new Thread(Fill_loadingBar);
            splashThread.IsBackground = true;
            splashThread.Start();
        }

        private void IncreaseValue(int newValue)
        {
            loadingBar.Value = newValue;
        }

        private void FormClose()
        {
            Close();
        }

        private void Fill_loadingBar()
        {
            for (int i = 0; i <= 100; i++)
            {
                Invoke(new progressDelegate(IncreaseValue), i);
                Thread.Sleep(10);
            }
            Thread.Sleep(1000);
            Invoke(new closeDelegate(FormClose));
        }
    }
}
