using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using MySql.Data.MySqlClient;

namespace WebService
{
    /// <summary>
    /// Opis podsumowujący dla WebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Aby zezwalać na wywoływanie tej usługi sieci Web ze skryptu za pomocą kodu ASP.NET AJAX, usuń znaczniki komentarza z następującego wiersza. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Cześć to ja twój program Danielu";
        }

        [WebMethod]
        public string Baza()
        {
            MySqlConnection cnn;
            string server = "localhost",
             // database = "bazavisual",
             database = "testowa",
             uid = "root",//nazwa
             password = "";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
            //connectionString = @"Data Source=localhost;Initial Catalog=bazavisual;User ID=root;";
            cnn = new MySqlConnection(connectionString);
            try
            {
                cnn.Open();
                
                MySqlCommand command;
                MySqlDataReader dataReader;
                string sql, Output = "";

                //sql = "select * from uzytkownik";
                sql = "select * from tab";
                command = new MySqlCommand(sql, cnn);
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    Output = Output + "[id:" + dataReader.GetValue(0) + '\n' +
                     "Marka:" + dataReader.GetValue(1) + "\n" +
                     "Model:" + dataReader.GetValue(2) + "\n" +
                     "Moc silnika:" + dataReader.GetValue(3) + "\n" + 
                     "Dostępność:" + dataReader.GetValue(4) + "]" + "\n";
                    //return Output.ToString();



                    /* Output = Output + "[id:" + dataReader.GetValue(0) + '\n' +
                       "Imię:" + dataReader.GetValue(1) + "\n" +
                       "Nazwisko:" + dataReader.GetValue(2) + "\n" +
                       "Mail:" + dataReader.GetValue(3) + "\n" +
                       "Adres" + dataReader.GetValue(4) + "]" + "\n";*/
                    //return Output.ToString();

                }

                dataReader.Close();
                command.Dispose();
                cnn.Close();
                return Output.ToString(); ;
            }

            catch (MySql.Data.MySqlClient.MySqlException se)
            {
                return "Błąd";
            }
        }
        [WebMethod]
        public void ladowanie( string marka,string model, int moc_silnika,string dostepnosc)
        {
            MySqlConnection cnn;
            string server = "localhost",
            // database = "bazavisual",
             database="testowa",
             uid = "root",//nazwa
             password = "";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
            //connectionString = @"Data Source=localhost;Initial Catalog=bazavisual;User ID=root;";
            cnn = new MySqlConnection(connectionString);
            try
            {
                cnn.Open();

                MySqlCommand command;
                MySqlDataReader dataReader;
                string sql, Output = "";
                sql = "INSERT INTO tab (marka,model,moc_silnika,dostepnosc) VALUES('" + marka + "', '" + model + "', '" + moc_silnika +"','"+dostepnosc+"'); ";
                // sql = "INSERT INTO uzytkownik (Imie, Nazwisko, Mail, Adres) VALUES('"+imie+"', '"+nazwisko+"', '"+mail+"','"+adres+"'); ";
                command = new MySqlCommand(sql, cnn);
                dataReader = command.ExecuteReader();
               
                dataReader.Close();
                command.Dispose();
                cnn.Close();
                
            }

            catch (MySql.Data.MySqlClient.MySqlException se)
            {
                
            }
            
        }
        [WebMethod]
        public string usuwanie(int _id)
        {
            MySqlConnection cnn;
            string server = "localhost",
            // database = "bazavisual",
             database = "testowa",
             uid = "root",//nazwa
             password = "";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
            //connectionString = @"Data Source=localhost;Initial Catalog=bazavisual;User ID=root;";
            cnn = new MySqlConnection(connectionString);
            try
            {
                cnn.Open();

                MySqlCommand command;
                MySqlDataReader dataReader;
                string sql, Output = "";
                sql = "delete from tab where id = '" + _id+ "'; ";
                // sql = "INSERT INTO uzytkownik (Imie, Nazwisko, Mail, Adres) VALUES('"+imie+"', '"+nazwisko+"', '"+mail+"','"+adres+"'); ";
                command = new MySqlCommand(sql, cnn);
                dataReader = command.ExecuteReader();

                dataReader.Close();
                command.Dispose();
                cnn.Close();
                return "Usuwanie zakończone sukcesem";
            }

            catch (MySql.Data.MySqlClient.MySqlException se)
            {
                return "Błąd";
            }

        }
        [WebMethod]
        public string tylkoDostepne()
        {
            MySqlConnection cnn;
            string server = "localhost",
             // database = "bazavisual",
             database = "testowa",
             uid = "root",//nazwa
             password = "";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
            //connectionString = @"Data Source=localhost;Initial Catalog=bazavisual;User ID=root;";
            cnn = new MySqlConnection(connectionString);
            try
            {
                cnn.Open();

                MySqlCommand command;
                MySqlDataReader dataReader;
                string sql, Output1 = "";
                string dos = "dostepny";
                //sql = "select * from uzytkownik";
                 sql = "select * from tab where dos='"+dos+"';";
               
                command = new MySqlCommand(sql, cnn);
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    Output1 = Output1 + "[id:" + dataReader.GetValue(0) + '\n' +
                     "Marka:" + dataReader.GetValue(1) + "\n" +
                     "Model:" + dataReader.GetValue(2) + "\n" +
                     "Moc silnika:" + dataReader.GetValue(3) + "\n" +
                     "Dostępność:" + dataReader.GetValue(4) + "]" + "\n";
                    
                }

                dataReader.Close();
                command.Dispose();
                cnn.Close();
                return Output1.ToString();
            }

            catch (MySql.Data.MySqlClient.MySqlException se)
            {
                return "Błąd";
            }
        }

        [WebMethod]
        public string modDosT(int _id)
        {
            MySqlConnection cnn;
            string server = "localhost",
            // database = "bazavisual",
             database = "testowa",
             uid = "root",//nazwa
             password = "";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
            //connectionString = @"Data Source=localhost;Initial Catalog=bazavisual;User ID=root;";
            cnn = new MySqlConnection(connectionString);
            try
            {
                cnn.Open();

                MySqlCommand command;
                MySqlDataReader dataReader;
                string sql, Output = "";
                sql = "update tab set dos='dostepne' where id = '" + _id + "'; ";
                command = new MySqlCommand(sql, cnn);
                dataReader = command.ExecuteReader();

                dataReader.Close();
                command.Dispose();
                cnn.Close();
                return "Modyfikacja zakończona sukcesem";
            }

            catch (MySql.Data.MySqlClient.MySqlException se)
            {
                return "Błąd";
            }

        }

        [WebMethod]
        public string modDosN(int _id)
        {
            MySqlConnection cnn;
            string server = "localhost",
            // database = "bazavisual",
             database = "testowa",
             uid = "root",//nazwa
             password = "";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
            //connectionString = @"Data Source=localhost;Initial Catalog=bazavisual;User ID=root;";
            cnn = new MySqlConnection(connectionString);
            try
            {
                cnn.Open();

                MySqlCommand command;
                MySqlDataReader dataReader;
                string sql, Output = "";
                sql = "update tab set dos='niedostepne' where id = '" + _id + "'; ";
                command = new MySqlCommand(sql, cnn);
                dataReader = command.ExecuteReader();

                dataReader.Close();
                command.Dispose();
                cnn.Close();
                return "Modyfikacja zakończona sukcesem";
            }

            catch (MySql.Data.MySqlClient.MySqlException se)
            {
                return "Błąd";
            }

        }


    }
    
    
}
