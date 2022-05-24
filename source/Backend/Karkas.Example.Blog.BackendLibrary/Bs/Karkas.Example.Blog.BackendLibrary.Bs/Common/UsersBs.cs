
using System;
using System.Collections.Generic;
using System.Data;
using Karkas.Core.Data.SqlServer;
using System.Data.SqlClient;
using System.Text;
using Karkas.Core.DataUtil;
using Karkas.Core.DataUtil.BaseClasses;
using Karkas.Example.Blog.BackendLibrary.TypeLibrary;
using Karkas.Example.Blog.BackendLibrary.TypeLibrary.Common;
using Karkas.Example.Blog.BackendLibrary.Dal.Common;


namespace Karkas.Example.Blog.BackendLibrary.Bs.Common
{
public partial class UsersBs : BaseBs<Users, UsersDal,  AdoTemplateSqlServer,ParameterBuilderSqlServer>
{
}
}
