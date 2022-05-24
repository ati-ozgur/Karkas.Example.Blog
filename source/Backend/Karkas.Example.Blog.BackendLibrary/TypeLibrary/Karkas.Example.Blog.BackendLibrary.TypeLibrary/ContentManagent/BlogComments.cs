using System;
using System.Data;
using System.Text;
using System.Configuration;
using System.Diagnostics;
using System.Xml.Serialization;
using System.Collections.Generic;
using Karkas.Core.TypeLibrary;
using System.ComponentModel.DataAnnotations;

namespace Karkas.Example.Blog.BackendLibrary.TypeLibrary.ContentManagent
{
	[MetadataType(typeof(BlogCommentsValidation))]
	public partial class 	BlogComments
	{
	}
	public class 	BlogCommentsValidation
	{
	}
}
