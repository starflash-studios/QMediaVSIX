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
  /// <summary>Specifies that the type represents an API contract.</summary>
  [ContractVersion(typeof (FoundationContract), 65536)]
  [AttributeUsage(AttributeTargets.Enum)]
  public sealed class ApiContractAttribute : Attribute {
    /// <summary>Creates and initialises a new instance of the attribute.</summary>
    [MethodImpl]
    public extern ApiContractAttribute();
  }
}