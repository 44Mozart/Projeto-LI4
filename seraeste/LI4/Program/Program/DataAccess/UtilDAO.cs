using System;
using System.Data.SqlClient;
using System.Data;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Program.DataAccess;
using Program.Models;

namespace Program.DataAccess {
	public class UtilDAO
	{
		public bool Insert(Utilizador u)
        {
			Connection con = new Connection();
			using(SqlCommand command = con.Fetch().CreateCommand())
            {
				command.CommandType = CommandType.Text;
				command.CommandText = "insert into [Utilizador] Values(@Username,@Nome,@Pass,@Email)";
				command.Parameters.Add("@Username", SqlDbType.Text).Value = u.Username;
				command.Parameters.Add("@Nome", SqlDbType.Text).Value = u.Nome;
				command.Parameters.Add("@Pass", SqlDbType.Text).Value = u.Pass;
				command.Parameters.Add("@Email", SqlDbType.Text).Value = u.Email;

				command.ExecuteScalar();

				con.Close();
				return true;
			}
        }

		public int LogIn(string user, string pass)
        {
			int id = -1;
			Connection con = new Connection();
			using(SqlCommand command = con.Fetch().CreateCommand())
            {
				command.CommandType = CommandType.Text;
				command.CommandText = "select Username from[Utilizador] where Nome=@Nome AND Password=@Password";
				command.Parameters.Add("@Nome", SqlDbType.VarChar);
				command.Parameters.Add("@Pass", SqlDbType.VarChar);
				command.Parameters["@Nome"].Value = user;
				command.Parameters["@Pass"].Value = pass;

				using(SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
					DataTable result = new DataTable();
					adapter.Fill(result);

					if(result.Rows.Count > 0)
                    {
						DataRow row = result.Rows[0];
						id = int.Parse(row["Username"].ToString());
                    }
					con.Close();
                }
            }
			return id;
        }

		
	}
}
