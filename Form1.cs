using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyBrowser_Mendozalz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void picBack_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void picGo_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(txtUrl.Text);

        }

        private void picFoward_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void picStop_Click(object sender, EventArgs e)
        {
            webBrowser1.Stop();
        }

        private void picHome_Click(object sender, EventArgs e)
        {
            webBrowser1.GoHome();
        }

        private void picReload_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }
    }
}
