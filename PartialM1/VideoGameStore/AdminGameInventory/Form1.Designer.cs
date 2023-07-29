using System;

namespace AdminGameInventory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.PostBtn = new System.Windows.Forms.Button();
            this.TxtUprice = new System.Windows.Forms.TextBox();
            this.TxtBrand = new System.Windows.Forms.TextBox();
            this.TxtCode = new System.Windows.Forms.TextBox();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.unitpricelabel = new System.Windows.Forms.Label();
            this.brandlabel = new System.Windows.Forms.Label();
            this.codelabel = new System.Windows.Forms.Label();
            this.namelabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.clearBTN = new System.Windows.Forms.Button();
            this.AllBTN = new System.Windows.Forms.Button();
            this.ShowBtn = new System.Windows.Forms.Button();
            this.txtShow = new System.Windows.Forms.TextBox();
            this.DeleteBTN = new System.Windows.Forms.Button();
            this.UpdateBTN = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtResults = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Thistle;
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.PostBtn);
            this.panel1.Controls.Add(this.TxtUprice);
            this.panel1.Controls.Add(this.TxtBrand);
            this.panel1.Controls.Add(this.TxtCode);
            this.panel1.Controls.Add(this.TxtName);
            this.panel1.Controls.Add(this.unitpricelabel);
            this.panel1.Controls.Add(this.brandlabel);
            this.panel1.Controls.Add(this.codelabel);
            this.panel1.Controls.Add(this.namelabel);
            this.panel1.Location = new System.Drawing.Point(-1, 269);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(599, 117);
            this.panel1.TabIndex = 0;
            // 
            // PostBtn
            // 
            this.PostBtn.Location = new System.Drawing.Point(452, 29);
            this.PostBtn.Name = "PostBtn";
            this.PostBtn.Size = new System.Drawing.Size(114, 63);
            this.PostBtn.TabIndex = 8;
            this.PostBtn.Text = "Add";
            this.PostBtn.UseVisualStyleBackColor = true;
            this.PostBtn.Click += new System.EventHandler(this.PostBtn_Click);
            // 
            // TxtUprice
            // 
            this.TxtUprice.Location = new System.Drawing.Point(294, 69);
            this.TxtUprice.Name = "TxtUprice";
            this.TxtUprice.Size = new System.Drawing.Size(100, 20);
            this.TxtUprice.TabIndex = 7;
            // 
            // TxtBrand
            // 
            this.TxtBrand.Location = new System.Drawing.Point(294, 29);
            this.TxtBrand.Name = "TxtBrand";
            this.TxtBrand.Size = new System.Drawing.Size(100, 20);
            this.TxtBrand.TabIndex = 6;
            // 
            // TxtCode
            // 
            this.TxtCode.Location = new System.Drawing.Point(110, 69);
            this.TxtCode.Name = "TxtCode";
            this.TxtCode.Size = new System.Drawing.Size(100, 20);
            this.TxtCode.TabIndex = 5;
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(110, 29);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(100, 20);
            this.TxtName.TabIndex = 4;
            // 
            // unitpricelabel
            // 
            this.unitpricelabel.AutoSize = true;
            this.unitpricelabel.Location = new System.Drawing.Point(236, 69);
            this.unitpricelabel.Name = "unitpricelabel";
            this.unitpricelabel.Size = new System.Drawing.Size(50, 13);
            this.unitpricelabel.TabIndex = 3;
            this.unitpricelabel.Text = "UnitPrice";
            // 
            // brandlabel
            // 
            this.brandlabel.AutoSize = true;
            this.brandlabel.Location = new System.Drawing.Point(236, 29);
            this.brandlabel.Name = "brandlabel";
            this.brandlabel.Size = new System.Drawing.Size(35, 13);
            this.brandlabel.TabIndex = 2;
            this.brandlabel.Text = "Brand";
            // 
            // codelabel
            // 
            this.codelabel.AutoSize = true;
            this.codelabel.Location = new System.Drawing.Point(48, 69);
            this.codelabel.Name = "codelabel";
            this.codelabel.Size = new System.Drawing.Size(32, 13);
            this.codelabel.TabIndex = 1;
            this.codelabel.Text = "Code";
            // 
            // namelabel
            // 
            this.namelabel.AutoSize = true;
            this.namelabel.Location = new System.Drawing.Point(48, 29);
            this.namelabel.Name = "namelabel";
            this.namelabel.Size = new System.Drawing.Size(35, 13);
            this.namelabel.TabIndex = 0;
            this.namelabel.Text = "Name";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.clearBTN);
            this.panel2.Controls.Add(this.AllBTN);
            this.panel2.Controls.Add(this.ShowBtn);
            this.panel2.Controls.Add(this.txtShow);
            this.panel2.Controls.Add(this.DeleteBTN);
            this.panel2.Controls.Add(this.UpdateBTN);
            this.panel2.Controls.Add(this.txtID);
            this.panel2.Controls.Add(this.txtResults);
            this.panel2.Location = new System.Drawing.Point(-1, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(596, 271);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // clearBTN
            // 
            this.clearBTN.Location = new System.Drawing.Point(276, 185);
            this.clearBTN.Name = "clearBTN";
            this.clearBTN.Size = new System.Drawing.Size(104, 24);
            this.clearBTN.TabIndex = 14;
            this.clearBTN.Text = "Clear";
            this.clearBTN.UseVisualStyleBackColor = true;
            this.clearBTN.Click += new System.EventHandler(this.clearBTN_Click);
            // 
            // AllBTN
            // 
            this.AllBTN.Location = new System.Drawing.Point(153, 185);
            this.AllBTN.Name = "AllBTN";
            this.AllBTN.Size = new System.Drawing.Size(87, 24);
            this.AllBTN.TabIndex = 13;
            this.AllBTN.Text = "All Results";
            this.AllBTN.UseVisualStyleBackColor = true;
            this.AllBTN.Click += new System.EventHandler(this.AllBTN_Click);
            // 
            // ShowBtn
            // 
            this.ShowBtn.Location = new System.Drawing.Point(32, 185);
            this.ShowBtn.Name = "ShowBtn";
            this.ShowBtn.Size = new System.Drawing.Size(80, 24);
            this.ShowBtn.TabIndex = 12;
            this.ShowBtn.Text = "ID Results";
            this.ShowBtn.UseVisualStyleBackColor = true;
            this.ShowBtn.Click += new System.EventHandler(this.ShowBtn_Click);
            // 
            // txtShow
            // 
            this.txtShow.Location = new System.Drawing.Point(54, 215);
            this.txtShow.Name = "txtShow";
            this.txtShow.Size = new System.Drawing.Size(29, 20);
            this.txtShow.TabIndex = 11;
            this.txtShow.TextChanged += new System.EventHandler(this.txtShow_TextChanged);
            // 
            // DeleteBTN
            // 
            this.DeleteBTN.Location = new System.Drawing.Point(508, 59);
            this.DeleteBTN.Name = "DeleteBTN";
            this.DeleteBTN.Size = new System.Drawing.Size(80, 24);
            this.DeleteBTN.TabIndex = 10;
            this.DeleteBTN.Text = "Delete";
            this.DeleteBTN.UseVisualStyleBackColor = true;
            this.DeleteBTN.Click += new System.EventHandler(this.DeleteBTN_Click);
            // 
            // UpdateBTN
            // 
            this.UpdateBTN.Location = new System.Drawing.Point(422, 59);
            this.UpdateBTN.Name = "UpdateBTN";
            this.UpdateBTN.Size = new System.Drawing.Size(80, 24);
            this.UpdateBTN.TabIndex = 9;
            this.UpdateBTN.Text = "Change";
            this.UpdateBTN.UseVisualStyleBackColor = true;
            this.UpdateBTN.Click += new System.EventHandler(this.UpdateBTN_Click);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(491, 13);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(24, 20);
            this.txtID.TabIndex = 9;
            // 
            // txtResults
            // 
            this.txtResults.Location = new System.Drawing.Point(16, 13);
            this.txtResults.Name = "txtResults";
            this.txtResults.Size = new System.Drawing.Size(387, 160);
            this.txtResults.TabIndex = 0;
            this.txtResults.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.label1.Location = new System.Drawing.Point(40, 238);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Insert ID#";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.MenuBar;
            this.label2.Location = new System.Drawing.Point(478, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Insert ID#";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Lavender;
            this.label3.Location = new System.Drawing.Point(122, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(300, 37);
            this.label3.TabIndex = 18;
            this.label3.Text = "INVENTORY SYSTEM";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(475, 115);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(8, 20);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(409, 89);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(184, 170);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 385);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button PostBtn;
        private System.Windows.Forms.TextBox TxtUprice;
        private System.Windows.Forms.TextBox TxtBrand;
        private System.Windows.Forms.TextBox TxtCode;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Label unitpricelabel;
        private System.Windows.Forms.Label brandlabel;
        private System.Windows.Forms.Label codelabel;
        private System.Windows.Forms.Label namelabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.RichTextBox txtResults;
        private System.Windows.Forms.Button AllBTN;
        private System.Windows.Forms.Button ShowBtn;
        private System.Windows.Forms.TextBox txtShow;
        private System.Windows.Forms.Button DeleteBTN;
        private System.Windows.Forms.Button UpdateBTN;
        private System.Windows.Forms.Button clearBTN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}