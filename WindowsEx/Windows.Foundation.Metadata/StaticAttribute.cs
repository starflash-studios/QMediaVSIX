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
  /// <summary>Indicates an interface that contains only static methods.</summary>
  [ContractVersion(typeof (FoundationContract), 65536)]
  [AllowMultiple]
  [AttributeUsage(AttributeTargets.RuntimeClass)]
  public sealed class StaticAttribute : Attribute {
    /// <summary>Creates and initialises a new instance of the attribute.</summary>
    /// <param name="Type">The type that contains the static methods for the runtime class.</param>
    /// <param name="Version">The version in which the static interface was added.</param>
    [MethodImpl]
    public extern StaticAttribute( Type Type, uint Version );

    /// <summary>Creates and initialises a new instance of the attribute.</summary>
    /// <param name="Type">The type that contains the static methods for the runtime class.</param>
    /// <param name="Version">The version in which the static interface was added.</param>
    /// <param name="Platform">A value of the enumeration. The default is **Windows**.</param>
    [MethodImpl]
    public extern StaticAttribute( Type Type, uint Version, Platform Platform );

    /// <summary>Creates and initialises a new instance of the attribute.</summary>
    /// <param name="Type">The type that contains the static methods for the runtime class.</param>
    /// <param name="Version">The version of the API Contract in which the static factory was added to the runtime class's activation factory.</param>
    /// <param name="ContractName">A string representing the type of the API contract implementing the class.</param>
    [MethodImpl]
    public extern StaticAttribute( Type Type, uint Version, string ContractName );
  }
}