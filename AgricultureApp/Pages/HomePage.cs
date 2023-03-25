using AgricultureApp.Pages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgricultureApp
{
    public partial class HomePage : Form
    {
        PreloadPage preloadPage;
        public HomePage(PreloadPage page)
        {
            preloadPage = page;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            preloadPage.Plantsbtn_Click(this, null);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            preloadPage.Groundbtn_Click(this, null);
        }
    }
}
