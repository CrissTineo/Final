
using System.Data.SqlClient;
using System.Windows;
using System;
namespace EntidadCapa
{


	public class clsBeRegistro_visitas : ICloneable {

		private int mId_registro = 0;
		private string mNombre = "";
		private string mApellido = "";
		private string mCorreo = "";
		private string mCarrera = "";
		private string mCurso = "";
		private string mEdificio = "";
		private string mMotivo = "";
		private DateTime mHora = DateTime.Now;
		private int mEdificioID = 0;
		private int mAulaID = 0;

		public int Id_registro {
			get {
				return mId_registro;
			}
			set {
				mId_registro = value;
			}
		}

		public string Nombre {
			get {
				return mNombre;
			}
			set {
				mNombre = value;
			}
		}

		public string Apellido {
			get {
				return mApellido;
			}
			set {
				mApellido = value;
			}
		}

		public string Correo {
			get {
				return mCorreo;
			}
			set {
				mCorreo = value;
			}
		}

		public string Carrera {
			get {
				return mCarrera;
			}
			set {
				mCarrera = value;
			}
		}

		public string Curso {
			get {
				return mCurso;
			}
			set {
				mCurso = value;
			}
		}

		public string Edificio {
			get {
				return mEdificio;
			}
			set {
				mEdificio = value;
			}
		}

		public string Motivo {
			get {
				return mMotivo;
			}
			set {
				mMotivo = value;
			}
		}

		public DateTime Hora {
			get {
				return mHora;
			}
			set {
				mHora = value;
			}
		}

		public int EdificioID {
			get {
				return mEdificioID;
			}
			set {
				mEdificioID = value;
			}
		}

		public int AulaID {
			get {
				return mAulaID;
			}
			set {
				mAulaID = value;
			}
		}

		public clsBeRegistro_visitas() {
		}

		public clsBeRegistro_visitas(ref int Id_registro, string Nombre, string Apellido, string Correo, string Carrera, string Curso, string Edificio, string Motivo, DateTime Hora, int EdificioID, int AulaID)
		{ 
		mId_registro = Id_registro;
			mNombre = Nombre;
			mApellido = Apellido;
			mCorreo = Correo;
			mCarrera = Carrera;
			mCurso = Curso;
			mEdificio = Edificio;
			mMotivo = Motivo;
			mHora = Hora;
			mEdificioID = EdificioID;
			mAulaID = AulaID;
		}

		public object Clone() {
			return base.MemberwiseClone();
		}

	}
}