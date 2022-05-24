
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
	public partial class BlogPostBs : BaseBs<BlogPost, BlogPostDal,  AdoTemplateSqlServer,ParameterBuilderSqlServer>
	{
	public override string DatabaseName
	{
		get
		{
			return "Blog";
		}
	}
	public void Delete(Guid pBlogPostKey)
	{
		dal.Delete( pBlogPostKey);
	}
	public BlogPost SorgulaBlogPostKeyIle(Guid p1)
	{
		return dal.SorgulaBlogPostKeyIle(p1);
	}
}
}
