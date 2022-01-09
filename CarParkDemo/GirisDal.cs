using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarParkDemo
{
    public class GirisDal
    {
        SqlConnection _connection = new SqlConnection(@"server=(localdb)\mssqllocaldb;initial catalog=CarPark;integrated security=true");
        public DataTable GetAll()
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("Select * from Giris", _connection);
            SqlDataReader execute = command.ExecuteReader();

            DataTable dataTable = new DataTable();
            dataTable.Load(execute);
            execute.Close();
            _connection.Close();
            return dataTable;
        }
        public void Add(Giris giris)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("Insert into Giris values(@plaka,@tarih,@saat)", _connection);
            command.Parameters.AddWithValue("@plaka", giris.plaka);
            command.Parameters.AddWithValue("@tarih", giris.tarih);
            command.Parameters.AddWithValue("@saat", giris.saat);
            command.ExecuteNonQuery();
            _connection.Close();
        }

        public void Delete(int plaka)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("Delete from Giris where plaka=@plaka",_connection);
            command.Parameters.AddWithValue("@plaka", plaka);
            command.ExecuteNonQuery();
            _connection.Close();
        }

        private void ConnectionControl()
        {
            if (_connection.State == ConnectionState.Closed)
            {
                _connection.Open();
            }
        }

    }
}
