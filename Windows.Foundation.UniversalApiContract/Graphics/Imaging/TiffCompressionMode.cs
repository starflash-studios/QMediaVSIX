// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Imaging.TiffCompressionMode
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Imaging
{
  /// <summary>Specifies the compression mode used for TIFF images.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum TiffCompressionMode
  {
    /// <summary>The compression will be automatically selected.</summary>
    Automatic,
    /// <summary>No compression will be applied.</summary>
    None,
    /// <summary>CCITT3 compression will be applied.</summary>
    Ccitt3,
    /// <summary>CCITT4compression will be applied.</summary>
    Ccitt4,
    /// <summary>LZW compression will be applied.</summary>
    Lzw,
    /// <summary>RLE compression will be applied.</summary>
    Rle,
    /// <summary>ZIP compression will be applied.</summary>
    Zip,
    /// <summary>LZWH Differencing compression will be applied.</summary>
    LzwhDifferencing,
  }
}
