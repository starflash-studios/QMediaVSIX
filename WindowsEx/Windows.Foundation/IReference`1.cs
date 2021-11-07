#region Copyright (C) 2017-2021  Starflash Studios
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License (Version 3.0)
// as published by the Free Software Foundation.
// 
// More information can be found here: https://www.gnu.org/licenses/gpl-3.0.en.html
#endregion

#region Using Directives

using System.Runtime.CompilerServices;
using Windows.Foundation.Metadata;

#endregion

namespace Windows.Foundation {
  /// <summary>Enables arbitrary enumerations, structures, and delegate types to be used as property values.</summary>
  /// <typeparam name="T">
  /// </typeparam>
  [Guid(1640068870, 11621, 4576, 154, 232, 212, 133, 100, 1, 84, 114)]
  [ContractVersion(typeof (FoundationContract), 65536)]
  // ReSharper disable once TypeParameterCanBeVariant
  public interface IReference<T> : IPropertyValue {
    /// <summary>Gets the type that is represented as an IPropertyValue.</summary>
    /// <returns>The type.</returns>
    T Value { [MethodImpl] get; }
  }
}