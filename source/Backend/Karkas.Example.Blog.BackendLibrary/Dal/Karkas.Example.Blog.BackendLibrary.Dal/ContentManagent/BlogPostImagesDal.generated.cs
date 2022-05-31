
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using Karkas.Core.Data.SqlServer;
using System.Text;
using Karkas.Core.DataUtil;
using Karkas.Core.DataUtil.BaseClasses;
using Karkas.Example.Blog.BackendLibrary.TypeLibrary;
using Karkas.Example.Blog.BackendLibrary.TypeLibrary.ContentManagent;


namespace Karkas.Example.Blog.BackendLibrary.Dal.ContentManagent
{
public partial class BlogPostImagesDal : BaseDalSqlServer<BlogPostImages, AdoTemplateSqlServer, ParameterBuilderSqlServer>
{
	
	public override string DatabaseName
	{
		get
		{
			return "Blog";
		}
	}
	protected override void setIdentityColumnValue(BlogPostImages pTypeLibrary,long pIdentityKolonValue)
	{
	}
	protected override string SelectCountString
	{
		get
		{
			return @"SELECT COUNT(*) FROM CONTENT_MANAGENT.BLOG_POST_IMAGES";
		}
	}
	protected override string SelectString
	{
		get 
		{
			return @"SELECT BlogPostImagesKey,BlogPostKey,BlogPostImage FROM CONTENT_MANAGENT.BLOG_POST_IMAGES";
		}
	}
	protected override string DeleteString
	{
		get 
		{
			return @"DELETE   FROM CONTENT_MANAGENT.BLOG_POST_IMAGES WHERE BlogPostImagesKey = @BlogPostImagesKey ";
		}
	}
	protected override string UpdateString
	{
		get 
		{
			return @"UPDATE CONTENT_MANAGENT.BLOG_POST_IMAGES
			 SET 
			BlogPostKey = @BlogPostKey
,BlogPostImage = @BlogPostImage
			
			WHERE 
			 BlogPostImagesKey = @BlogPostImagesKey
 ";
		}
	}
	protected override string InsertString
	{
		get 
		{
			return @"INSERT INTO CONTENT_MANAGENT.BLOG_POST_IMAGES 
			 (BlogPostImagesKey,BlogPostKey,BlogPostImage) 
			 VALUES 
						(@BlogPostImagesKey,@BlogPostKey,@BlogPostImage)";
		}
	}
	public BlogPostImages QueryByBlogPostImagesKey(Guid pBlogPostImagesKey )
	{
		List<BlogPostImages> liste = new List<BlogPostImages>();
		ExecuteQuery(liste,String.Format(" BlogPostImagesKey = '{0}'",pBlogPostImagesKey));		
		if (liste.Count > 0)
		{
			return liste[0];
		}
		else
		{
			return null;
		}
	}
	
	protected override bool IdentityExists
	{
		get
		{
			return false;
		}
	}
	
	protected override bool IsPkGuid
	{
		get
		{
			return true;
		}
	}
	
	
	public override string PrimaryKey
	{
		get
		{
			return "BlogPostImagesKey";
		}
	}
	
	public virtual void Delete(Guid BlogPostImagesKey)
	{
		BlogPostImages satir = new BlogPostImages();
		satir.BlogPostImagesKey = BlogPostImagesKey;
		base.Delete(satir);
	}
	protected override void ProcessRow(IDataReader dr, BlogPostImages satir)
	{
		satir.BlogPostImagesKey = dr.GetGuid(0);
		satir.BlogPostKey = dr.GetGuid(1);
		satir.BlogPostImage = (Byte[])dr.GetValue(2);
	}
	protected override void InsertCommandParametersAdd(DbCommand cmd, BlogPostImages satir)
	{
		ParameterBuilderSqlServer builder = (ParameterBuilderSqlServer)Template.getParameterBuilder();
		builder.Command = cmd;
		builder.AddParameter("@BlogPostImagesKey",SqlDbType.UniqueIdentifier, satir.BlogPostImagesKey);
		builder.AddParameter("@BlogPostKey",SqlDbType.UniqueIdentifier, satir.BlogPostKey);
		builder.AddParameter("@BlogPostImage",SqlDbType.Image, satir.BlogPostImage);
	}
	protected override void UpdateCommandParametersAdd(DbCommand cmd, 	BlogPostImages	 satir)
	{
		ParameterBuilderSqlServer builder = (ParameterBuilderSqlServer)Template.getParameterBuilder();
		builder.Command = cmd;
		builder.AddParameter("@BlogPostImagesKey",SqlDbType.UniqueIdentifier, satir.BlogPostImagesKey);
		builder.AddParameter("@BlogPostKey",SqlDbType.UniqueIdentifier, satir.BlogPostKey);
		builder.AddParameter("@BlogPostImage",SqlDbType.Image, satir.BlogPostImage);
	}
	protected override void DeleteCommandParametersAdd(DbCommand cmd, 	BlogPostImages	 satir)
	{
		ParameterBuilderSqlServer builder = (ParameterBuilderSqlServer)Template.getParameterBuilder();
		builder.Command = cmd;
		builder.AddParameter("@BlogPostImagesKey",SqlDbType.UniqueIdentifier, satir.BlogPostImagesKey);
	}
	public override string DbProviderName
	{
		get
		{
			return "";
		}
	}
}
}
