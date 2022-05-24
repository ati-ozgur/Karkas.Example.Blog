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
	[DebuggerDisplay("BlogTypeNo = {BlogTypeNo}")]
	public partial class 	BlogType: BaseTypeLibrary
	{
		private int blogTypeNo;
		private string blogTypeName;

		[Key]
		[Required]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public int BlogTypeNo
		{
			[DebuggerStepThrough]
			get
			{
				return blogTypeNo;
			}
			[DebuggerStepThrough]
			set
			{
				if ((this.RowState == DataRowState.Unchanged) && (blogTypeNo!= value))
				{
					this.RowState = DataRowState.Modified;
				}
				blogTypeNo = value;
			}
		}

		[StringLength(100)]
		[Required]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public string BlogTypeName
		{
			[DebuggerStepThrough]
			get
			{
				return blogTypeName;
			}
			[DebuggerStepThrough]
			set
			{
				if ((this.RowState == DataRowState.Unchanged) && (blogTypeName!= value))
				{
					this.RowState = DataRowState.Modified;
				}
				blogTypeName = value;
			}
		}

		public BlogType ShallowCopy()
		{
			BlogType obj = new BlogType();
			obj.blogTypeNo = blogTypeNo;
			obj.blogTypeName = blogTypeName;
			return obj;
		}
		
		public class PropertyIsimleri
		{
			public const string BlogTypeNo = "BlogTypeNo";
			public const string BlogTypeName = "BlogTypeName";
		}

	}
}
