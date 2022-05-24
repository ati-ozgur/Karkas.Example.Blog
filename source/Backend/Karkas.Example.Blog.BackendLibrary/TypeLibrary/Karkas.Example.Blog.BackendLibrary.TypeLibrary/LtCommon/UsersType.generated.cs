using System;
using System.Data;
using System.Text;
using System.Configuration;
using System.Diagnostics;
using System.Xml.Serialization;
using System.Collections.Generic;
using Karkas.Core.TypeLibrary;
using System.ComponentModel.DataAnnotations;

namespace Karkas.Example.Blog.BackendLibrary.TypeLibrary.LtCommon
{
	[Serializable]
	[DebuggerDisplay("UsersTypeNo = {UsersTypeNo}")]
	public partial class 	UsersType: BaseTypeLibrary
	{
		private int usersTypeNo;
		private string typeName;

		[Key]
		[Required]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public int UsersTypeNo
		{
			[DebuggerStepThrough]
			get
			{
				return usersTypeNo;
			}
			[DebuggerStepThrough]
			set
			{
				if ((this.RowState == DataRowState.Unchanged) && (usersTypeNo!= value))
				{
					this.RowState = DataRowState.Modified;
				}
				usersTypeNo = value;
			}
		}

		[StringLength(100)]
		[Required]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public string TypeName
		{
			[DebuggerStepThrough]
			get
			{
				return typeName;
			}
			[DebuggerStepThrough]
			set
			{
				if ((this.RowState == DataRowState.Unchanged) && (typeName!= value))
				{
					this.RowState = DataRowState.Modified;
				}
				typeName = value;
			}
		}

		public UsersType ShallowCopy()
		{
			UsersType obj = new UsersType();
			obj.usersTypeNo = usersTypeNo;
			obj.typeName = typeName;
			return obj;
		}
		
		public class PropertyIsimleri
		{
			public const string UsersTypeNo = "UsersTypeNo";
			public const string TypeName = "TypeName";
		}

	}
}
