using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kaquilala_Final_Project
{
    public partial class RegForm : Form
    {
        //database global 
        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=db_users.mdb;Jet OLEDB:Database Password=haruglory");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();

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
        public RegForm()
        {
            InitializeComponent();

            this.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void reg_btn_MouseEnter(object sender, EventArgs e)
        {
            (sender as PictureBox).Image = Image.FromFile(@"Resources\reg_btn_2.png");
        }

        private void reg_btn_MouseLeave(object sender, EventArgs e)
        {
            (sender as PictureBox).Image = Image.FromFile(@"Resources\reg_btn_1.png");
        }

        private void clr_btn_MouseEnter(object sender, EventArgs e)
        {
            (sender as PictureBox).Image = Image.FromFile(@"Resources\clr_btn_2.png");
        }

        private void clr_btn_MouseLeave(object sender, EventArgs e)
        {
            (sender as PictureBox).Image = Image.FromFile(@"Resources\clr_btn_1.png");
        }

        private void reg_btn_Click(object sender, EventArgs e)
        {
            string user2;
            if(username.Text == "" && pw_1.Text == "" && pw_2.Text == "")
            {
                MessageBox.Show("Username and Passwords fields are empty", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (pw_1.Text == pw_2.Text)
            {
                try
                {
                    conn.Open();
                    string register = "INSERT INTO tbl_users VALUES ('" + username.Text + "', '" + pw_1.Text + "' )";
                    cmd = new OleDbCommand(register, conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    user2 = username.Text;
                    username.Text = "";
                    pw_1.Text = "";
                    pw_2.Text = "";

                    MessageBox.Show("Your Account has been Successfully Created", "Registration Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (OleDbException ex)
                {
                    if (ex.ErrorCode == -2147217873)
                    {
                        MessageBox.Show("Username already exists, please try another username", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("An error occurred while creating your account. Please try again later.", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    username.Text = "";
                    pw_1.Text = "";
                    pw_2.Text = "";
                    username.Focus();
                }
                
            }
            else
            {
                MessageBox.Show("Passwords do not match, please re-enter", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                pw_1.Text = "";
                pw_2.Text = "";
                pw_1.Focus();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                pw_1.PasswordChar = '\0';
                pw_2.PasswordChar = '\0';
            }
            else
            {
                pw_1.PasswordChar = '•';
                pw_2.PasswordChar = '•';
            }
        }

        private void clr_btn_Click(object sender, EventArgs e)
        {
            username.Text = "";
            pw_1.Text = "";
            pw_2.Text = "";
            username.Focus();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            new LoginForm().Show();
            this.Hide();
        }

        private void RegForm_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void label5_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox8_MouseEnter(object sender, EventArgs e)
        {
            (sender as PictureBox).Image = Image.FromFile(@"Resources\close button red.png");
        }

        private void pictureBox8_MouseLeave(object sender, EventArgs e)
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

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
