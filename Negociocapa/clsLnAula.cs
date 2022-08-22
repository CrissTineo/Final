using EntidadCapa;
using System.Data.SqlClient;
using System.Data;
using System;

namespace Negociocapa
{

	public class clsLnAula
	{

		
		public void Cargar(ref clsBeAula oBeAula, DataRow dr)
		{
			try
			{
				oBeAula.AulaID = Convert.ToInt32(dr["AulaID"]);
				oBeAula.Aula = string.IsNullOrEmpty(dr["Aula"].ToString()) == true ? "" : dr["Aula"].ToString();
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		public int Insertar(ref clsBeAula oBeAula)
		{
			try
			{
				string sp = "SpAulaInsertar";

				SqlConnection cnn = new SqlConnection(ConexionDB.stringConnection);
				SqlCommand cmd = new SqlCommand(sp, cnn);
				cmd.CommandType = CommandType.StoredProcedure;

				int rowsAffected = 0;
				cnn.Open();

                cmd.Parameters.Add(new SqlParameter("@AULA", oBeAula.Aula));

				rowsAffected = cmd.ExecuteNonQuery();
				cmd.Parameters.Clear();
				cnn.Close();

				return rowsAffected;

			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		public int Actualizar(ref clsBeAula oBeAula)
		{
			try
			{
				string sp = "SpAulaActualizar";

				SqlConnection cnn = new SqlConnection(ConexionDB.stringConnection);
				SqlCommand cmd = new SqlCommand(sp, cnn);

				cmd.CommandType = CommandType.StoredProcedure;

				int rowsAffected = 0;
				cnn.Open();

				cmd.Parameters.Add(new SqlParameter("@AULAID", oBeAula.AulaID));
				cmd.Parameters.Add(new SqlParameter("@AULA", oBeAula.Aula));

				rowsAffected = cmd.ExecuteNonQuery();
				cmd.Parameters.Clear();
				cnn.Close();

				return rowsAffected;

			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		public int Eliminar(ref clsBeAula oBeAula)
		{
			try
			{
				string sp = "SpAulaEliminar";

				SqlConnection cnn = new SqlConnection(ConexionDB.stringConnection);
				SqlCommand cmd = new SqlCommand(sp, cnn);
				cmd.CommandType = CommandType.StoredProcedure;

				int rowsAffected = 0;
				cnn.Open();


				cmd.Parameters.Add(new SqlParameter("@AULAID", oBeAula.AulaID));

				rowsAffected = cmd.ExecuteNonQuery();
				cmd.Parameters.Clear();
				cnn.Close();

				return rowsAffected;

			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		public DataTable Listar()
		{
			try
			{
				string sp = "SpAulaListar";

				SqlConnection cnn = new SqlConnection(ConexionDB.stringConnection);
				SqlCommand cmd = new SqlCommand(sp, cnn);
				cmd.CommandType = CommandType.StoredProcedure;

				SqlDataAdapter dad = new SqlDataAdapter(cmd);

				DataTable dt = new DataTable();
				dad.Fill(dt);

				return dt;

			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		public bool Obtener(ref clsBeAula oBeAula)
		{
			try
			{
				string sp = "SpAulaObtener";

				SqlConnection cnn = new SqlConnection(ConexionDB.stringConnection);
				SqlCommand cmd = new SqlCommand(sp, cnn);
				cmd.CommandType = CommandType.StoredProcedure;

				SqlDataAdapter dad = new SqlDataAdapter(cmd);
				dad.SelectCommand.Parameters.Add(new SqlParameter("@AULAID", oBeAula.AulaID));

				DataTable dt = new DataTable();
				dad.Fill(dt);

				if ((dt.Rows.Count == 1))
				{
					Cargar(ref oBeAula, dt.Rows[0]);
				}
				else
				{
					throw new Exception("No se pudo obtener el registro");
				}

				return true;

			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

	}
}
