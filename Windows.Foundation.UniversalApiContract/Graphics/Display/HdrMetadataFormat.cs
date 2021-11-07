// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Display.HdrMetadataFormat
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Display
{
  /// <summary>Describes the HDR metadata format.</summary>
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  public enum HdrMetadataFormat
  {
    /// <summary>The specified display supports the HDR10 style metadata, as per the HDR10 specification.</summary>
    Hdr10,
    /// <summary>The specified display supports the HDR10Plus style of metadata, as per the HDR10Plus specification.</summary>
    Hdr10Plus,
  }
}
