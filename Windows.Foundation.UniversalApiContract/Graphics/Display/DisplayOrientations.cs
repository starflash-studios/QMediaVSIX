// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Display.DisplayOrientations
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Display
{
  /// <summary>Describes the orientation of a rectangular monitor.</summary>
  [Flags]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum DisplayOrientations : uint
  {
    /// <summary>No display orientation is specified.</summary>
    None = 0,
    /// <summary>Specifies that the monitor is oriented in landscape mode where the width of the display viewing area is greater than the height.</summary>
    Landscape = 1,
    /// <summary>Specifies that the monitor rotated 90 degrees in the clockwise direction to orient the display in portrait mode where the height of the display viewing area is greater than the width.</summary>
    Portrait = 2,
    /// <summary>Specifies that the monitor rotated another 90 degrees in the clockwise direction (to equal 180 degrees) to orient the display in landscape mode where the width of the display viewing area is greater than the height. This landscape mode is flipped 180 degrees from the **Landscape** mode.</summary>
    LandscapeFlipped = 4,
    /// <summary>Specifies that the monitor rotated another 90 degrees in the clockwise direction (to equal 270 degrees) to orient the display in portrait mode where the height of the display viewing area is greater than the width. This portrait mode is flipped 180 degrees from the **Portrait** mode.</summary>
    PortraitFlipped = 8,
  }
}
