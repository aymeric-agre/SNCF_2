using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data.MySqlClient;

namespace SNCF_2
{
    public partial class MyAccountForm : Form
    {
        string connString;
        MySqlConnection conn;
        MySqlCommand command;

        public MyAccountForm(client thisClient)
        {
            connString = "Server=localhost;Port=3306;Database=sncf;Uid=root;password=root";
            conn = new MySqlConnection(connString);
            command = conn.CreateCommand();

            InitializeComponent();
        }

        private void myTicketsTabPage_Load(object sender, EventArgs e)
        {
            string login= "";
            command.CommandText = "Select client.login from client where (login='" + login + "')";
            bool value;
            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            MySqlDataReader reader = command.ExecuteReader();
            if (!reader.Read())
            {
                value = false;
            }
            else
            {
                value = true;
            }
            conn.Close();
        }
    }
}
