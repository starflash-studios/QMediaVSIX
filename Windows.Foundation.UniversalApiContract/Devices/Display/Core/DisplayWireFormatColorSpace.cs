// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Display.Core.DisplayWireFormatColorSpace
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Display.Core
{
  /// <summary>Defines constants that specify a color space, typically defined by combinations of three color primaries (red, green, and blue).</summary>
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  public enum DisplayWireFormatColorSpace
  {
    /// <summary>Indicates that pixels are encoded for the BT.709 standard color primaries.</summary>
    BT709,
    /// <summary>Indicates that pixels are encoded for the BT.2020 standard color primaries.</summary>
    BT2020,
    /// <summary>Indicates that pixels are encoded for an exact color space defined in the currently applied color profile.</summary>
    ProfileDefinedWideColorGamut,
  }
}
