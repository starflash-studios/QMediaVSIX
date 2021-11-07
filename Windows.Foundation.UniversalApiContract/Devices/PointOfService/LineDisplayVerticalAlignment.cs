// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.LineDisplayVerticalAlignment
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService
{
  /// <summary>Defines the constants that indicate the vertical alignment of text on a line display, relative to the current text character position.</summary>
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  public enum LineDisplayVerticalAlignment
  {
    /// <summary>Align the bitmap's top edge with the topmost pixel of the current charcter position.</summary>
    Top,
    /// <summary>Align the bitmap in the vertical center of the current character position.</summary>
    Center,
    /// <summary>Align the bitmap's bottom edge with the bottommost pixel of the current charcter position.</summary>
    Bottom,
  }
}
