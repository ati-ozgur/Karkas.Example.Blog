
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
public partial class BlogCommentsDal : BaseDalSqlServer<BlogComments, AdoTemplateSqlServer, ParameterBuilderSqlServer>
{
	
	public override string DatabaseName
	{
		get
		{
			return "Blog";
		}
	}
	protected override void setIdentityColumnValue(BlogComments pTypeLibrary,long pIdentityKolonValue)
	{
	}
	protected override string SelectCountString
	{
		get
		{
			return @"SELECT COUNT(*) FROM CONTENT_MANAGENT.BLOG_COMMENTS";
		}
	}
	protected override string SelectString
	{
		get 
		{
			return @"SELECT BlogCommentsKey,BlogPostKey,UsersKey,CommentTitle,CommentText,DateCreated FROM CONTENT_MANAGENT.BLOG_COMMENTS";
		}
	}
	protected override string DeleteString
	{
		get 
		{
			return @"DELETE   FROM CONTENT_MANAGENT.BLOG_COMMENTS WHERE BlogCommentsKey = @BlogCommentsKey ";
		}
	}
	protected override string UpdateString
	{
		get 
		{
			return @"UPDATE CONTENT_MANAGENT.BLOG_COMMENTS
			 SET 
			BlogPostKey = @BlogPostKey
,UsersKey = @UsersKey
,CommentTitle = @CommentTitle
,CommentText = @CommentText
,DateCreated = @DateCreated
			
			WHERE 
			 BlogCommentsKey = @BlogCommentsKey
 ";
		}
	}
	protected override string InsertString
	{
		get 
		{
			return @"INSERT INTO CONTENT_MANAGENT.BLOG_COMMENTS 
			 (BlogCommentsKey,BlogPostKey,UsersKey,CommentTitle,CommentText,DateCreated) 
			 VALUES 
						(@BlogCommentsKey,@BlogPostKey,@UsersKey,@CommentTitle,@CommentText,@DateCreated)";
		}
	}
	public BlogComments QueryByBlogCommentsKey(Guid pBlogCommentsKey )
	{
		List<BlogComments> liste = new List<BlogComments>();
		ExecuteQuery(liste,String.Format(" BlogCommentsKey = '{0}'",pBlogCommentsKey));		
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
			return "BlogCommentsKey";
		}
	}
	
	public virtual void Delete(Guid BlogCommentsKey)
	{
		BlogComments satir = new BlogComments();
		satir.BlogCommentsKey = BlogCommentsKey;
		base.Delete(satir);
	}
	protected override void ProcessRow(IDataReader dr, BlogComments satir)
	{
		satir.BlogCommentsKey = dr.GetGuid(0);
		satir.BlogPostKey = dr.GetGuid(1);
		satir.UsersKey = dr.GetGuid(2);
		satir.CommentTitle = dr.GetString(3);
		satir.CommentText = dr.GetString(4);
		satir.DateCreated = dr.GetDateTime(5);
	}
	protected override void InsertCommandParametersAdd(DbCommand cmd, BlogComments satir)
	{
		ParameterBuilderSqlServer builder = (ParameterBuilderSqlServer)Template.getParameterBuilder();
		builder.Command = cmd;
		builder.AddParameter("@BlogCommentsKey",SqlDbType.UniqueIdentifier, satir.BlogCommentsKey);
		builder.AddParameter("@BlogPostKey",SqlDbType.UniqueIdentifier, satir.BlogPostKey);
		builder.AddParameter("@UsersKey",SqlDbType.UniqueIdentifier, satir.UsersKey);
		builder.AddParameter("@CommentTitle",SqlDbType.VarChar, satir.CommentTitle,100);
		builder.AddParameter("@CommentText",SqlDbType.VarChar, satir.CommentText,8000);
		builder.AddParameter("@DateCreated",SqlDbType.DateTime, satir.DateCreated);
	}
	protected override void UpdateCommandParametersAdd(DbCommand cmd, 	BlogComments	 satir)
	{
		ParameterBuilderSqlServer builder = (ParameterBuilderSqlServer)Template.getParameterBuilder();
		builder.Command = cmd;
		builder.AddParameter("@BlogCommentsKey",SqlDbType.UniqueIdentifier, satir.BlogCommentsKey);
		builder.AddParameter("@BlogPostKey",SqlDbType.UniqueIdentifier, satir.BlogPostKey);
		builder.AddParameter("@UsersKey",SqlDbType.UniqueIdentifier, satir.UsersKey);
		builder.AddParameter("@CommentTitle",SqlDbType.VarChar, satir.CommentTitle,100);
		builder.AddParameter("@CommentText",SqlDbType.VarChar, satir.CommentText,8000);
		builder.AddParameter("@DateCreated",SqlDbType.DateTime, satir.DateCreated);
	}
	protected override void DeleteCommandParametersAdd(DbCommand cmd, 	BlogComments	 satir)
	{
		ParameterBuilderSqlServer builder = (ParameterBuilderSqlServer)Template.getParameterBuilder();
		builder.Command = cmd;
		builder.AddParameter("@BlogCommentsKey",SqlDbType.UniqueIdentifier, satir.BlogCommentsKey);
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
