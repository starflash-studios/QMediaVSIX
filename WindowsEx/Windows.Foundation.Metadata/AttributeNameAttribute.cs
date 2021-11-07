#region Copyright (C) 2017-2021  Starflash Studios
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License (Version 3.0)
// as published by the Free Software Foundation.
// 
// More information can be found here: https://www.gnu.org/licenses/gpl-3.0.en.html
#endregion

#region Using Directives

using System.Runtime.CompilerServices;

#endregion

namespace Windows.Foundation.Metadata {
  /// <summary>Indicates the name of the attribute</summary>
  [ContractVersion(typeof (FoundationContract), 262144)]
  [AttributeUsage(AttributeTargets.RuntimeClass)]
  public sealed class AttributeNameAttribute : Attribute {
    /// <summary>Creates and initialises a new instance of the attribute.</summary>
    /// <param name="A_0">One or more of the enumeration values.</param>
    [MethodImpl]
    public extern AttributeNameAttribute( string A_0 );
  }
}