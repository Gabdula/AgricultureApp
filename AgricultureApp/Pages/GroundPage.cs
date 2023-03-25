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
    public partial class GroundPage : Form
    {
        PreloadPage preloadPage;
        public GroundPage(PreloadPage page)
        {
            preloadPage = page;
            InitializeComponent();
        }
    }
}
