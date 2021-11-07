#region Copyright (C) 2017-2021  Starflash Studios
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License (Version 3.0)
// as published by the Free Software Foundation.
// 
// More information can be found here: https://www.gnu.org/licenses/gpl-3.0.en.html
#endregion

#region Using Directives

using Windows.Foundation.Metadata;

#endregion

namespace Windows.Foundation {
  /// <summary>Contains number values that represent the location and size of a rectangle.</summary>
  [ContractVersion(typeof (FoundationContract), 65536U)]
  public struct Rect {
    /// <summary>The x-coordinate of the upper-left corner of the rectangle.</summary>
    public float X;

    /// <summary>The y-coordinate of the upper-left corner of the rectangle.</summary>
    public float Y;

    /// <summary>The width of the rectangle, in pixels.</summary>
    public float Width;

    /// <summary>The height of the rectangle, in pixels.</summary>
    public float Height;
  }
}