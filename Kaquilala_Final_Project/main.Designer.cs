namespace Kaquilala_Final_Project
{
    partial class main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Menu_button = new FontAwesome.Sharp.IconButton();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Home_button = new FontAwesome.Sharp.IconButton();
            this.List_button = new FontAwesome.Sharp.IconButton();
            this.Profile_button = new FontAwesome.Sharp.IconButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Logout_button = new FontAwesome.Sharp.IconButton();
            this.TitleBarPanel = new System.Windows.Forms.Panel();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.DesktopPanel = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.TitleBarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Maroon;
            this.flowLayoutPanel1.Controls.Add(this.panel2);
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Controls.Add(this.Home_button);
            this.flowLayoutPanel1.Controls.Add(this.List_button);
            this.flowLayoutPanel1.Controls.Add(this.Profile_button);
            this.flowLayoutPanel1.Controls.Add(this.panel3);
            this.flowLayoutPanel1.Controls.Add(this.Logout_button);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(266, 746);
            this.flowLayoutPanel1.TabIndex = 2;
            this.flowLayoutPanel1.Tag = "";
            this.flowLayoutPanel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox3_MouseDown);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Menu_button);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(263, 68);
            this.panel2.TabIndex = 2;
//            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox3_MouseDown);
            // 
            // Menu_button
            // 
            this.Menu_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Menu_button.FlatAppearance.BorderSize = 0;
            this.Menu_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Menu_button.IconChar = FontAwesome.Sharp.IconChar.AlignJustify;
            this.Menu_button.IconColor = System.Drawing.Color.White;
            this.Menu_button.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Menu_button.Location = new System.Drawing.Point(189, 15);
            this.Menu_button.Name = "Menu_button";
            this.Menu_button.Size = new System.Drawing.Size(75, 49);
            this.Menu_button.TabIndex = 0;
            this.Menu_button.UseVisualStyleBackColor = true;
            this.Menu_button.Click += new System.EventHandler(this.Menu_button_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Kaquilala_Final_Project.Properties.Resources.Logo_with_text;
            this.pictureBox3.Location = new System.Drawing.Point(0, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(186, 67);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 77);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(264, 66);
            this.panel1.TabIndex = 3;
            // 
            // Home_button
            // 
            this.Home_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Home_button.Dock = System.Windows.Forms.DockStyle.Top;
            this.Home_button.FlatAppearance.BorderSize = 0;
            this.Home_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Home_button.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Home_button.ForeColor = System.Drawing.Color.White;
            this.Home_button.IconChar = FontAwesome.Sharp.IconChar.HomeLg;
            this.Home_button.IconColor = System.Drawing.Color.White;
            this.Home_button.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Home_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Home_button.Location = new System.Drawing.Point(3, 149);
            this.Home_button.Name = "Home_button";
            this.Home_button.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.Home_button.Size = new System.Drawing.Size(257, 45);
            this.Home_button.TabIndex = 3;
            this.Home_button.Tag = "Home";
            this.Home_button.Text = "  Home";
            this.Home_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Home_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Home_button.UseVisualStyleBackColor = true;
            this.Home_button.Click += new System.EventHandler(this.Home_button_Click);
            // 
            // List_button
            // 
            this.List_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.List_button.Dock = System.Windows.Forms.DockStyle.Top;
            this.List_button.FlatAppearance.BorderSize = 0;
            this.List_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.List_button.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.List_button.ForeColor = System.Drawing.Color.White;
            this.List_button.IconChar = FontAwesome.Sharp.IconChar.BasketShopping;
            this.List_button.IconColor = System.Drawing.Color.White;
            this.List_button.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.List_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.List_button.Location = new System.Drawing.Point(3, 200);
            this.List_button.Name = "List_button";
            this.List_button.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.List_button.Size = new System.Drawing.Size(257, 45);
            this.List_button.TabIndex = 4;
            this.List_button.Tag = "List";
            this.List_button.Text = "  List";
            this.List_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.List_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.List_button.UseVisualStyleBackColor = true;
            this.List_button.Click += new System.EventHandler(this.List_button_Click);
            // 
            // Profile_button
            // 
            this.Profile_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Profile_button.Dock = System.Windows.Forms.DockStyle.Top;
            this.Profile_button.FlatAppearance.BorderSize = 0;
            this.Profile_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Profile_button.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Profile_button.ForeColor = System.Drawing.Color.White;
            this.Profile_button.IconChar = FontAwesome.Sharp.IconChar.Person;
            this.Profile_button.IconColor = System.Drawing.Color.White;
            this.Profile_button.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Profile_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Profile_button.Location = new System.Drawing.Point(3, 251);
            this.Profile_button.Name = "Profile_button";
            this.Profile_button.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.Profile_button.Size = new System.Drawing.Size(257, 45);
            this.Profile_button.TabIndex = 5;
            this.Profile_button.Tag = "Profile";
            this.Profile_button.Text = "  Profile";
            this.Profile_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Profile_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Profile_button.UseVisualStyleBackColor = true;
            this.Profile_button.Click += new System.EventHandler(this.Profile_button_Click);
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(3, 302);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(264, 349);
            this.panel3.TabIndex = 6;
            // 
            // Logout_button
            // 
            this.Logout_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Logout_button.Dock = System.Windows.Forms.DockStyle.Top;
            this.Logout_button.FlatAppearance.BorderSize = 0;
            this.Logout_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Logout_button.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logout_button.ForeColor = System.Drawing.Color.White;
            this.Logout_button.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.Logout_button.IconColor = System.Drawing.Color.White;
            this.Logout_button.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Logout_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Logout_button.Location = new System.Drawing.Point(3, 657);
            this.Logout_button.Name = "Logout_button";
            this.Logout_button.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.Logout_button.Size = new System.Drawing.Size(257, 45);
            this.Logout_button.TabIndex = 6;
            this.Logout_button.Tag = "Logout";
            this.Logout_button.Text = "  Logout";
            this.Logout_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Logout_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Logout_button.UseVisualStyleBackColor = true;
            this.Logout_button.Click += new System.EventHandler(this.Logout_button_Click);
            // 
            // TitleBarPanel
            // 
            this.TitleBarPanel.Controls.Add(this.pictureBox6);
            this.TitleBarPanel.Controls.Add(this.pictureBox5);
            this.TitleBarPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitleBarPanel.Location = new System.Drawing.Point(266, 0);
            this.TitleBarPanel.Name = "TitleBarPanel";
            this.TitleBarPanel.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.TitleBarPanel.Size = new System.Drawing.Size(1006, 38);
            this.TitleBarPanel.TabIndex = 3;
            this.TitleBarPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox3_MouseDown);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox6.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox6.Image = global::Kaquilala_Final_Project.Properties.Resources.minimize_button_black;
            this.pictureBox6.Location = new System.Drawing.Point(930, 0);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(33, 38);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 1;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            this.pictureBox6.MouseEnter += new System.EventHandler(this.pictureBox6_MouseEnter);
            this.pictureBox6.MouseLeave += new System.EventHandler(this.pictureBox6_MouseLeave);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox5.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox5.Image = global::Kaquilala_Final_Project.Properties.Resources.close_button_black;
            this.pictureBox5.Location = new System.Drawing.Point(963, 0);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(33, 38);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 0;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            this.pictureBox5.MouseEnter += new System.EventHandler(this.pictureBox5_MouseEnter);
            this.pictureBox5.MouseLeave += new System.EventHandler(this.pictureBox5_MouseLeave);
            // 
            // DesktopPanel
            // 
            this.DesktopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(153)))), ((int)(((byte)(147)))));
            this.DesktopPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DesktopPanel.Location = new System.Drawing.Point(266, 38);
            this.DesktopPanel.Name = "DesktopPanel";
            this.DesktopPanel.Size = new System.Drawing.Size(1006, 708);
            this.DesktopPanel.TabIndex = 4;
            this.DesktopPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox3_MouseDown);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::Kaquilala_Final_Project.Properties.Resources.minimize_button_black;
            this.pictureBox2.Location = new System.Drawing.Point(1184, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(35, 26);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::Kaquilala_Final_Project.Properties.Resources.close_button_black;
            this.pictureBox1.Location = new System.Drawing.Point(1225, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1272, 746);
            this.Controls.Add(this.DesktopPanel);
            this.Controls.Add(this.TitleBarPanel);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "main";
            this.Text = "main";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.TitleBarPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel TitleBarPanel;
        private System.Windows.Forms.Panel DesktopPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private FontAwesome.Sharp.IconButton Menu_button;
        private System.Windows.Forms.PictureBox pictureBox3;
        private FontAwesome.Sharp.IconButton List_button;
        private FontAwesome.Sharp.IconButton Profile_button;
        private FontAwesome.Sharp.IconButton Logout_button;
        private FontAwesome.Sharp.IconButton Home_button;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
    }
}