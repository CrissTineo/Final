using EntidadCapa;
using System.Data.SqlClient;
using System.Data;
using System;
namespace Negociocapa
{

	public class clsLnEdificio {

	

	public void Cargar(ref clsBeEdificio oBeEdificio, DataRow dr) {
			try
			{
				oBeEdificio.EdificioID = Convert.ToInt32(dr["EdificioID"]);
				oBeEdificio.Edificio = string.IsNullOrEmpty(dr["Edificio"].ToString()) == true ? "" : dr["Edificio"].ToString();
			}
			catch (Exception ex)
			{
				throw ex;
			}
	}

	public int Insertar(ref clsBeEdificio oBeEdificio) {
		try {
			string sp = "SpEdificioInsertar";
			
			SqlConnection cnn = new SqlConnection(ConexionDB.stringConnection);
			SqlCommand cmd = new SqlCommand(sp, cnn);

				cmd.CommandType = CommandType.StoredProcedure;

				int rowsAffected = 0;
				cnn.Open();

				cmd.Parameters.Add(new  SqlParameter("@EDIFICIO", oBeEdificio.Edificio));

				rowsAffected = cmd.ExecuteNonQuery();
				cmd.Parameters.Clear();
				cnn.Close();

				return rowsAffected;
			
		}
		catch (Exception ex) {
			throw ex;
		}
	}

	public int Actualizar(ref clsBeEdificio oBeEdificio) {
		try {
			string sp = "SpEdificioActualizar";
			
			SqlConnection cnn = new SqlConnection(ConexionDB.stringConnection);
			SqlCommand cmd = new SqlCommand(sp, cnn);

				cmd.CommandType = CommandType.StoredProcedure;

				int rowsAffected = 0;
				cnn.Open();

				cmd.Parameters.Add(new SqlParameter("@EDIFICIOID", oBeEdificio.EdificioID));
			cmd.Parameters.Add(new  SqlParameter("@EDIFICIO", oBeEdificio.Edificio));
			
			rowsAffected = cmd.ExecuteNonQuery();
			
			return rowsAffected;
			
		}
		catch (Exception ex) {
			throw ex;
		}
	}

	public int Eliminar(ref clsBeEdificio oBeEdificio) {
		try {
			string sp = "SpEdificioEliminar";
			
			SqlConnection cnn = new SqlConnection(ConexionDB.stringConnection);
			SqlCommand cmd = new SqlCommand(sp, cnn);
				cmd.CommandType = CommandType.StoredProcedure;

				int rowsAffected = 0;
				cnn.Open();

				cmd.Parameters.Add(new  SqlParameter("@EDIFICIOID", oBeEdificio.EdificioID));

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
			string sp = "SpEdificioListar";
			
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

	public bool Obtener(ref clsBeEdificio oBeEdificio) {
		try {
			string sp = "SpEdificioObtener";
			
			SqlConnection cnn = new SqlConnection(ConexionDB.stringConnection);
			SqlCommand cmd = new SqlCommand(sp, cnn);
			cmd.CommandType = CommandType.StoredProcedure;
			
			SqlDataAdapter dad = new SqlDataAdapter(cmd);
			dad.SelectCommand.Parameters.Add(new  SqlParameter("@EDIFICIOID", oBeEdificio.EdificioID));
			
			DataTable dt = new DataTable();
			dad.Fill(dt);
			
			if ((dt.Rows.Count == 1)) {
					Cargar(ref oBeEdificio, dt.Rows[0]);
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

