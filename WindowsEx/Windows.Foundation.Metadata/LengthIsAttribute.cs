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
  /// <summary>Indicates the number of array elements.</summary>
  [ContractVersion(typeof (FoundationContract), 65536)]
  [AttributeUsage(AttributeTargets.Parameter)]
  public sealed class LengthIsAttribute : Attribute {
    /// <summary>Creates and initialises a new instance of the attribute.</summary>
    /// <param name="IndexLengthParameter">The number of array elements.</param>
    [MethodImpl]
    public extern LengthIsAttribute( int IndexLengthParameter );
  }
}