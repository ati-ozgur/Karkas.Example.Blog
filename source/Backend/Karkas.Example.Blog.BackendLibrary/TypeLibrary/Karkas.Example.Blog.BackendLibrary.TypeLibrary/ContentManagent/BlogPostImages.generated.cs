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
	[DebuggerDisplay("BlogPostImagesKey = {BlogPostImagesKey}BlogPostKey = {BlogPostKey}")]
	public partial class 	BlogPostImages: BaseTypeLibrary
	{
		private Guid blogPostImagesKey;
		private Guid blogPostKey;
		private byte[] blogPostImage;

		[Key]
		[Required]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public Guid BlogPostImagesKey
		{
			[DebuggerStepThrough]
			get
			{
				return blogPostImagesKey;
			}
			[DebuggerStepThrough]
			set
			{
				if ((this.RowState == DataRowState.Unchanged) && (blogPostImagesKey!= value))
				{
					this.RowState = DataRowState.Modified;
				}
				blogPostImagesKey = value;
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
		public byte[] BlogPostImage
		{
			[DebuggerStepThrough]
			get
			{
				return blogPostImage;
			}
			[DebuggerStepThrough]
			set
			{
				if ((this.RowState == DataRowState.Unchanged) && (blogPostImage!= value))
				{
					this.RowState = DataRowState.Modified;
				}
				blogPostImage = value;
			}
		}

		public BlogPostImages ShallowCopy()
		{
			BlogPostImages obj = new BlogPostImages();
			obj.blogPostImagesKey = blogPostImagesKey;
			obj.blogPostKey = blogPostKey;
			obj.blogPostImage = blogPostImage;
			return obj;
		}
		
		public class PropertyIsimleri
		{
			public const string BlogPostImagesKey = "BlogPostImagesKey";
			public const string BlogPostKey = "BlogPostKey";
			public const string BlogPostImage = "BlogPostImage";
		}

	}
}
