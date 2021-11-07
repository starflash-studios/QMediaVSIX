#region Copyright (C) 2017-2021  Starflash Studios
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License (Version 3.0)
// as published by the Free Software Foundation.
// 
// More information can be found here: https://www.gnu.org/licenses/gpl-3.0.en.html
#endregion

#region Using Directives

using Windows.Foundation;
using Windows.Foundation.Metadata;

#endregion

namespace Windows.Storage.Streams {
  /// <summary>Represents a referenced array of bytes used by byte stream read and write interfaces. Buffer is the class implementation of this interface.</summary>
  [Guid(2421821408, 48211, 4575, 140, 73, 0, 30, 79, 198, 134, 218)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public interface IBuffer {
    /// <summary>Gets the maximum number of bytes that the buffer can hold.</summary>
    /// <returns>The maximum number of bytes that the buffer can hold.</returns>
    uint Capacity { get; }

    /// <summary>Gets the number of bytes currently in use in the buffer.</summary>
    /// <returns>The number of bytes currently in use in the buffer which is less than or equal to the capacity of the buffer.</returns>
    uint Length { get; set; }
  }
}