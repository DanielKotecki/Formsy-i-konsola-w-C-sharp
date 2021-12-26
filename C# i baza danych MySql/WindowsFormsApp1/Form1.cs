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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        { string connectionString;
            SqlConnection cnn;
            connectionString = @"Data Source=localhost;Initial Catalog=bazavisual;User ID=root;";
            cnn = new SqlConnection(connectionString);
            try
            {
                cnn.Open();
                MessageBox.Show("Prawidłowe połaczeniee");
                SqlCommand command;
                SqlDataReader dataReader;
                string sql, Output = "";
                cnn.Close();
                sql = "select * from dbo.grupy";
                command = new SqlCommand(sql, cnn);
                dataReader = command.ExecuteReader();
                while(dataReader.Read())
                {
                    Output = Output + dataReader.GetValue(0) + '-' + dataReader.GetValue(1) + "\n";

                }
                MessageBox.Show(Output, "dane z tabeli grupy");
                dataReader.Close();
                command.Dispose();
                cnn.Close();
            }
            catch(System.Data.SqlClient.SqlException se)
            {
                MessageBox.Show("Error:" + se.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var formInsert = new insert();
            formInsert.Show();
        }
    }
}
