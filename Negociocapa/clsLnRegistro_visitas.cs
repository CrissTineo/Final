using EntidadCapa;
using System.Data.SqlClient;
using System.Data;
using System;

namespace Negociocapa
{

	public class clsLnRegistro_visitas {

	public void Cargar(ref clsBeRegistro_visitas oBeRegistro_visitas, DataRow dr) {
			try {
				oBeRegistro_visitas.Id_registro = Convert.ToInt32(dr["Id_registro"]);
				oBeRegistro_visitas.Nombre = string.IsNullOrEmpty(dr["Nombre"].ToString()) == true ? "" : dr["Nombre"].ToString();
				oBeRegistro_visitas.Apellido = string.IsNullOrEmpty(dr["Apellido"].ToString()) == true ? "" : dr["Apellido"].ToString();
				oBeRegistro_visitas.Correo = string.IsNullOrEmpty(dr["Correo"].ToString()) == true ? "" : dr["Correo"].ToString();
				oBeRegistro_visitas.Carrera = string.IsNullOrEmpty(dr["Carrera"].ToString()) == true ? "" : dr["Carrera"].ToString();
				oBeRegistro_visitas.Curso = string.IsNullOrEmpty(dr["Curso"].ToString()) == true ? "" : dr["Curso"].ToString();
				oBeRegistro_visitas.Edificio = string.IsNullOrEmpty(dr["Edificio"].ToString()) == true ? "" : dr["Edificio"].ToString();
				oBeRegistro_visitas.Motivo = string.IsNullOrEmpty(dr["Motivo"].ToString()) == true ? "" : dr["Motivo"].ToString();
				oBeRegistro_visitas.Hora = Convert.ToDateTime(dr["Hora"]);	
				oBeRegistro_visitas.EdificioID = Convert.ToInt32(dr["EdificioID"]);
				oBeRegistro_visitas.AulaID = Convert.ToInt32(dr["AulaID"]);
			} 
			catch (Exception ex) {
				throw ex;
			}
	}

	public int Insertar(ref clsBeRegistro_visitas oBeRegistro_visitas) {
		try {
			string sp = "SpRegistro_visitasInsertar";
			
			SqlConnection cnn = new SqlConnection(ConexionDB.stringConnection);
			SqlCommand cmd = new SqlCommand(sp, cnn);
				cmd.CommandType = CommandType.StoredProcedure;
				int rowsAffected = 0;
				cnn.Open();

				cmd.Parameters.Add(new SqlParameter("@NOMBRE", oBeRegistro_visitas.Nombre));
			cmd.Parameters.Add(new SqlParameter("@APELLIDO", oBeRegistro_visitas.Apellido));
			cmd.Parameters.Add(new SqlParameter("@CORREO", oBeRegistro_visitas.Correo));
			cmd.Parameters.Add(new SqlParameter("@CARRERA", oBeRegistro_visitas.Carrera));
			cmd.Parameters.Add(new SqlParameter("@CURSO", oBeRegistro_visitas.Curso));
			cmd.Parameters.Add(new SqlParameter("@EDIFICIO", oBeRegistro_visitas.Edificio));
			cmd.Parameters.Add(new SqlParameter("@MOTIVO", oBeRegistro_visitas.Motivo));
			cmd.Parameters.Add(new SqlParameter("@HORA", oBeRegistro_visitas.Hora));
			cmd.Parameters.Add(new SqlParameter("@EDIFICIOID", oBeRegistro_visitas.EdificioID));
			cmd.Parameters.Add(new SqlParameter("@AULAID", oBeRegistro_visitas.AulaID));

				rowsAffected = cmd.ExecuteNonQuery();
				cmd.Parameters.Clear();
				cnn.Close();

				return rowsAffected;
			
		}
		catch (Exception ex) {
			throw ex;
		}
	}

	public int Actualizar(ref clsBeRegistro_visitas oBeRegistro_visitas) {
		try {
			string sp = "SpRegistro_visitasActualizar";
			
			SqlConnection cnn = new SqlConnection(ConexionDB.stringConnection);
			SqlCommand cmd = new SqlCommand(sp, cnn);

				cmd.CommandType = CommandType.StoredProcedure;
				int rowsAffected = 0;
				cnn.Open();

			cmd.Parameters.Add(new SqlParameter("@ID_REGISTRO", oBeRegistro_visitas.Id_registro));
			cmd.Parameters.Add(new SqlParameter("@NOMBRE", oBeRegistro_visitas.Nombre));
			cmd.Parameters.Add(new SqlParameter("@APELLIDO", oBeRegistro_visitas.Apellido));
			cmd.Parameters.Add(new SqlParameter("@CORREO", oBeRegistro_visitas.Correo));
			cmd.Parameters.Add(new SqlParameter("@CARRERA", oBeRegistro_visitas.Carrera));
			cmd.Parameters.Add(new SqlParameter("@CURSO", oBeRegistro_visitas.Curso));
			cmd.Parameters.Add(new SqlParameter("@EDIFICIO", oBeRegistro_visitas.Edificio));
			cmd.Parameters.Add(new SqlParameter("@MOTIVO", oBeRegistro_visitas.Motivo));
			cmd.Parameters.Add(new SqlParameter("@HORA", oBeRegistro_visitas.Hora));
			cmd.Parameters.Add(new SqlParameter("@EDIFICIOID", oBeRegistro_visitas.EdificioID));
			cmd.Parameters.Add(new SqlParameter("@AULAID", oBeRegistro_visitas.AulaID));

				rowsAffected = cmd.ExecuteNonQuery();
				cmd.Parameters.Clear();
				cnn.Close();

				return rowsAffected;
			
		}
		catch (Exception ex) {
			throw ex;
		}
	}

	public int Eliminar(ref clsBeRegistro_visitas oBeRegistro_visitas) {
		try {
			string sp = "SpRegistro_visitasEliminar";
			
			SqlConnection cnn = new SqlConnection(ConexionDB.stringConnection);
			SqlCommand cmd = new SqlCommand(sp, cnn);

				cmd.CommandType = CommandType.StoredProcedure;
				int rowsAffected = 0;
				cnn.Open();

				cmd.Parameters.Add(new SqlParameter("@ID_REGISTRO", oBeRegistro_visitas.Id_registro));

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
			string sp = "SpRegistro_visitasListar";
			
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

	public bool Obtener(ref clsBeRegistro_visitas oBeRegistro_visitas) {
		try {
			string sp = "SpRegistro_visitasObtener";
			
			SqlConnection cnn = new SqlConnection(ConexionDB.stringConnection);
			SqlCommand cmd = new SqlCommand(sp, cnn);
			cmd.CommandType = CommandType.StoredProcedure;
			
			SqlDataAdapter dad = new SqlDataAdapter(cmd);
			dad.SelectCommand.Parameters.Add(new SqlParameter("@ID_REGISTRO", oBeRegistro_visitas.Id_registro));
			
			DataTable dt = new DataTable();
			dad.Fill(dt);
			
			if ((dt.Rows.Count == 1)) {
					Cargar(ref oBeRegistro_visitas, dt.Rows[0]);
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


}
}