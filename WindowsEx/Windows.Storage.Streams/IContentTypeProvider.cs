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
  /// <summary>Characterises the format of the data.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2547030181, 15257, 19945, 136, 165, 225, 29, 47, 80, 199, 149)]
  public interface IContentTypeProvider {
    /// <summary>Gets the format of the data.</summary>
    /// <returns>The identifier for the format of the data.</returns>
    string ContentType { get; }
  }
}