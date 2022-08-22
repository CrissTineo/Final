using System.Data.SqlClient;
using System.Windows;
using System;
namespace EntidadCapa
{
	public class clsBeAula : ICloneable
	{

		private int mAulaID = 0;
		private string mAula = "";

		public int AulaID
		{
			get
			{
				return mAulaID;
			}
			set
			{
				mAulaID = value;
			}
		}

		public string Aula
		{
			get
			{
				return mAula;
			}
			set
			{
				mAula = value;
			}
		}

		public clsBeAula()
		{
		}

		public clsBeAula(ref int AulaID, string Aula)
		{
		
		mAulaID = AulaID;
			mAula = Aula;
		}

		public object Clone()
		{
			return base.MemberwiseClone();
		}

	}

}

