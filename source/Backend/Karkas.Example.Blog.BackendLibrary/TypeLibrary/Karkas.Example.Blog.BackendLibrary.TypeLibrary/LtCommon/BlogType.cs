using System;
using System.Data;
using System.Text;
using System.Configuration;
using System.Diagnostics;
using System.Xml.Serialization;
using System.Collections.Generic;
using Karkas.Core.TypeLibrary;
using System.ComponentModel.DataAnnotations;

namespace Karkas.Example.Blog.BackendLibrary.TypeLibrary.LtCommon
{
	[MetadataType(typeof(BlogTypeValidation))]
	public partial class 	BlogType
	{
	}
	public class 	BlogTypeValidation
	{
	}
}
