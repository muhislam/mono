//
// System.Data.IDbDataParameter.cs
//
// Author:
//   Christopher Podurgiel (cpodurgiel@msn.com)
//
// (C) Chris Podurgiel
//

using System;

namespace System.Data
{
	/// <summary>
	/// Used by the Visual Basic .NET Data Designers to represent a parameter to a Command object, and optionally, its mapping to DataSet columns.
	/// </summary>
	public interface IDbDataParameter : IDataParameter
	{
		byte Precision{get; set;}

		byte Scale{get; set;}

		int Size{get; set;}
	}	
}