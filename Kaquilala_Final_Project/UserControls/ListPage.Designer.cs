namespace Kaquilala_Final_Project.UserControls
{
    partial class ListPage
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.GroceryList = new System.Windows.Forms.DataGridView();
            this.CategoryCbox = new RJCodeAdvance.RJControls.RJComboBox();
            this.quantity = new System.Windows.Forms.NumericUpDown();
            this.Add_Entry = new RJCodeAdvance.RJControls.RJButton();
            this.Del_Entry = new RJCodeAdvance.RJControls.RJButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Edit_Quant = new RJCodeAdvance.RJControls.RJButton();
            this.ItemList = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TotPrice = new System.Windows.Forms.Label();
            this.NoItem = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GroceryList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemList)).BeginInit();
            this.SuspendLayout();
            // 
            // GroceryList
            // 
            this.GroceryList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.GroceryList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GroceryList.Location = new System.Drawing.Point(499, 87);
            this.GroceryList.Name = "GroceryList";
            this.GroceryList.ReadOnly = true;
            this.GroceryList.RowHeadersWidth = 62;
            this.GroceryList.RowTemplate.Height = 28;
            this.GroceryList.Size = new System.Drawing.Size(682, 525);
            this.GroceryList.TabIndex = 0;
            this.GroceryList.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.GroceryList_CellMouseClick);
            this.GroceryList.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.GroceryList_RowPostPaint);
            // 
            // CategoryCbox
            // 
            this.CategoryCbox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CategoryCbox.BorderColor = System.Drawing.Color.Maroon;
            this.CategoryCbox.BorderSize = 0;
            this.CategoryCbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.CategoryCbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.CategoryCbox.ForeColor = System.Drawing.Color.Maroon;
            this.CategoryCbox.IconColor = System.Drawing.Color.Maroon;
            this.CategoryCbox.ListBackColor = System.Drawing.Color.MistyRose;
            this.CategoryCbox.ListTextColor = System.Drawing.Color.Maroon;
            this.CategoryCbox.Location = new System.Drawing.Point(57, 87);
            this.CategoryCbox.Margin = new System.Windows.Forms.Padding(0);
            this.CategoryCbox.MinimumSize = new System.Drawing.Size(200, 30);
            this.CategoryCbox.Name = "CategoryCbox";
            this.CategoryCbox.Size = new System.Drawing.Size(369, 30);
            this.CategoryCbox.TabIndex = 1;
            this.CategoryCbox.Texts = "";
            this.CategoryCbox.OnSelectedIndexChanged += new System.EventHandler(this.CategoryCbox_OnSelectedIndexChanged);
            // 
            // quantity
            // 
            this.quantity.Location = new System.Drawing.Point(350, 492);
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(47, 26);
            this.quantity.TabIndex = 2;
            // 
            // Add_Entry
            // 
            this.Add_Entry.BackColor = System.Drawing.Color.Maroon;
            this.Add_Entry.BackgroundColor = System.Drawing.Color.Maroon;
            this.Add_Entry.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.Add_Entry.BorderRadius = 30;
            this.Add_Entry.BorderSize = 0;
            this.Add_Entry.FlatAppearance.BorderSize = 0;
            this.Add_Entry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add_Entry.ForeColor = System.Drawing.Color.White;
            this.Add_Entry.Location = new System.Drawing.Point(114, 542);
            this.Add_Entry.Name = "Add_Entry";
            this.Add_Entry.Size = new System.Drawing.Size(111, 63);
            this.Add_Entry.TabIndex = 3;
            this.Add_Entry.Text = "ADD ENTRY";
            this.Add_Entry.TextColor = System.Drawing.Color.White;
            this.Add_Entry.UseVisualStyleBackColor = false;
            this.Add_Entry.Click += new System.EventHandler(this.Add_Entry_Click);
            // 
            // Del_Entry
            // 
            this.Del_Entry.BackColor = System.Drawing.Color.Maroon;
            this.Del_Entry.BackgroundColor = System.Drawing.Color.Maroon;
            this.Del_Entry.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.Del_Entry.BorderRadius = 30;
            this.Del_Entry.BorderSize = 0;
            this.Del_Entry.FlatAppearance.BorderSize = 0;
            this.Del_Entry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Del_Entry.ForeColor = System.Drawing.Color.White;
            this.Del_Entry.Location = new System.Drawing.Point(286, 542);
            this.Del_Entry.Name = "Del_Entry";
            this.Del_Entry.Size = new System.Drawing.Size(111, 63);
            this.Del_Entry.TabIndex = 4;
            this.Del_Entry.Text = "DELETE ENTRY";
            this.Del_Entry.TextColor = System.Drawing.Color.White;
            this.Del_Entry.UseVisualStyleBackColor = false;
            this.Del_Entry.Click += new System.EventHandler(this.Del_Entry_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(137, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 32);
            this.label1.TabIndex = 5;
            this.label1.Text = "ENTER CATEGORY:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(169, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 32);
            this.label2.TabIndex = 7;
            this.label2.Text = "ENTER ITEM:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(117, 486);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(224, 32);
            this.label3.TabIndex = 8;
            this.label3.Text = "ENTER QUANTITY:";
            // 
            // Edit_Quant
            // 
            this.Edit_Quant.BackColor = System.Drawing.Color.Maroon;
            this.Edit_Quant.BackgroundColor = System.Drawing.Color.Maroon;
            this.Edit_Quant.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.Edit_Quant.BorderRadius = 30;
            this.Edit_Quant.BorderSize = 0;
            this.Edit_Quant.FlatAppearance.BorderSize = 0;
            this.Edit_Quant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Edit_Quant.ForeColor = System.Drawing.Color.White;
            this.Edit_Quant.Location = new System.Drawing.Point(123, 629);
            this.Edit_Quant.Name = "Edit_Quant";
            this.Edit_Quant.Size = new System.Drawing.Size(264, 63);
            this.Edit_Quant.TabIndex = 9;
            this.Edit_Quant.Text = "EDIT QUANTITY";
            this.Edit_Quant.TextColor = System.Drawing.Color.White;
            this.Edit_Quant.UseVisualStyleBackColor = false;
            this.Edit_Quant.Click += new System.EventHandler(this.Edit_Quant_Click);
            // 
            // ItemList
            // 
            this.ItemList.AllowUserToAddRows = false;
            this.ItemList.AllowUserToDeleteRows = false;
            this.ItemList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.ItemList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ItemList.Location = new System.Drawing.Point(16, 161);
            this.ItemList.Name = "ItemList";
            this.ItemList.ReadOnly = true;
            this.ItemList.RowHeadersWidth = 62;
            this.ItemList.RowTemplate.Height = 28;
            this.ItemList.Size = new System.Drawing.Size(477, 306);
            this.ItemList.TabIndex = 10;
            this.ItemList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ItemList_CellContentClick);
            this.ItemList.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.ItemList_RowPostPaint);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(493, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(185, 32);
            this.label4.TabIndex = 11;
            this.label4.Text = "GROCERY LIST:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(493, 615);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(226, 32);
            this.label5.TabIndex = 12;
            this.label5.Text = "Total No. of Items:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(934, 615);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 32);
            this.label7.TabIndex = 14;
            // 
            // TotPrice
            // 
            this.TotPrice.AutoSize = true;
            this.TotPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotPrice.ForeColor = System.Drawing.Color.Maroon;
            this.TotPrice.Location = new System.Drawing.Point(493, 660);
            this.TotPrice.Name = "TotPrice";
            this.TotPrice.Size = new System.Drawing.Size(78, 32);
            this.TotPrice.TabIndex = 15;
            this.TotPrice.Text = "₱0.00";
            // 
            // NoItem
            // 
            this.NoItem.AutoSize = true;
            this.NoItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoItem.ForeColor = System.Drawing.Color.Maroon;
            this.NoItem.Location = new System.Drawing.Point(717, 617);
            this.NoItem.Name = "NoItem";
            this.NoItem.Size = new System.Drawing.Size(28, 32);
            this.NoItem.TabIndex = 16;
            this.NoItem.Text = "0";
            // 
            // ListPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(153)))), ((int)(((byte)(147)))));
            this.Controls.Add(this.NoItem);
            this.Controls.Add(this.TotPrice);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ItemList);
            this.Controls.Add(this.Edit_Quant);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Del_Entry);
            this.Controls.Add(this.Add_Entry);
            this.Controls.Add(this.quantity);
            this.Controls.Add(this.CategoryCbox);
            this.Controls.Add(this.GroceryList);
            this.Name = "ListPage";
            this.Size = new System.Drawing.Size(1221, 708);
            this.Load += new System.EventHandler(this.ListPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GroceryList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GroceryList;
        private RJCodeAdvance.RJControls.RJComboBox CategoryCbox;
        private System.Windows.Forms.NumericUpDown quantity;
        private RJCodeAdvance.RJControls.RJButton Add_Entry;
        private RJCodeAdvance.RJControls.RJButton Del_Entry;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private RJCodeAdvance.RJControls.RJButton Edit_Quant;
        private System.Windows.Forms.DataGridView ItemList;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label TotPrice;
        private System.Windows.Forms.Label NoItem;
    }
}
