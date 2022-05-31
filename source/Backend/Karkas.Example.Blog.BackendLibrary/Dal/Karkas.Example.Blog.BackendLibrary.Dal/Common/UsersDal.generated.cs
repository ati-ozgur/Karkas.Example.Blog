
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
using Karkas.Example.Blog.BackendLibrary.TypeLibrary.Common;


namespace Karkas.Example.Blog.BackendLibrary.Dal.Common
{
public partial class UsersDal : BaseDalSqlServer<Users, AdoTemplateSqlServer, ParameterBuilderSqlServer>
{
	
	public override string DatabaseName
	{
		get
		{
			return "Blog";
		}
	}
	protected override void setIdentityColumnValue(Users pTypeLibrary,long pIdentityKolonValue)
	{
	}
	protected override string SelectCountString
	{
		get
		{
			return @"SELECT COUNT(*) FROM COMMON.USERS";
		}
	}
	protected override string SelectString
	{
		get 
		{
			return @"SELECT UsersKey,UserName,email,UsersTypeNo FROM COMMON.USERS";
		}
	}
	protected override string DeleteString
	{
		get 
		{
			return @"DELETE   FROM COMMON.USERS WHERE UsersKey = @UsersKey ";
		}
	}
	protected override string UpdateString
	{
		get 
		{
			return @"UPDATE COMMON.USERS
			 SET 
			UserName = @UserName
,email = @email
,UsersTypeNo = @UsersTypeNo
			
			WHERE 
			 UsersKey = @UsersKey
 ";
		}
	}
	protected override string InsertString
	{
		get 
		{
			return @"INSERT INTO COMMON.USERS 
			 (UsersKey,UserName,email,UsersTypeNo) 
			 VALUES 
						(@UsersKey,@UserName,@email,@UsersTypeNo)";
		}
	}
	public Users QueryByUsersKey(Guid pUsersKey )
	{
		List<Users> liste = new List<Users>();
		ExecuteQuery(liste,String.Format(" UsersKey = '{0}'",pUsersKey));		
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
			return "UsersKey";
		}
	}
	
	public virtual void Delete(Guid UsersKey)
	{
		Users satir = new Users();
		satir.UsersKey = UsersKey;
		base.Delete(satir);
	}
	protected override void ProcessRow(IDataReader dr, Users satir)
	{
		satir.UsersKey = dr.GetGuid(0);
		satir.UserName = dr.GetString(1);
		satir.Email = dr.GetString(2);
		satir.UsersTypeNo = dr.GetInt32(3);
	}
	protected override void InsertCommandParametersAdd(DbCommand cmd, Users satir)
	{
		ParameterBuilderSqlServer builder = (ParameterBuilderSqlServer)Template.getParameterBuilder();
		builder.Command = cmd;
		builder.AddParameter("@UsersKey",SqlDbType.UniqueIdentifier, satir.UsersKey);
		builder.AddParameter("@UserName",SqlDbType.VarChar, satir.UserName,100);
		builder.AddParameter("@email",SqlDbType.VarChar, satir.Email,100);
		builder.AddParameter("@UsersTypeNo",SqlDbType.Int, satir.UsersTypeNo);
	}
	protected override void UpdateCommandParametersAdd(DbCommand cmd, 	Users	 satir)
	{
		ParameterBuilderSqlServer builder = (ParameterBuilderSqlServer)Template.getParameterBuilder();
		builder.Command = cmd;
		builder.AddParameter("@UsersKey",SqlDbType.UniqueIdentifier, satir.UsersKey);
		builder.AddParameter("@UserName",SqlDbType.VarChar, satir.UserName,100);
		builder.AddParameter("@email",SqlDbType.VarChar, satir.Email,100);
		builder.AddParameter("@UsersTypeNo",SqlDbType.Int, satir.UsersTypeNo);
	}
	protected override void DeleteCommandParametersAdd(DbCommand cmd, 	Users	 satir)
	{
		ParameterBuilderSqlServer builder = (ParameterBuilderSqlServer)Template.getParameterBuilder();
		builder.Command = cmd;
		builder.AddParameter("@UsersKey",SqlDbType.UniqueIdentifier, satir.UsersKey);
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
