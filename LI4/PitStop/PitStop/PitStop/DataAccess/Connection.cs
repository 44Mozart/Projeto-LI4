using System;
using System.Data.SqlClient;
namespace PitStop
{
	public class Connection
	{
		private SqlConnection _connection;

		public Connection() { 
			_connection = new SqlConnection("Server=DESKTOP-JUDA1PG; Database=PitStop;Trusted_Connection=True;");
		}
		public void Close()
		{
			if(_connection.State == System.Data.ConnectionState.Open)
			{
				_connection.Close();
			}
		}

		public SqlConnection Fetch()
		{
			if(_connection.State == System.Data.ConnectionState.Open)
			{
				return _connection;
			}
			else
			{
				return this.Open();
			}
		} 

		public SqlConnection Open()
		{
			_connection.Open();
			return _connection;
		}
		}
}
