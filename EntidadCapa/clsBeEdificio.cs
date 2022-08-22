using System.Data.SqlClient;
using System.Windows;
using System;
namespace EntidadCapa
{

	public class clsBeEdificio : ICloneable {

		private int mEdificioID = 0;
		private string mEdificio = "";

		public int EdificioID {
			get {
				return mEdificioID;
			}
			set {
				mEdificioID = value;
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

		public clsBeEdificio() {
		}

		public clsBeEdificio(ref int EdificioID, string Edificio)
		{
		mEdificioID = EdificioID;
			mEdificio = Edificio;
		}

		public object Clone() {
			return base.MemberwiseClone();
		}

	}
}