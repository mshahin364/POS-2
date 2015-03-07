//
// Class	:	BDProductCollection.cs
// Author	:  	Ignyte Software © 2011 (DLG 2.0.9.0)
// Date		:	3/7/2015 2:37:25 PM
//

using System.Runtime.Serialization;
using System.Collections.Generic;
using POS.DataLayer;

namespace POS.BusinessLayer
{
	[CollectionDataContract(Namespace = "POS.BusinessLayer")]
	public class BDProductCollection : List<BDProduct>
	{
	}
}
			
