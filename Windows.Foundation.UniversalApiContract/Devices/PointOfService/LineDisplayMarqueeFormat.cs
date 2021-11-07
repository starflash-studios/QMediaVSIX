// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.LineDisplayMarqueeFormat
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService
{
  /// <summary>Defines the constants that indicate the marquee format for the current window.</summary>
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  public enum LineDisplayMarqueeFormat
  {
    /// <summary>Marquee scrolling is disabled.</summary>
    None,
    /// <summary>The display is populated by walking data from the opposite end of the display as the scrolling direction. For example, if the scrolling direction is Left, then the viewport is filled by bringing characters in from the right side and scrolling them to the left.</summary>
    Walk,
    /// <summary>The display is populated by placing data. For example, if the scrolling direction is left, then the viewport is filled by placing characters starting at the left side, and beginning scrolling only after the viewport is full.</summary>
    Place,
  }
}
