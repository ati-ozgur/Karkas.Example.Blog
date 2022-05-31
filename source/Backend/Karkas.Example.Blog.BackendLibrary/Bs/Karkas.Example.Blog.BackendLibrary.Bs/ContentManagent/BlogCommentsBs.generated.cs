
using System;
using System.Collections.Generic;
using System.Data;
using Karkas.Core.Data.SqlServer;
using System.Data.SqlClient;
using System.Text;
using Karkas.Core.DataUtil;
using Karkas.Core.DataUtil.BaseClasses;
using Karkas.Example.Blog.BackendLibrary.TypeLibrary;
using Karkas.Example.Blog.BackendLibrary.TypeLibrary.ContentManagent;
using Karkas.Example.Blog.BackendLibrary.Dal.ContentManagent;


namespace Karkas.Example.Blog.BackendLibrary.Bs.ContentManagent
{
	public partial class BlogCommentsBs : BaseBs<BlogComments, BlogCommentsDal,  AdoTemplateSqlServer,ParameterBuilderSqlServer>
	{
	public override string DatabaseName
	{
		get
		{
			return "Blog";
		}
	}
	public void Delete(Guid pBlogCommentsKey)
	{
		dal.Delete( pBlogCommentsKey);
	}
	public BlogComments QueryByBlogCommentsKey(Guid pBlogCommentsKey)
	{
		return dal.QueryByBlogCommentsKey(pBlogCommentsKey);
	}
}
}
