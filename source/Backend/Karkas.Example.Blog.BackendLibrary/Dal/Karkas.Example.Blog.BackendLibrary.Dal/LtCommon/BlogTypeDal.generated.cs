
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
using Karkas.Example.Blog.BackendLibrary.TypeLibrary.LtCommon;


namespace Karkas.Example.Blog.BackendLibrary.Dal.LtCommon
{
public partial class BlogTypeDal : BaseDalSqlServer<BlogType, AdoTemplateSqlServer, ParameterBuilderSqlServer>
{
	
	public override string DatabaseName
	{
		get
		{
			return "Blog";
		}
	}
	protected override void setIdentityColumnValue(BlogType pTypeLibrary,long pIdentityKolonValue)
	{
	}
	protected override string SelectCountString
	{
		get
		{
			return @"SELECT COUNT(*) FROM LT_COMMON.BLOG_TYPE";
		}
	}
	protected override string SelectString
	{
		get 
		{
			return @"SELECT BlogTypeNo,BlogTypeName FROM LT_COMMON.BLOG_TYPE";
		}
	}
	protected override string DeleteString
	{
		get 
		{
			return @"DELETE   FROM LT_COMMON.BLOG_TYPE WHERE BlogTypeNo = @BlogTypeNo ";
		}
	}
	protected override string UpdateString
	{
		get 
		{
			return @"UPDATE LT_COMMON.BLOG_TYPE
			 SET 
			BlogTypeName = @BlogTypeName
			
			WHERE 
			 BlogTypeNo = @BlogTypeNo
 ";
		}
	}
	protected override string InsertString
	{
		get 
		{
			return @"INSERT INTO LT_COMMON.BLOG_TYPE 
			 (BlogTypeNo,BlogTypeName) 
			 VALUES 
						(@BlogTypeNo,@BlogTypeName)";
		}
	}
	public BlogType SorgulaBlogTypeNoIle(int p1)
	{
		List<BlogType> liste = new List<BlogType>();
		ExecuteQuery(liste,String.Format(" BlogTypeNo = '{0}'", p1));		
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
			return false;
		}
	}
	
	
	public override string PrimaryKey
	{
		get
		{
			return "BlogTypeNo";
		}
	}
	
	public virtual void Delete(int BlogTypeNo)
	{
		BlogType satir = new BlogType();
		satir.BlogTypeNo = BlogTypeNo;
		base.Delete(satir);
	}
	protected override void ProcessRow(IDataReader dr, BlogType satir)
	{
		satir.BlogTypeNo = dr.GetInt32(0);
		satir.BlogTypeName = dr.GetString(1);
	}
	protected override void InsertCommandParametersAdd(DbCommand cmd, BlogType satir)
	{
		ParameterBuilderSqlServer builder = (ParameterBuilderSqlServer)Template.getParameterBuilder();
		builder.Command = cmd;
		builder.AddParameter("@BlogTypeNo",SqlDbType.Int, satir.BlogTypeNo);
		builder.AddParameter("@BlogTypeName",SqlDbType.VarChar, satir.BlogTypeName,100);
	}
	protected override void UpdateCommandParametersAdd(DbCommand cmd, 	BlogType	 satir)
	{
		ParameterBuilderSqlServer builder = (ParameterBuilderSqlServer)Template.getParameterBuilder();
		builder.Command = cmd;
		builder.AddParameter("@BlogTypeNo",SqlDbType.Int, satir.BlogTypeNo);
		builder.AddParameter("@BlogTypeName",SqlDbType.VarChar, satir.BlogTypeName,100);
	}
	protected override void DeleteCommandParametersAdd(DbCommand cmd, 	BlogType	 satir)
	{
		ParameterBuilderSqlServer builder = (ParameterBuilderSqlServer)Template.getParameterBuilder();
		builder.Command = cmd;
		builder.AddParameter("@BlogTypeNo",SqlDbType.Int, satir.BlogTypeNo);
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
