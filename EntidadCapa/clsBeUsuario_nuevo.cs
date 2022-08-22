using System.Data.SqlClient;
using System.Windows;
using System;
namespace EntidadCapa
{
	public class clsBeUsuario_nuevo : ICloneable {

		private int mUserID = 0;
		private string mNombre = "";
		private string mApellido = "";
		private DateTime mFecha_de_nacimiento = DateTime.Now;
		private string mCorreo = "";
		private string mPass = "";
		private string mRole = "";

		public int UserID {
			get {
				return mUserID;
			}
			set {
				mUserID = value;
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

		public DateTime Fecha_de_nacimiento {
			get {
				return mFecha_de_nacimiento;
			}
			set {
				mFecha_de_nacimiento = value;
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

		public string Pass {
			get {
				return mPass;
			}
			set {
				mPass = value;
			}
		}

		public string Role {
			get {
				return mRole;
			}
			set {
				mRole = value;
			}
		}

		public clsBeUsuario_nuevo() {
		}

		public clsBeUsuario_nuevo(ref int UserID, string Nombre, string Apellido, DateTime Fecha_de_nacimiento, string Correo, string pass, string Role)
		{ 
		mUserID = UserID;
			mNombre = Nombre;
			mApellido = Apellido;
			mFecha_de_nacimiento = Fecha_de_nacimiento;
			mCorreo = Correo;
			mPass = Pass;
			mRole = Role;
		}

		public object Clone() {
			return base.MemberwiseClone();
		}

	}
}