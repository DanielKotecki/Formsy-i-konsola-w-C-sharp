using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace WindowsFormsApp1
{
    public partial class insert : Form
    {
        public insert()
        {
            InitializeComponent();
        }

        private void insert_Load(object sender, EventArgs e)
        {
            string connectionString;
            SqlConnection cnn;
            connectionString = @"Data Source=localhost;Initial Catalog=wsb;Integrated Security =True";
            cnn = new SqlConnection(connectionString);
            try
            {
                cnn.Open();
                MessageBox.Show("Prawidłowe połaczeniee");
                SqlCommand command;
                SqlDataAdapter adapter = new SqlDataAdapter();
                string sql= "";
                sql = "insert into grupy(\"nazwa_grupy\")values('Anna')";
                command = new SqlCommand(sql, cnn);
               adapter.InsertCommand = new SqlCommand(sql, cnn);
                adapter.InsertCommand.ExecuteNonQuery();
                command.Dispose();
                cnn.Close();

              
            }
            catch (System.Data.SqlClient.SqlException se)
            {
                MessageBox.Show("Error:" + se.Message);
            }
        }
    }
    
}
