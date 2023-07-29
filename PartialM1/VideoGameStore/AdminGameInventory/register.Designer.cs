using System;

namespace AdminGameInventory
{
    partial class register
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtUsername = new System.Windows.Forms.TextBox();
            this.TxtPass = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.registerBTN = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(19, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // TxtUsername
            // 
            this.TxtUsername.Location = new System.Drawing.Point(115, 77);
            this.TxtUsername.Multiline = true;
            this.TxtUsername.Name = "TxtUsername";
            this.TxtUsername.Size = new System.Drawing.Size(159, 26);
            this.TxtUsername.TabIndex = 4;
            // 
            // TxtPass
            // 
            this.TxtPass.Location = new System.Drawing.Point(116, 125);
            this.TxtPass.Multiline = true;
            this.TxtPass.Name = "TxtPass";
            this.TxtPass.Size = new System.Drawing.Size(159, 25);
            this.TxtPass.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("EmojiOne Color", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(73, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 39);
            this.label4.TabIndex = 9;
            this.label4.Text = "REGISTER";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // registerBTN
            // 
            this.registerBTN.BackColor = System.Drawing.Color.Magenta;
            this.registerBTN.ForeColor = System.Drawing.SystemColors.ControlText;
            this.registerBTN.Location = new System.Drawing.Point(42, 174);
            this.registerBTN.Name = "registerBTN";
            this.registerBTN.Size = new System.Drawing.Size(263, 45);
            this.registerBTN.TabIndex = 10;
            this.registerBTN.Text = "ENTER";
            this.registerBTN.UseVisualStyleBackColor = false;
            this.registerBTN.Click += new System.EventHandler(this.registerBTN_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.panel1.Controls.Add(this.TxtPass);
            this.panel1.Controls.Add(this.registerBTN);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-1, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(334, 294);
            this.panel1.TabIndex = 11;
            // 
            // register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 296);
            this.Controls.Add(this.TxtUsername);
            this.Controls.Add(this.panel1);
            this.Name = "register";
            this.Text = "register";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtUsername;
        private System.Windows.Forms.TextBox TxtPass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button registerBTN;
        private System.Windows.Forms.Panel panel1;
    }
}