using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace TugasBuVennyMKK
{
    internal class Koneksi
    {
        string connectionstring = "Server = localhost; Database=c#;Uid=root;Pwd=;";
        MySqlConnection kon;

        public void OpenConnection()
        {
            kon = new MySqlConnection(connectionstring);
            kon.Open();
        }
        public void CloseConnection() 
        {
            kon.Close();
        }
        public void ExecuteQuery(string query)
        {
            MySqlCommand Commamd = new MySqlCommand(query, kon);
            Commamd.ExecuteNonQuery();
        }
        public object ShowData(String query)
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, connectionstring);
            DataSet Data = new DataSet ();

            adapter.Fill(Data);
            object bebas = Data.Tables[0];
            return bebas;
        }

    }
}
