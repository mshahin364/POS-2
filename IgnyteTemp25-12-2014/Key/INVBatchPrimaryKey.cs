//
// Class	:	INVBatchPrimaryKey.cs
// Author	:  	Ignyte Software © 2011 (DLG 2.0.9.0)
// Date		:	12/26/2014 2:46:05 AM
//

using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.Specialized;

namespace DAPOS
{
	public class INVBatchPrimaryKey
	{

	#region Class Level Variables
			private int?           	_batchIDNonDefault       	= null;
	#endregion

	#region Constants

	#endregion

	#region Constructors / Destructors

		/// <summary>
		/// Constructor setting values for all fields
		/// </summary>
		public INVBatchPrimaryKey(int? batchID) 
		{
	
			
			this._batchIDNonDefault = batchID;

		}

		#endregion

	#region Properties

		/// <summary>
		/// This property is mapped to the "BatchID" field.  Mandatory.
		/// </summary>
		public int? BatchID
		{
			get 
			{ 
				return _batchIDNonDefault;
			}
			set 
			{
			
				_batchIDNonDefault = value; 
			}
		}

		#endregion

	#region Methods (Public)

		/// <summary>
		/// Method to get the list of fields and their values
		/// </summary>
		///
		/// <returns>Name value collection containing the fields and the values</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			12/26/2014 2:46:05 AM				Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public NameValueCollection GetKeysAndValues() 
		{
			NameValueCollection nvc=new NameValueCollection();
			
			nvc.Add("BatchID",_batchIDNonDefault.ToString());
			return nvc;
			
		}

		#endregion	
		
	#region Methods (Private)

	#endregion

	}
}
