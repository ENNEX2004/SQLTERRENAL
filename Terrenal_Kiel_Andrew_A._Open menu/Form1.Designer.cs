namespace Terrenal_Kiel_Andrew_A._Open_menu
{
    partial class Form1
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
            this.lblproduct = new System.Windows.Forms.Label();
            this.lblcategory = new System.Windows.Forms.Label();
            this.lblprice = new System.Windows.Forms.Label();
            this.textproduct = new System.Windows.Forms.TextBox();
            this.listcategory = new System.Windows.Forms.ListBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textprice = new System.Windows.Forms.TextBox();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblproduct
            // 
            this.lblproduct.AutoSize = true;
            this.lblproduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblproduct.Location = new System.Drawing.Point(65, 91);
            this.lblproduct.Name = "lblproduct";
            this.lblproduct.Size = new System.Drawing.Size(71, 20);
            this.lblproduct.TabIndex = 1;
            this.lblproduct.Text = "Product";
            // 
            // lblcategory
            // 
            this.lblcategory.AutoSize = true;
            this.lblcategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcategory.Location = new System.Drawing.Point(55, 127);
            this.lblcategory.Name = "lblcategory";
            this.lblcategory.Size = new System.Drawing.Size(81, 20);
            this.lblcategory.TabIndex = 2;
            this.lblcategory.Text = "Category";
            // 
            // lblprice
            // 
            this.lblprice.AutoSize = true;
            this.lblprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprice.Location = new System.Drawing.Point(87, 161);
            this.lblprice.Name = "lblprice";
            this.lblprice.Size = new System.Drawing.Size(49, 20);
            this.lblprice.TabIndex = 3;
            this.lblprice.Text = "Price";
            // 
            // textproduct
            // 
            this.textproduct.Location = new System.Drawing.Point(151, 91);
            this.textproduct.Name = "textproduct";
            this.textproduct.Size = new System.Drawing.Size(107, 20);
            this.textproduct.TabIndex = 5;
            // 
            // listcategory
            // 
            this.listcategory.FormattingEnabled = true;
            this.listcategory.Location = new System.Drawing.Point(151, 130);
            this.listcategory.Name = "listcategory";
            this.listcategory.Size = new System.Drawing.Size(106, 17);
            this.listcategory.TabIndex = 6;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(295, 59);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(561, 344);
            this.listView1.TabIndex = 7;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Product";
            this.columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Category";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Price";
            this.columnHeader4.Width = 100;
            // 
            // textprice
            // 
            this.textprice.Location = new System.Drawing.Point(152, 161);
            this.textprice.Name = "textprice";
            this.textprice.Size = new System.Drawing.Size(104, 20);
            this.textprice.TabIndex = 9;
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(145, 204);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(113, 28);
            this.btnadd.TabIndex = 10;
            this.btnadd.Text = " Add Record";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnupdate.Location = new System.Drawing.Point(144, 238);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(114, 28);
            this.btnupdate.TabIndex = 11;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.White;
            this.btndelete.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btndelete.Location = new System.Drawing.Point(145, 268);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(113, 28);
            this.btndelete.TabIndex = 12;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 439);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.textprice);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.listcategory);
            this.Controls.Add(this.textproduct);
            this.Controls.Add(this.lblprice);
            this.Controls.Add(this.lblcategory);
            this.Controls.Add(this.lblproduct);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblproduct;
        private System.Windows.Forms.Label lblcategory;
        private System.Windows.Forms.Label lblprice;
        private System.Windows.Forms.TextBox textproduct;
        private System.Windows.Forms.ListBox listcategory;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TextBox textprice;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}

