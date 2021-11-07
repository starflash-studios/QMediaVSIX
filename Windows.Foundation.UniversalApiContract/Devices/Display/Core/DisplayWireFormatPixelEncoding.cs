// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Display.Core.DisplayWireFormatPixelEncoding
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Display.Core
{
  /// <summary>Defines constants that specify the color model and chroma subsampling format used to encode pixel data.</summary>
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  public enum DisplayWireFormatPixelEncoding
  {
    /// <summary>Indicates RGB color channels with no chroma subsampling.</summary>
    Rgb444,
    /// <summary>Indicates YCbCr color channels with no chroma subsampling.</summary>
    Ycc444,
    /// <summary>Indicates YCbCr color channels with 4:2:2 chroma subsampling.</summary>
    Ycc422,
    /// <summary>Indicates YCbCr color channels with 4:2:0 chroma subsampling.</summary>
    Ycc420,
    /// <summary>Indicates a single grayscale channel and no chroma data.</summary>
    Intensity,
  }
}
