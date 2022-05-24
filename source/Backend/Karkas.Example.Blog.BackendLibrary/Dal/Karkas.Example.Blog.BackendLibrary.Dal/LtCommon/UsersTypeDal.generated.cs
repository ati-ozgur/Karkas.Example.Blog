
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
public partial class UsersTypeDal : BaseDalSqlServer<UsersType, AdoTemplateSqlServer, ParameterBuilderSqlServer>
{
	
	public override string DatabaseName
	{
		get
		{
			return "Blog";
		}
	}
	protected override void setIdentityColumnValue(UsersType pTypeLibrary,long pIdentityKolonValue)
	{
	}
	protected override string SelectCountString
	{
		get
		{
			return @"SELECT COUNT(*) FROM LT_COMMON.USERS_TYPE";
		}
	}
	protected override string SelectString
	{
		get 
		{
			return @"SELECT UsersTypeNo,TypeName FROM LT_COMMON.USERS_TYPE";
		}
	}
	protected override string DeleteString
	{
		get 
		{
			return @"DELETE   FROM LT_COMMON.USERS_TYPE WHERE UsersTypeNo = @UsersTypeNo ";
		}
	}
	protected override string UpdateString
	{
		get 
		{
			return @"UPDATE LT_COMMON.USERS_TYPE
			 SET 
			TypeName = @TypeName
			
			WHERE 
			 UsersTypeNo = @UsersTypeNo
 ";
		}
	}
	protected override string InsertString
	{
		get 
		{
			return @"INSERT INTO LT_COMMON.USERS_TYPE 
			 (UsersTypeNo,TypeName) 
			 VALUES 
						(@UsersTypeNo,@TypeName)";
		}
	}
	public UsersType SorgulaUsersTypeNoIle(int p1)
	{
		List<UsersType> liste = new List<UsersType>();
		ExecuteQuery(liste,String.Format(" UsersTypeNo = '{0}'", p1));		
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
			return "UsersTypeNo";
		}
	}
	
	public virtual void Delete(int UsersTypeNo)
	{
		UsersType satir = new UsersType();
		satir.UsersTypeNo = UsersTypeNo;
		base.Delete(satir);
	}
	protected override void ProcessRow(IDataReader dr, UsersType satir)
	{
		satir.UsersTypeNo = dr.GetInt32(0);
		satir.TypeName = dr.GetString(1);
	}
	protected override void InsertCommandParametersAdd(DbCommand cmd, UsersType satir)
	{
		ParameterBuilderSqlServer builder = (ParameterBuilderSqlServer)Template.getParameterBuilder();
		builder.Command = cmd;
		builder.AddParameter("@UsersTypeNo",SqlDbType.Int, satir.UsersTypeNo);
		builder.AddParameter("@TypeName",SqlDbType.VarChar, satir.TypeName,100);
	}
	protected override void UpdateCommandParametersAdd(DbCommand cmd, 	UsersType	 satir)
	{
		ParameterBuilderSqlServer builder = (ParameterBuilderSqlServer)Template.getParameterBuilder();
		builder.Command = cmd;
		builder.AddParameter("@UsersTypeNo",SqlDbType.Int, satir.UsersTypeNo);
		builder.AddParameter("@TypeName",SqlDbType.VarChar, satir.TypeName,100);
	}
	protected override void DeleteCommandParametersAdd(DbCommand cmd, 	UsersType	 satir)
	{
		ParameterBuilderSqlServer builder = (ParameterBuilderSqlServer)Template.getParameterBuilder();
		builder.Command = cmd;
		builder.AddParameter("@UsersTypeNo",SqlDbType.Int, satir.UsersTypeNo);
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
