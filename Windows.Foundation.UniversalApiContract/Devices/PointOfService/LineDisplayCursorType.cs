// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.LineDisplayCursorType
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService
{
  /// <summary>Defines the constants that indicate the type of cursor a line display is using.</summary>
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  public enum LineDisplayCursorType
  {
    /// <summary>No cursor.</summary>
    None,
    /// <summary>A block cursor.</summary>
    Block,
    /// <summary>A half-block cursor.</summary>
    HalfBlock,
    /// <summary>An underline cursor.</summary>
    Underline,
    /// <summary>An inverted cursor.</summary>
    Reverse,
    /// <summary>Another type of cursor (not part of the UnifiedPOS specification).</summary>
    Other,
  }
}
