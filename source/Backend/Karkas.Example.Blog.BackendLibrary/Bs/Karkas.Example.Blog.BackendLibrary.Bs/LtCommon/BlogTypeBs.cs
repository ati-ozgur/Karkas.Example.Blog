
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
public partial class BlogTypeBs : BaseBs<BlogType, BlogTypeDal,  AdoTemplateSqlServer,ParameterBuilderSqlServer>
{
}
}
