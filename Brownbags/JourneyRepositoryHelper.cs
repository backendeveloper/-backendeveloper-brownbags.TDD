using System.Data;
using System.Data.SqlClient;

namespace Brownbags
{
    public class JourneyRepositoryHelper
    {
        public static void InsertOneJourney()
        {
            SqlCommand command = new SqlCommand();
            command.CommandText = "insert into dbo.journey(id) values('1')";
            command.CommandType = CommandType.Text;
            command.Connection =
                new SqlConnection(@"Server=127.0.0.1,1433; Database=dbo; User Id=SA; Password=super_duper_password");

            using (command)
            {
                if (command.Connection.State != ConnectionState.Open)
                {
                    command.Connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        public static void InsertTwoJourney()
        {
            SqlCommand command = new SqlCommand();
            command.CommandText = @"insert into dbo.journey(id) values('1')
                                    insert into dbo.journey(id) values('2')";
            command.CommandType = CommandType.Text;
            command.Connection =
                new SqlConnection(@"Server=127.0.0.1,1433; Database=dbo; User Id=SA; Password=super_duper_password");

            using (command)
            {
                if (command.Connection.State != ConnectionState.Open)
                {
                    command.Connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        public static void InitiliazeJourneyTable()
        {
            SqlCommand command = new SqlCommand();
            command.CommandText = $@"if object_id('dbo.journey') > 0
                                    begin
                                    drop table dbo.journey
                                    end
                                    create table dbo.journey (id INT not null)";
            command.CommandType = CommandType.Text;
            command.Connection =
                new SqlConnection(@"Server=127.0.0.1,1433; Database=dbo; User Id=SA; Password=super_duper_password");

            using (command)
            {
                if (command.Connection.State != ConnectionState.Open)
                {
                    command.Connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}