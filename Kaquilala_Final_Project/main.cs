using Kaquilala_Final_Project.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kaquilala_Final_Project
{
    public partial class main : Form
    {
        NavigationControl navigationControl;
        string name;
        //round edges
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nRightRect, int nTopRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        //Drag Form
        [DllImport("User32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("User32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

        //drop shadow
        private const int CS_DropShadow = 0x00020000;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DropShadow;
                return cp;
            }
        }
        public main()
        {
            InitializeComponent();
            CollapseMenu();
            this.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            InitializeNavigationControl();
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            (sender as PictureBox).Image = Image.FromFile(@"Resources\close button red.png");
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            (sender as PictureBox).Image = Image.FromFile(@"Resources\close button black.png");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void pictureBox5_MouseEnter(object sender, EventArgs e)
        {
            (sender as PictureBox).Image = Image.FromFile(@"Resources\close button red.png");
        }

        private void pictureBox5_MouseLeave(object sender, EventArgs e)
        {
            (sender as PictureBox).Image = Image.FromFile(@"Resources\close button black.png");
        }

        private void pictureBox6_MouseEnter(object sender, EventArgs e)
        {
            (sender as PictureBox).Image = Image.FromFile(@"Resources\minimize button blue.png");
        }

        private void pictureBox6_MouseLeave(object sender, EventArgs e)
        {
            (sender as PictureBox).Image = Image.FromFile(@"Resources\minimize button black.png");
        }
        private void Menu_button_Click(object sender, EventArgs e)
        {
            CollapseMenu();
            
        }
        private void CollapseMenu()
        {
            if (flowLayoutPanel1.Width > 200)
            {
                flowLayoutPanel1.Width = 80;
                pictureBox3.Visible = false;
                Menu_button.Dock = DockStyle.Left;
                Menu_button.Padding = new Padding(0);
                foreach(Button menuButton in flowLayoutPanel1.Controls.OfType<Button>())
                {
                    menuButton.Text = "";
                    menuButton.ImageAlign = ContentAlignment.MiddleLeft;
                    menuButton.Padding = new Padding(5);
                }

            }
            else
            {
                flowLayoutPanel1.Width = 266;
                pictureBox3.Visible = true;
                Menu_button.Dock = DockStyle.None;
                foreach (Button menuButton in flowLayoutPanel1.Controls.OfType<Button>())
                {
                    menuButton.Text = "  " + menuButton.Tag.ToString();
                    menuButton.ImageAlign = ContentAlignment.MiddleLeft;
                    menuButton.Padding = new Padding(10,0,0,0);
                }
            }
        }

        private void pictureBox4_MouseEnter(object sender, EventArgs e)
        {
            (sender as PictureBox).Image = Image.FromFile(@"Resources\Home panel button hover.png");
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            (sender as PictureBox).Image = Image.FromFile(@"Resources\Home panel button.png");
        }

        private void pictureBox7_MouseEnter(object sender, EventArgs e)
        {
            (sender as PictureBox).Image = Image.FromFile(@"Resources\profile panel button hover.png");
        }

        private void pictureBox7_MouseLeave(object sender, EventArgs e)
        {
            (sender as PictureBox).Image = Image.FromFile(@"Resources\profile panel button.png");
        }

        private void menu_MouseEnter(object sender, EventArgs e)
        {
            (sender as PictureBox).Image = Image.FromFile(@"Resources\menu hover.png");
        }

        private void menu_MouseLeave(object sender, EventArgs e)
        {
            (sender as PictureBox).Image = Image.FromFile(@"Resources\menu.png");
        }

        private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox8_MouseEnter(object sender, EventArgs e)
        {
            (sender as PictureBox).Image = Image.FromFile(@"Resources\list panel button hover.png");
        }

        private void pictureBox8_MouseLeave(object sender, EventArgs e)
        {
            (sender as PictureBox).Image = Image.FromFile(@"Resources\list panel button.png");
        }

        private void Logout_button_Click(object sender, EventArgs e)
        {
            new LoginForm().Show();
            this.Hide();
        }

        private void InitializeNavigationControl()
        {
            List<UserControl> userControls = new List<UserControl>()
            { new Home(), new ListPage(), new Profile() };

            navigationControl = new NavigationControl(userControls, DesktopPanel);
            navigationControl.Display(0);
        }

        private void Home_button_Click(object sender, EventArgs e)
        {
            navigationControl.Display(0);
        }

        private void List_button_Click(object sender, EventArgs e)
        {
            navigationControl.Display(1);
        }

        private void Profile_button_Click(object sender, EventArgs e)
        {
            navigationControl.Display(2);
        }
    }
}
