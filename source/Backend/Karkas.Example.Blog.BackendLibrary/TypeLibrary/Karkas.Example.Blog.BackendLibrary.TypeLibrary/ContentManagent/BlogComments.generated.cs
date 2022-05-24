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
	[DebuggerDisplay("BlogCommentsKey = {BlogCommentsKey}BlogPostKey = {BlogPostKey}UsersKey = {UsersKey}")]
	public partial class 	BlogComments: BaseTypeLibrary
	{
		private Guid blogCommentsKey;
		private Guid blogPostKey;
		private Guid usersKey;
		private string commentTitle;
		private string commentText;
		private DateTime dateCreated;

		[Key]
		[Required]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public Guid BlogCommentsKey
		{
			[DebuggerStepThrough]
			get
			{
				return blogCommentsKey;
			}
			[DebuggerStepThrough]
			set
			{
				if ((this.RowState == DataRowState.Unchanged) && (blogCommentsKey!= value))
				{
					this.RowState = DataRowState.Modified;
				}
				blogCommentsKey = value;
			}
		}

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
		public string CommentTitle
		{
			[DebuggerStepThrough]
			get
			{
				return commentTitle;
			}
			[DebuggerStepThrough]
			set
			{
				if ((this.RowState == DataRowState.Unchanged) && (commentTitle!= value))
				{
					this.RowState = DataRowState.Modified;
				}
				commentTitle = value;
			}
		}

		[Required]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public string CommentText
		{
			[DebuggerStepThrough]
			get
			{
				return commentText;
			}
			[DebuggerStepThrough]
			set
			{
				if ((this.RowState == DataRowState.Unchanged) && (commentText!= value))
				{
					this.RowState = DataRowState.Modified;
				}
				commentText = value;
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

		public BlogComments ShallowCopy()
		{
			BlogComments obj = new BlogComments();
			obj.blogCommentsKey = blogCommentsKey;
			obj.blogPostKey = blogPostKey;
			obj.usersKey = usersKey;
			obj.commentTitle = commentTitle;
			obj.commentText = commentText;
			obj.dateCreated = dateCreated;
			return obj;
		}
		
		public class PropertyIsimleri
		{
			public const string BlogCommentsKey = "BlogCommentsKey";
			public const string BlogPostKey = "BlogPostKey";
			public const string UsersKey = "UsersKey";
			public const string CommentTitle = "CommentTitle";
			public const string CommentText = "CommentText";
			public const string DateCreated = "DateCreated";
		}

	}
}
