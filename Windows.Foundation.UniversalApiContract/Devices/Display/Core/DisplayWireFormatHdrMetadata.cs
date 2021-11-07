// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Display.Core.DisplayWireFormatHdrMetadata
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Display.Core
{
  /// <summary>Defines constants that specify a format for HDR mastering metadata embedded in a pixel bitstream. HDR mastering metadata typically defines how a video stream should be adapted for playback on specific display hardware.</summary>
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  public enum DisplayWireFormatHdrMetadata
  {
    /// <summary>Indicates that no HDR mastering metadata will be supported.</summary>
    None,
    /// <summary>Indicates that HDR10 mastering metadata will be supported, standardized as SMPTE ST 2086.</summary>
    Hdr10,
    /// <summary>Indicates that HDR10+ HDR mastering metadata will be supported, standardized as SMPTE ST 2094-40.</summary>
    Hdr10Plus,
    /// <summary>Indicates that Dolby Vision low-latency mastering metadata will be supported.</summary>
    DolbyVisionLowLatency,
  }
}
