
using System;
using System.Collections.Generic;
using System.Data;
using Karkas.Core.Data.SqlServer;
using System.Data.SqlClient;
using System.Text;
using Karkas.Core.DataUtil;
using Karkas.Core.DataUtil.BaseClasses;
using Karkas.Example.Blog.BackendLibrary.TypeLibrary;
using Karkas.Example.Blog.BackendLibrary.TypeLibrary.LtCommon;
using Karkas.Example.Blog.BackendLibrary.Dal.LtCommon;


namespace Karkas.Example.Blog.BackendLibrary.Bs.LtCommon
{
	public partial class UsersTypeBs : BaseBs<UsersType, UsersTypeDal,  AdoTemplateSqlServer,ParameterBuilderSqlServer>
	{
	public override string DatabaseName
	{
		get
		{
			return "Blog";
		}
	}
	public void Delete(int pUsersTypeNo)
	{
		dal.Delete( pUsersTypeNo);
	}
	public UsersType QueryByUsersTypeNo(int pUsersTypeNo)
	{
		return dal.QueryByUsersTypeNo(pUsersTypeNo);
	}
}
}
