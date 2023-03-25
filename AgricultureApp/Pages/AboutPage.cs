using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgricultureApp.Pages
{
    public partial class AboutPage : Form
    {
        PreloadPage preloadPage;
        public AboutPage(PreloadPage page)
        {
            preloadPage = page;
            InitializeComponent();
        }
    }
}
