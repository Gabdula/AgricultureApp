using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgricultureApp
{
    public partial class WorkersPage : Form
    {
        PreloadPage preloadPage;
        public WorkersPage(PreloadPage page)
        {
            preloadPage = page;
            InitializeComponent();
        }
    }
}
