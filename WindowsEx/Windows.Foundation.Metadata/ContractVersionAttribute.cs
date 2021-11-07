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
  /// <summary>Indicates the version of the API contract.</summary>
  [ContractVersion(typeof (FoundationContract), 65536)]
  [AllowMultiple]
  [AttributeUsage((AttributeTargets) 3967)]
  public sealed class ContractVersionAttribute : Attribute {
    /// <summary>Creates and initialises a new instance of the attribute.</summary>
    /// <param name="Version">The version of the API contract.</param>
    [MethodImpl]
    public extern ContractVersionAttribute( uint Version );

    /// <summary>Creates and initialises a new instance of the attribute.</summary>
    /// <param name="Contract">The type to associate with the API contract.</param>
    /// <param name="Version">The version of the API contract.</param>
    [MethodImpl]
    public extern ContractVersionAttribute( Type Contract, uint Version );

    /// <summary>Creates and initialises a new instance of the attribute.</summary>
    /// <param name="Contract">The type to associate with the API contract.</param>
    /// <param name="Version">The version of the API contract.</param>
    [MethodImpl]
    public extern ContractVersionAttribute( string Contract, uint Version );
  }
}