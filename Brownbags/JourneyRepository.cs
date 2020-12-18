using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Brownbags
{
    public class JourneyRepository
    {
        public List<Journey> List()
        {
            SqlCommand command = new SqlCommand();
            command.CommandText = "select * from dbo.journey";
            command.CommandType = CommandType.Text;
            command.Connection =
                new SqlConnection(@"Server=127.0.0.1,1433; Database=dbo; User Id=SA; Password=super_duper_password");

            List<Journey> list = null;
            using (command)
            {
                if (command.Connection.State != ConnectionState.Open)
                {
                    command.Connection.Open();
                    SqlDataReader sqlDataReader = command.ExecuteReader();
                    DataTable dataTable = new DataTable();
                    dataTable.Load(sqlDataReader);

                    if (dataTable.Rows.Count > 0)
                    {
                        list = new List<Journey>(dataTable.Rows.Count);
                    }

                    foreach (DataRow dataRow in dataTable.Rows)
                    {
                        list.Add(new Journey() {Id = dataRow["id"].ToString()});
                    }
                }
            }

            return list;
        }
    }
}