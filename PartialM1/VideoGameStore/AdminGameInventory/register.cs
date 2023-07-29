using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminGameInventory
{
    public partial class register : Form
    {
        public register()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=GameDB;Integrated Security=True;Connect Timeout=60;Encrypt=False");

        private async void registerBTN_Click(object sender, EventArgs e)
        {
            string username = TxtUsername.Text;
            string password = TxtPass.Text;

            string json = $"{{\"username\": \"{username}\", \"password\": \"{password}\"}}";

            using (HttpClient client = new HttpClient())
            {
                HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, "https://localhost:7109/api/Item/register");
                request.Content = new StringContent(json, Encoding.UTF8, "application/json");

                HttpResponseMessage response = await client.SendAsync(request);
                if (response.IsSuccessStatusCode)
                {
                    string responseBody = await response.Content.ReadAsStringAsync();
                    MessageBox.Show("Registered!");
                    login log = new login();
                    log.Show();
                    this.Hide();
                }
                else
                {
                    string errorMessage = await response.Content.ReadAsStringAsync();
                    MessageBox.Show($"Error: {response.StatusCode} - {errorMessage}");
                }
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
