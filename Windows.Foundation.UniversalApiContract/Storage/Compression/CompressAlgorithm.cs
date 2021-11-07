// Decompiled with JetBrains decompiler
// Type: Windows.Storage.Compression.CompressAlgorithm
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage.Compression
{
  /// <summary>Identifies a compression algorithm to use when creating an instance of a compressor.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum CompressAlgorithm
  {
    /// <summary>This value represents an invalid compression algorithm. It is useful primarily for error checking.</summary>
    InvalidAlgorithm,
    /// <summary>This value represents an algorithm that passes data through with no compression. It is useful primarily for testing.</summary>
    NullAlgorithm,
    /// <summary>The compressor will use the MSZIP compression algorithm.</summary>
    Mszip,
    /// <summary>The compressor will use the XPRESS compression algorithm.</summary>
    Xpress,
    /// <summary>The compressor will use the XPRESS compression algorithm with Huffman encoding.</summary>
    XpressHuff,
    /// <summary>The compressor will use the LZMS compression algorithm.</summary>
    Lzms,
  }
}
