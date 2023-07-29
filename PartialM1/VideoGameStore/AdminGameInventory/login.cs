using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminGameInventory
{
    public partial class login : Form
    {
        
        SqlConnection cn;
       
        public login()
        {
            InitializeComponent();
        }




        private void login_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=GameDB;Integrated Security=True;Connect Timeout=60;Encrypt=False");
            cn.Open();

        }

        private void Btnregister_Click(object sender, EventArgs e)
        {
            this.Hide();
            register registration = new register();
            registration.ShowDialog();
        }


        private void BtnLogin_Click(object sender, EventArgs e)
        {
            String Username, Password;
            Username = txtusername.Text;
            Password = txtpassword.Text;

            try
            {

                String query = "SELECT * FROM users WHERE Username = '" + txtusername.Text + "' AND Password =  '" + txtpassword.Text + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, cn);

            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                Username = txtusername.Text;
                Password = txtpassword.Text;

                Form1 form = new Form1();
                form.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Error");
            }
        }
            catch
            {
                MessageBox.Show("Error");
            }
            finally
            {
                cn.Close();
            }



            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
                
            
        


        
    
}
