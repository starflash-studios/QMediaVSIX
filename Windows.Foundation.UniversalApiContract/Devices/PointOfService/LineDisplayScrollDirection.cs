// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.LineDisplayScrollDirection
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService
{
  /// <summary>Defines the constants that indicate the scrolling direction of the line display.</summary>
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  public enum LineDisplayScrollDirection
  {
    /// <summary>The line display scrolls up. Only supported if the parent LineDisplay.IsVerticalMarqueeSupported is True.</summary>
    Up,
    /// <summary>The line display scrolls right. Only supported if the parent LineDisplay.IsHorizontalMarqueeSupported is True.</summary>
    Down,
    /// <summary>The line display scrolls left. Only supported if the parent LineDisplay.IsHorizontalMarqueeSupported is True.</summary>
    Left,
    /// <summary>The line display scrolls down. Only supported if the parent LineDisplay.IsVerticalMarqueeSupported is True.</summary>
    Right,
  }
}
