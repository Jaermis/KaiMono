using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Runtime.InteropServices;
using System.Configuration;
using System.Security.Cryptography;

namespace Kaquilala_Final_Project
{
    public partial class LoginForm : Form
    {
        public static string uname = "";
        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=db_users.mdb;Jet OLEDB:Database Password=haruglory");
        OleDbCommand cmd = new OleDbCommand();

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

        public LoginForm()
        {
            InitializeComponent();
            this.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void login_btn_MouseEnter(object sender, EventArgs e)
        {
            (sender as PictureBox).Image = Image.FromFile(@"Resources\login button_2.png");
        }

        private void login_btn_MouseLeave(object sender, EventArgs e)
        {
            (sender as PictureBox).Image = Image.FromFile(@"Resources\login button_1.png");
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            conn.Open();
            string login = "SELECT * FROM tbl_users WHERE username= '" + username.Text + "' and password= '" + pw.Text + "'";
            cmd = new OleDbCommand(login, conn);
            OleDbDataReader dr = cmd.ExecuteReader();

            if(dr.Read() == true)
            {
                uname = username.Text;
                new main().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password, Please Try Again", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                username.Text = "";
                pw.Text = "";
                username.Focus();
            }
            conn.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                pw.PasswordChar = '\0';
            }
            else
            {
                pw.PasswordChar = '•';

            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            new RegForm().Show();
            this.Hide();
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void LoginForm_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void label4_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox6_MouseEnter(object sender, EventArgs e)
        {
            (sender as PictureBox).Image = Image.FromFile(@"Resources\close button red.png");
        }

        private void pictureBox6_MouseLeave(object sender, EventArgs e)
        {
            (sender as PictureBox).Image = Image.FromFile(@"Resources\close button black.png");
        }

        private void pictureBox7_MouseEnter(object sender, EventArgs e)
        {
            (sender as PictureBox).Image = Image.FromFile(@"Resources\minimize button blue.png");
        }

        private void pictureBox7_MouseLeave(object sender, EventArgs e)
        {
            (sender as PictureBox).Image = Image.FromFile(@"Resources\minimize button black.png");
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
