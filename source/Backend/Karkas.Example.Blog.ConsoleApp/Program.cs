

using Karkas.Core.DataUtil;
using Karkas.Example.Blog.BackendLibrary.Dal.LtCommon;
using Karkas.Example.Blog.BackendLibrary.TypeLibrary.LtCommon;
using Microsoft.Data.SqlClient;
using System.Data.Common;

string dbProviderName = "Microsoft.Data.SqlClient";
DbProviderFactories.RegisterFactory(dbProviderName, SqlClientFactory.Instance);
DbProviderFactories.RegisterFactory("System.Data.SqlClient", SqlClientFactory.Instance);

string connectionString = "Data Source=localhost;Initial Catalog=BLOG;Persist Security Info=True;User ID=sa;Password=yourStrong2022Password;Encrypt=False";


ConnectionSingleton.Instance.AddConnection("Blog", dbProviderName, connectionString);



//BlogType bt = new BlogType();
//bt.BlogTypeName = "Science Fiction";
//bt.BlogTypeNo = 1;


//blogTypeDal.Insert(bt);

BlogTypeDal blogTypeDal = new BlogTypeDal();

for (int i = 2; i < 5; i++)
{
    BlogType bt2 = new BlogType();
    bt2.BlogTypeName = "example" + i;
    bt2.BlogTypeNo = i;
    blogTypeDal.Insert(bt2);

}




// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
