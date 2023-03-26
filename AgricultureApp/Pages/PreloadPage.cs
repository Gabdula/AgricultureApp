using AgricultureApp.Pages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgricultureApp
{
    public partial class PreloadPage : Form
    {
        bool sidebarExpand;
        bool userProfileExpand;
        string roleUser;
        string userName;
        System.Drawing.Bitmap userImage;
        bool isAdmin = false;
        public PreloadPage()
        {
            InitializeComponent();

            #region defaultSettings
            sidebarPanel.BringToFront();
            Usersbtn.Visible = false;
            roleText.Text = "Role: ";

            SetRoundedShape(userprofileFrame, 10);
            SetRoundedShape(userprofileContainer, 10);

            this.FormBorderStyle= FormBorderStyle.None;
            this.Padding = new Padding(borderSize);
            this.BackColor = Color.FromArgb(31, 31, 31);
            appContainer.BackColor = SystemColors.Control;

            Homebtn.Image = Properties.Resources.home_selected_icon;
            Homebtn.ForeColor = ColorTranslator.FromHtml("#b1c43e");
            #endregion

        }

        //Окно без рамки, перетаскивание мышкой окна, закругление
        #region FormSettings

        private int borderRadius = 10;
        private int borderSize = 2;
        private Color borderColor = Color.FromArgb(31, 31, 31);

        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.Style |= 0x20000; // <--- Minimize borderless form from taskbar
                return cp;
            }
        }
        private void AppContainer_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        //Private Methods
        private GraphicsPath GetRoundedPath(Rectangle rect, float radius)
        {
            GraphicsPath path = new GraphicsPath();
            float curveSize = radius * 2F;
            path.StartFigure();
            path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);
            path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90);
            path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90);
            path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90);
            path.CloseFigure();
            return path;
        }
        private void FormRegionAndBorder(Form form, float radius, Graphics graph, Color borderColor, float borderSize)
        {
            if (this.WindowState != FormWindowState.Minimized)
            {
                using (GraphicsPath roundPath = GetRoundedPath(form.ClientRectangle, radius))
                using (Pen penBorder = new Pen(borderColor, borderSize))
                using (Matrix transform = new Matrix())
                {
                    graph.SmoothingMode = SmoothingMode.AntiAlias;
                    form.Region = new Region(roundPath);
                    if (borderSize >= 1)
                    {
                        Rectangle rect = form.ClientRectangle;
                        float scaleX = 1.0F - ((borderSize + 1) / rect.Width);
                        float scaleY = 1.0F - ((borderSize + 1) / rect.Height);
                        transform.Scale(scaleX, scaleY);
                        transform.Translate(borderSize / 1.6F, borderSize / 1.6F);
                        graph.Transform = transform;
                        graph.DrawPath(penBorder, roundPath);
                    }
                }
            }
        }
        private void ControlRegionAndBorder(Control control, float radius, Graphics graph, Color borderColor)
        {
            using (GraphicsPath roundPath = GetRoundedPath(control.ClientRectangle, radius))
            using (Pen penBorder = new Pen(borderColor, 1))
            {
                graph.SmoothingMode = SmoothingMode.AntiAlias;
                control.Region = new Region(roundPath);
                graph.DrawPath(penBorder, roundPath);
            }
        }
        private void DrawPath(Rectangle rect, Graphics graph, Color color)
        {
            using (GraphicsPath roundPath = GetRoundedPath(rect, borderRadius))
            using (Pen penBorder = new Pen(color, 3))
            {
                graph.DrawPath(penBorder, roundPath);
            }
        }      
        private void PreloadPage_Paint(object sender, PaintEventArgs e)
        {
            FormRegionAndBorder(this, borderRadius, e.Graphics, borderColor, borderSize);
        }
        private void appContainer_Paint(object sender, PaintEventArgs e)
        {
            ControlRegionAndBorder(appContainer, borderRadius-(borderRadius/2), e.Graphics, borderColor);
        }
        private void PreloadPage_ResizeEnd(object sender, EventArgs e)
        {
            this.Invalidate();
        }

        private void PreloadPage_Activated(object sender, EventArgs e)
        {
            this.Invalidate();
        }

        private void PreloadPage_SizeChanged(object sender, EventArgs e)
        {
            this.Invalidate();
        }

        public void SetRoundedShape(Control control, int radius)
        {
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddLine(radius, 0, control.Width - radius, 0);
            path.AddArc(control.Width - radius, 0, radius, radius, 270, 90);
            path.AddLine(control.Width, radius, control.Width, control.Height - radius);
            path.AddArc(control.Width - radius, control.Height - radius, radius, radius, 0, 90);
            path.AddLine(control.Width - radius, control.Height, radius, control.Height);
            path.AddArc(0, control.Height - radius, radius, radius, 90, 90);
            path.AddLine(0, control.Height - radius, 0, radius);
            path.AddArc(0, 0, radius, radius, 180, 90);
            control.Region = new Region(path);
        }
        #endregion

        //Кастомные кнопки закрытия и сворачивания окна
        #region FormButtons
        private void Exitbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Collapsebtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        #endregion

        //Анимация открытия и закрытия меню, нажатие на кнопку меню
        #region Sidebar
        private void SidebarTimer_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebarPanel.Width -= 10;

                if (sidebarPanel.Width == sidebarPanel.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sidebarTimer.Stop();
                }
            }
            else
            {
                sidebarPanel.Width += 10;

                if (sidebarPanel.Width == sidebarPanel.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    sidebarTimer.Stop();
                }
            }
        }

        private void Menuimage_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }
        #endregion

        //Анимация открытия и закрытия меню профиля
        #region ProfileMenu
        private void UserProfileTimer_Tick(object sender, EventArgs e)
        {
            if (userProfileExpand)
            {
                userProfile.Height -= 10;

                if (userProfile.Height == userProfile.MinimumSize.Height)
                {
                    userProfileExpand = false;
                    userProfileTimer.Stop();
                }
            }
            else
            {
                userProfile.Height += 10;

                if (userProfile.Height == userProfile.MaximumSize.Height)
                {
                    userProfileExpand = true;
                    userProfileTimer.Stop();
                }
            }
        }
        private void UserProfileImage_Click(object sender, EventArgs e)
        {
            userProfileTimer.Start();
        }

        private void UsernameText_Click(object sender, EventArgs e)
        {
            userProfileTimer.Start();
        }
        private void UserProfile_Click(object sender, EventArgs e)
        {
            userProfileTimer.Start();
        }
        #endregion

        //Функция замены форм в панели
        #region FormChange
        private Form active;
        public void PanelForm(Form fm)
        {
            if (active != null)
                active.Close();

            active = fm;
            fm.TopLevel = false;
            fm.FormBorderStyle = FormBorderStyle.None;
            fm.Dock = DockStyle.Fill;
            this.contantPanel.Controls.Add(fm);
            this.contantPanel.Tag = fm;
            fm.BringToFront();
            fm.Show();
        }
        #endregion

        //Изменения цвета текста и иконок при выборе
        #region BtnColorChange
        public void ChoisePage(string btn)
        {
            #region DefaultValue
            Homebtn.Image = Properties.Resources.home_icon;
            Homebtn.ForeColor = ColorTranslator.FromHtml("#ffffff");
            Workersbtn.Image = Properties.Resources.workers_icon;
            Workersbtn.ForeColor = ColorTranslator.FromHtml("#ffffff");
            Groundbtn.Image = Properties.Resources.ground_icon;
            Groundbtn.ForeColor = ColorTranslator.FromHtml("#ffffff");
            Plantsbtn.Image = Properties.Resources.plants_icon;
            Plantsbtn.ForeColor = ColorTranslator.FromHtml("#ffffff");
            Sowingbtn.Image = Properties.Resources.sowing_icon;
            Sowingbtn.ForeColor = ColorTranslator.FromHtml("#ffffff");
            Aboutbtn.Image = Properties.Resources.about_icon;
            Aboutbtn.ForeColor = ColorTranslator.FromHtml("#ffffff");
            Usersbtn.Image = Properties.Resources.users_icon;
            Usersbtn.ForeColor = ColorTranslator.FromHtml("#ffffff");
            #endregion

            switch (btn)
            {
                case "homepage":
                    Homebtn.Image = Properties.Resources.home_selected_icon;
                    Homebtn.ForeColor = ColorTranslator.FromHtml("#b1c43e");
                    break;
                case "workerspage":
                    Workersbtn.Image = Properties.Resources.workers_selected_icon;
                    Workersbtn.ForeColor = ColorTranslator.FromHtml("#b1c43e");
                    break;
                case "groundpage":
                    Groundbtn.Image = Properties.Resources.ground_selected_icon;
                    Groundbtn.ForeColor = ColorTranslator.FromHtml("#b1c43e");
                    break;
                case "plantspage":
                    Plantsbtn.Image = Properties.Resources.plants_selected_icon;
                    Plantsbtn.ForeColor = ColorTranslator.FromHtml("#b1c43e");
                    break;
                case "sowingpage":
                    Sowingbtn.Image = Properties.Resources.sowing_selected_icon;
                    Sowingbtn.ForeColor = ColorTranslator.FromHtml("#b1c43e");
                    break;
                case "aboutpage":
                    Aboutbtn.Image = Properties.Resources.about_selected_icon;
                    Aboutbtn.ForeColor = ColorTranslator.FromHtml("#b1c43e");
                    break;
                case "userspage":
                    Usersbtn.Image = Properties.Resources.users_selected_icon;
                    Usersbtn.ForeColor = ColorTranslator.FromHtml("#b1c43e");
                    break;
                default:
                    break;
            }
        }
        #endregion

        //Отключение\Включение компонентов меню
        //Переход на форму Авторизации, Регестрации и Основного приложения
        //Получение информации о пользователе
        #region Login
        public void OffMenu()
        { 
            sidebarContainer.Visible = false;
            Separator.Visible = false;
            userProfile.Visible = false;
            panelAdminSettings.Visible = false;
            usernameText.Text = string.Empty;
        }
        public void OnMenu()
        {
            sidebarContainer.Visible = true;
            Separator.Visible = true;
            userProfile.Visible = true;
            usernameText.Text = userName;
            if (roleUser == "worker") 
            {
                panelAdminSettings.Visible = true;
                adminSettingsOn.Checked = true;
            }
        }
        public void GotoRegestrationPage() 
        {
            PanelForm(new RegestrationPage(this));
        }
        public void GotoLoginpage()
        {
            PanelForm(new LoginPage(this));
        }
        public void GotoApp() 
        {
            PanelForm(new HomePage(this));
            ChoisePage("homepage");
        }
        public void SetInfoUser(string role, string name, Bitmap userimage)
        { 
            roleUser = role;
            userName = name;
            userImage = userimage;

            roleText.Text = "Role: " + role;
            if (userImage == null) 
            {
                userProfileImage.Image = Properties.Resources.defaultUserImage;
            }
            else 
            { 
                userProfileImage.Image = userImage;
            }
        }
        #endregion

        //События нажатия на кнопки (+ начальное окно)
        #region FormBtnEvents 
        private void PreloadPage_Load(object sender, EventArgs e)
        {
            PanelForm(new LoginPage(this));
        }

        private void Homebtn_Click(object sender, EventArgs e)
        {
            PanelForm(new HomePage(this));
            ChoisePage("homepage");
            if (userProfileExpand)
            {
                userProfileTimer.Start();
            }
        }

        private void Workersbtn_Click(object sender, EventArgs e)
        {
            if (isAdmin)
            {
                PanelForm(new WorkersPageADMIN(this));
                ChoisePage("workerspage");
            }
            else
            { 
                PanelForm(new WorkersPage(this));
                ChoisePage("workerspage");
            }
            if (userProfileExpand)
            {
                userProfileTimer.Start();
            }
        }

        public void Groundbtn_Click(object sender, EventArgs e)
        {
            if (isAdmin)
            {
                PanelForm(new GroundPageADMIN(this));
                ChoisePage("groundpage");
            }
            else
            {
                PanelForm(new GroundPage(this));
                ChoisePage("groundpage");
            }
            if (userProfileExpand)
            {
                userProfileTimer.Start();
            }
        }

        public void Plantsbtn_Click(object sender, EventArgs e)
        {
            if (isAdmin)
            {
                PanelForm(new PlantsPageADMIN(this));
                ChoisePage("plantspage");
            }
            else
            {
                PanelForm(new PlantsPage(this));
                ChoisePage("plantspage");
            }
            if (userProfileExpand)
            {
                userProfileTimer.Start();
            }
        }

        private void Sowingbtn_Click(object sender, EventArgs e)
        {
            if (isAdmin)
            {
                PanelForm(new SowingPageADMIN(this));
                ChoisePage("sowingpage");
            }
            else
            {
                PanelForm(new SowingPage(this));
                ChoisePage("sowingpage");
            }
            if (userProfileExpand)
            {
                userProfileTimer.Start();
            }
        }
        private void Usersbtn_Click(object sender, EventArgs e)
        {
            PanelForm(new UsersPageADMIN(this));
            ChoisePage("userspage");
            if (userProfileExpand)
            {
                userProfileTimer.Start();
            }
        }
        private void Aboutbtn_Click(object sender, EventArgs e)
        {
            PanelForm(new AboutPage(this));
            ChoisePage("aboutpage");
            if (userProfileExpand)
            {
                userProfileTimer.Start();
            }
        }
        private void Logoutbtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите выйти?", "Выход", MessageBoxButtons.YesNo) == DialogResult.Yes)
                GotoLoginpage();

            if (userProfileExpand)
                userProfileTimer.Start();

            if (adminSettingsOn.Checked == true) 
            {
                adminSettingsOn.Checked = false;
                GotoLoginpage();
            }

        }
        private void AdminSettingsOn_CheckedChanged(object sender, EventArgs e)
        {
            if (adminSettingsOn.Checked)
            {
                isAdmin = true;
                Usersbtn.Visible = true;
                GotoApp();
            }
            else
            {
                isAdmin = false;
                Usersbtn.Visible = false;
                GotoApp();
            } 
        }
        #endregion
    }
}
