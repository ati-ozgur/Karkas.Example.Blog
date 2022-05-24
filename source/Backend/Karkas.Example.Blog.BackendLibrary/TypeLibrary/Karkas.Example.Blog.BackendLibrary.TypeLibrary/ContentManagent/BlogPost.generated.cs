using System;
using System.Data;
using System.Text;
using System.Configuration;
using System.Diagnostics;
using System.Xml.Serialization;
using System.Collections.Generic;
using Karkas.Core.TypeLibrary;
using System.ComponentModel.DataAnnotations;

namespace Karkas.Example.Blog.BackendLibrary.TypeLibrary.ContentManagent
{
	[Serializable]
	[DebuggerDisplay("BlogPostKey = {BlogPostKey}UsersKey = {UsersKey}BlogTypeNo = {BlogTypeNo}")]
	public partial class 	BlogPost: BaseTypeLibrary
	{
		private Guid blogPostKey;
		private string postText;
		private string blogTitle;
		private DateTime dateCreated;
		private Guid usersKey;
		private int blogTypeNo;

		[Key]
		[Required]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public Guid BlogPostKey
		{
			[DebuggerStepThrough]
			get
			{
				return blogPostKey;
			}
			[DebuggerStepThrough]
			set
			{
				if ((this.RowState == DataRowState.Unchanged) && (blogPostKey!= value))
				{
					this.RowState = DataRowState.Modified;
				}
				blogPostKey = value;
			}
		}

		[Required]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public string PostText
		{
			[DebuggerStepThrough]
			get
			{
				return postText;
			}
			[DebuggerStepThrough]
			set
			{
				if ((this.RowState == DataRowState.Unchanged) && (postText!= value))
				{
					this.RowState = DataRowState.Modified;
				}
				postText = value;
			}
		}

		[StringLength(100)]
		[Required]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public string BlogTitle
		{
			[DebuggerStepThrough]
			get
			{
				return blogTitle;
			}
			[DebuggerStepThrough]
			set
			{
				if ((this.RowState == DataRowState.Unchanged) && (blogTitle!= value))
				{
					this.RowState = DataRowState.Modified;
				}
				blogTitle = value;
			}
		}

		[Required]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public DateTime DateCreated
		{
			[DebuggerStepThrough]
			get
			{
				return dateCreated;
			}
			[DebuggerStepThrough]
			set
			{
				if ((this.RowState == DataRowState.Unchanged) && (dateCreated!= value))
				{
					this.RowState = DataRowState.Modified;
				}
				dateCreated = value;
			}
		}

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

		public BlogPost ShallowCopy()
		{
			BlogPost obj = new BlogPost();
			obj.blogPostKey = blogPostKey;
			obj.postText = postText;
			obj.blogTitle = blogTitle;
			obj.dateCreated = dateCreated;
			obj.usersKey = usersKey;
			obj.blogTypeNo = blogTypeNo;
			return obj;
		}
		
		public class PropertyIsimleri
		{
			public const string BlogPostKey = "BlogPostKey";
			public const string PostText = "PostText";
			public const string BlogTitle = "BlogTitle";
			public const string DateCreated = "DateCreated";
			public const string UsersKey = "UsersKey";
			public const string BlogTypeNo = "BlogTypeNo";
		}

	}
}
