// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Display.Core.DisplayWireFormatEotf
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Display.Core
{
  /// <summary>Defines constants that specify an electro-optical transfer function (EOTF) for encoded pixels. The EOTF defines how a pixel's encoded value is transformed to an optical brightness on a hardware display.</summary>
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  public enum DisplayWireFormatEotf
  {
    /// <summary>Indicates that pixels are encoded for SDR brightness with a 2.2 gamma curve.</summary>
    Sdr,
    /// <summary>Indicates that pixels are encoded for the SMPTE ST 2084 transfer function, also known as Perceptual Quantizer (PQ).</summary>
    HdrSmpte2084,
  }
}
