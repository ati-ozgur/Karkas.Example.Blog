

using Karkas.Core.DataUtil;
using Karkas.Example.Blog.BackendLibrary.Dal.Common;
using Karkas.Example.Blog.BackendLibrary.Dal.ContentManagent;
using Karkas.Example.Blog.BackendLibrary.Dal.LtCommon;
using Karkas.Example.Blog.BackendLibrary.TypeLibrary.Common;
using Karkas.Example.Blog.BackendLibrary.TypeLibrary.ContentManagent;
using Karkas.Example.Blog.BackendLibrary.TypeLibrary.LtCommon;
using Microsoft.Data.SqlClient;
using System.Data.Common;

string dbProviderName = "Microsoft.Data.SqlClient";
DbProviderFactories.RegisterFactory(dbProviderName, SqlClientFactory.Instance);
DbProviderFactories.RegisterFactory("System.Data.SqlClient", SqlClientFactory.Instance);

string connectionString = "Data Source=localhost;Initial Catalog=BLOG;Persist Security Info=True;User ID=sa;Password=yourStrong2022Password;Encrypt=False";


ConnectionSingleton.Instance.AddConnection("Blog", dbProviderName, connectionString);

Guid UsersKey = new Guid("6C21D4CC-6FE7-464D-8968-5D73B08820A6");

Users u1 = new Users();

//// set properties here

u1.UsersKey = UsersKey;
u1.UserName = "Atilla";
u1.Email = "atilla@example.com";
u1.UsersTypeNo = 1;


UsersDal usersDal = new UsersDal();

usersDal.Insert(u1);


BlogPost bp = new BlogPost();
bp.BlogPostKey = Guid.NewGuid();
bp.PostText = "Example text";
bp.BlogTitle = "Title Console";
bp.DateCreated = DateTime.Now;
bp.UsersKey = UsersKey;
bp.BlogTypeNo = 2;

BlogPostDal blogPostDal = new BlogPostDal();
blogPostDal.Insert(bp);



