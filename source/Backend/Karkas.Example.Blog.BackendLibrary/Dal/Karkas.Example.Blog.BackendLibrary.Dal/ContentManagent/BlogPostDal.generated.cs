
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
public partial class BlogPostDal : BaseDalSqlServer<BlogPost, AdoTemplateSqlServer, ParameterBuilderSqlServer>
{
	
	public override string DatabaseName
	{
		get
		{
			return "Blog";
		}
	}
	protected override void setIdentityColumnValue(BlogPost pTypeLibrary,long pIdentityKolonValue)
	{
	}
	protected override string SelectCountString
	{
		get
		{
			return @"SELECT COUNT(*) FROM CONTENT_MANAGENT.BLOG_POST";
		}
	}
	protected override string SelectString
	{
		get 
		{
			return @"SELECT BlogPostKey,PostText,BlogTitle,DateCreated,UsersKey,BlogTypeNo FROM CONTENT_MANAGENT.BLOG_POST";
		}
	}
	protected override string DeleteString
	{
		get 
		{
			return @"DELETE   FROM CONTENT_MANAGENT.BLOG_POST WHERE BlogPostKey = @BlogPostKey ";
		}
	}
	protected override string UpdateString
	{
		get 
		{
			return @"UPDATE CONTENT_MANAGENT.BLOG_POST
			 SET 
			PostText = @PostText
,BlogTitle = @BlogTitle
,DateCreated = @DateCreated
,UsersKey = @UsersKey
,BlogTypeNo = @BlogTypeNo
			
			WHERE 
			 BlogPostKey = @BlogPostKey
 ";
		}
	}
	protected override string InsertString
	{
		get 
		{
			return @"INSERT INTO CONTENT_MANAGENT.BLOG_POST 
			 (BlogPostKey,PostText,BlogTitle,DateCreated,UsersKey,BlogTypeNo) 
			 VALUES 
						(@BlogPostKey,@PostText,@BlogTitle,@DateCreated,@UsersKey,@BlogTypeNo)";
		}
	}
	public BlogPost SorgulaBlogPostKeyIle(Guid p1)
	{
		List<BlogPost> liste = new List<BlogPost>();
		ExecuteQuery(liste,String.Format(" BlogPostKey = '{0}'", p1));		
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
			return "BlogPostKey";
		}
	}
	
	public virtual void Delete(Guid BlogPostKey)
	{
		BlogPost satir = new BlogPost();
		satir.BlogPostKey = BlogPostKey;
		base.Delete(satir);
	}
	protected override void ProcessRow(IDataReader dr, BlogPost satir)
	{
		satir.BlogPostKey = dr.GetGuid(0);
		satir.PostText = dr.GetString(1);
		satir.BlogTitle = dr.GetString(2);
		satir.DateCreated = dr.GetDateTime(3);
		satir.UsersKey = dr.GetGuid(4);
		satir.BlogTypeNo = dr.GetInt32(5);
	}
	protected override void InsertCommandParametersAdd(DbCommand cmd, BlogPost satir)
	{
		ParameterBuilderSqlServer builder = (ParameterBuilderSqlServer)Template.getParameterBuilder();
		builder.Command = cmd;
		builder.AddParameter("@BlogPostKey",SqlDbType.UniqueIdentifier, satir.BlogPostKey);
		builder.AddParameter("@PostText",SqlDbType.VarChar, satir.PostText,8000);
		builder.AddParameter("@BlogTitle",SqlDbType.VarChar, satir.BlogTitle,100);
		builder.AddParameter("@DateCreated",SqlDbType.DateTime, satir.DateCreated);
		builder.AddParameter("@UsersKey",SqlDbType.UniqueIdentifier, satir.UsersKey);
		builder.AddParameter("@BlogTypeNo",SqlDbType.Int, satir.BlogTypeNo);
	}
	protected override void UpdateCommandParametersAdd(DbCommand cmd, 	BlogPost	 satir)
	{
		ParameterBuilderSqlServer builder = (ParameterBuilderSqlServer)Template.getParameterBuilder();
		builder.Command = cmd;
		builder.AddParameter("@BlogPostKey",SqlDbType.UniqueIdentifier, satir.BlogPostKey);
		builder.AddParameter("@PostText",SqlDbType.VarChar, satir.PostText,8000);
		builder.AddParameter("@BlogTitle",SqlDbType.VarChar, satir.BlogTitle,100);
		builder.AddParameter("@DateCreated",SqlDbType.DateTime, satir.DateCreated);
		builder.AddParameter("@UsersKey",SqlDbType.UniqueIdentifier, satir.UsersKey);
		builder.AddParameter("@BlogTypeNo",SqlDbType.Int, satir.BlogTypeNo);
	}
	protected override void DeleteCommandParametersAdd(DbCommand cmd, 	BlogPost	 satir)
	{
		ParameterBuilderSqlServer builder = (ParameterBuilderSqlServer)Template.getParameterBuilder();
		builder.Command = cmd;
		builder.AddParameter("@BlogPostKey",SqlDbType.UniqueIdentifier, satir.BlogPostKey);
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
