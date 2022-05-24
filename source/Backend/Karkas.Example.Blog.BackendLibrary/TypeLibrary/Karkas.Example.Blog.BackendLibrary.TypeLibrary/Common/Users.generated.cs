using System;
using System.Data;
using System.Text;
using System.Configuration;
using System.Diagnostics;
using System.Xml.Serialization;
using System.Collections.Generic;
using Karkas.Core.TypeLibrary;
using System.ComponentModel.DataAnnotations;

namespace Karkas.Example.Blog.BackendLibrary.TypeLibrary.Common
{
	[Serializable]
	[DebuggerDisplay("UsersKey = {UsersKey}UsersTypeNo = {UsersTypeNo}")]
	public partial class 	Users: BaseTypeLibrary
	{
		private Guid usersKey;
		private string userName;
		private string email;
		private int usersTypeNo;

		[Key]
		[Required]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public Guid UsersKey
		{
			[DebuggerStepThrough]
			get
			{
				return usersKey;
			}
			[DebuggerStepThrough]
			set
			{
				if ((this.RowState == DataRowState.Unchanged) && (usersKey!= value))
				{
					this.RowState = DataRowState.Modified;
				}
				usersKey = value;
			}
		}

		[StringLength(100)]
		[Required]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public string UserName
		{
			[DebuggerStepThrough]
			get
			{
				return userName;
			}
			[DebuggerStepThrough]
			set
			{
				if ((this.RowState == DataRowState.Unchanged) && (userName!= value))
				{
					this.RowState = DataRowState.Modified;
				}
				userName = value;
			}
		}

		[StringLength(100)]
		[Required]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public string Email
		{
			[DebuggerStepThrough]
			get
			{
				return email;
			}
			[DebuggerStepThrough]
			set
			{
				if ((this.RowState == DataRowState.Unchanged) && (email!= value))
				{
					this.RowState = DataRowState.Modified;
				}
				email = value;
			}
		}

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

		public Users ShallowCopy()
		{
			Users obj = new Users();
			obj.usersKey = usersKey;
			obj.userName = userName;
			obj.email = email;
			obj.usersTypeNo = usersTypeNo;
			return obj;
		}
		
		public class PropertyIsimleri
		{
			public const string UsersKey = "UsersKey";
			public const string UserName = "UserName";
			public const string Email = "email";
			public const string UsersTypeNo = "UsersTypeNo";
		}

	}
}
