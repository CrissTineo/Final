using EntidadCapa;
using System.Data.SqlClient;
using System.Data;
using System;

namespace Negociocapa
{

	public class clsLnUsuario_nuevo {


	public void Cargar(ref clsBeUsuario_nuevo oBeUsuario_nuevo,  DataRow dr) {
			try
			{
				oBeUsuario_nuevo.UserID = Convert.ToInt32(dr["UserID"]);
				oBeUsuario_nuevo.Nombre = string.IsNullOrEmpty(dr["Nombre"].ToString()) == true ? "" : dr["Nombre"].ToString();
				oBeUsuario_nuevo.Apellido = string.IsNullOrEmpty(dr["Apellido"].ToString()) == true ? "" : dr["Apellido"].ToString();
				oBeUsuario_nuevo.Fecha_de_nacimiento = Convert.ToDateTime(dr["Fecha_de_nacimiento"]);
				oBeUsuario_nuevo.Correo = string.IsNullOrEmpty(dr["Correo"].ToString()) == true ? "" : dr["Correo"].ToString();
				oBeUsuario_nuevo.Pass = string.IsNullOrEmpty(dr["pass"].ToString()) == true ? "" : dr["pass"].ToString();
				oBeUsuario_nuevo.Role = string.IsNullOrEmpty(dr["Role"].ToString()) == true ? "" : dr["Role"].ToString();

			}
			catch (Exception ex)
			{
				throw ex;
			}
	}

	public int Insertar(ref clsBeUsuario_nuevo oBeUsuario_nuevo) {
		try {
			string sp = "SpUsuario_nuevoInsertar";
			
			SqlConnection cnn = new SqlConnection(ConexionDB.stringConnection);
			SqlCommand cmd = new SqlCommand(sp, cnn);
				cmd.CommandType = CommandType.StoredProcedure;

				int rowsAffected = 0;
				cnn.Open();

			cmd.Parameters.Add(new SqlParameter("@NOMBRE", oBeUsuario_nuevo.Nombre));
			cmd.Parameters.Add(new SqlParameter("@APELLIDO", oBeUsuario_nuevo.Apellido));
			cmd.Parameters.Add(new SqlParameter("@FECHA_DE_NACIMIENTO", oBeUsuario_nuevo.Fecha_de_nacimiento));
			cmd.Parameters.Add(new SqlParameter("@CORREO", oBeUsuario_nuevo.Correo));
			cmd.Parameters.Add(new SqlParameter("@PASS", oBeUsuario_nuevo.Pass));
			cmd.Parameters.Add(new SqlParameter("@ROLE", oBeUsuario_nuevo.Role));

				rowsAffected = cmd.ExecuteNonQuery();
				cmd.Parameters.Clear();
				cnn.Close();

				return rowsAffected;
			
		}
		catch (Exception ex) {
			throw ex;
		}
	}

	public int Actualizar(ref clsBeUsuario_nuevo oBeUsuario_nuevo) {
		try {
			string sp = "SpUsuario_nuevoActualizar";
			
			SqlConnection cnn = new SqlConnection(ConexionDB.stringConnection);
			SqlCommand cmd = new SqlCommand(sp, cnn);

				cmd.CommandType = CommandType.StoredProcedure;

				int rowsAffected = 0;
				cnn.Open();

				cmd.Parameters.Add(new SqlParameter("@USERID", oBeUsuario_nuevo.UserID));
			cmd.Parameters.Add(new SqlParameter("@NOMBRE", oBeUsuario_nuevo.Nombre));
			cmd.Parameters.Add(new SqlParameter("@APELLIDO", oBeUsuario_nuevo.Apellido));
			cmd.Parameters.Add(new SqlParameter("@FECHA_DE_NACIMIENTO", oBeUsuario_nuevo.Fecha_de_nacimiento));
			cmd.Parameters.Add(new SqlParameter("@CORREO", oBeUsuario_nuevo.Correo));
			cmd.Parameters.Add(new SqlParameter("@PASS", oBeUsuario_nuevo.Pass));
			cmd.Parameters.Add(new SqlParameter("@ROLE", oBeUsuario_nuevo.Role));

				rowsAffected = cmd.ExecuteNonQuery();
				cmd.Parameters.Clear();
				cnn.Close();

				return rowsAffected;
			
		}
		catch (Exception ex) {
			throw ex;
		}
	}

	public int Eliminar(ref clsBeUsuario_nuevo oBeUsuario_nuevo) {
		try {
			string sp = "SpUsuario_nuevoEliminar";
			
			SqlConnection cnn = new SqlConnection(ConexionDB.stringConnection);
			SqlCommand cmd = new SqlCommand(sp, cnn);
				cmd.CommandType = CommandType.StoredProcedure;

				int rowsAffected = 0;
				cnn.Open();

				cmd.Parameters.Add(new SqlParameter("@USERID", oBeUsuario_nuevo.UserID));

				rowsAffected = cmd.ExecuteNonQuery();
				cmd.Parameters.Clear();
				cnn.Close();

				return rowsAffected;
			
		}
		catch (Exception ex) {
			throw ex;
		}
	}

	public DataTable Listar() {
		try {
			string sp = "SpUsuario_nuevoListar";
			
			SqlConnection cnn = new SqlConnection(ConexionDB.stringConnection);
			SqlCommand cmd = new SqlCommand(sp, cnn);
			cmd.CommandType = CommandType.StoredProcedure;
			
			SqlDataAdapter dad = new SqlDataAdapter(cmd);
			
			DataTable dt = new DataTable();
			dad.Fill(dt);
			
			return dt;
			
		}
		catch (Exception ex) {
			throw ex;
		}
	}

	public bool Obtener(ref clsBeUsuario_nuevo oBeUsuario_nuevo) {
		try {
			string sp = "SpUsuario_nuevoObtener";
			
			SqlConnection cnn = new SqlConnection(ConexionDB.stringConnection);
			SqlCommand cmd = new SqlCommand(sp, cnn);
			cmd.CommandType = CommandType.StoredProcedure;
			
			SqlDataAdapter dad = new SqlDataAdapter(cmd);
			dad.SelectCommand.Parameters.Add(new SqlParameter("@USERID", oBeUsuario_nuevo.UserID));
			
			DataTable dt = new DataTable();
			dad.Fill(dt);
			
			if ((dt.Rows.Count == 1)) {
					Cargar(ref oBeUsuario_nuevo, dt.Rows[0]);
			}
			else {
				throw new Exception("No se pudo obtener el registro");
			}
			
			return true;
			
		}
		catch (Exception ex) {
			throw ex;
		}
	}
		public bool Obtenerusario(ref clsBeUsuario_nuevo oBeUsuario_nuevo)
		{
			try
			{
				string sp = "SpLoginUsuario_nuevo";

				SqlConnection cnn = new SqlConnection(ConexionDB.stringConnection);
				SqlCommand cmd = new SqlCommand(sp, cnn);
				cmd.CommandType = CommandType.StoredProcedure;

				SqlDataAdapter dad = new SqlDataAdapter(cmd);
				dad.SelectCommand.Parameters.Add(new SqlParameter("@CORREO", oBeUsuario_nuevo.Correo));
				dad.SelectCommand.Parameters.Add(new SqlParameter("@PASS", oBeUsuario_nuevo.Pass));

				DataTable dt = new DataTable();
				dad.Fill(dt);

				if ((dt.Rows.Count == 1))
				{
					Cargar(ref oBeUsuario_nuevo, dt.Rows[0]);
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