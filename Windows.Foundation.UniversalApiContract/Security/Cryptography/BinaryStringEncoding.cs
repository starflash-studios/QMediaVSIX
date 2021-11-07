// Decompiled with JetBrains decompiler
// Type: Windows.Security.Cryptography.BinaryStringEncoding
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Cryptography
{
  /// <summary>Contains encoding formats that can be used in the ConvertStringToBinary and ConvertBinaryToString methods.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum BinaryStringEncoding
  {
    /// <summary>Eight bit Unicode Transformation Format. The process encodes each Unicode code point into one to four 8-bit bytes. Code points represented by lower numerical values are encoded using fewer bytes. In particular, the first 128 characters correspond exactly to the ASCII character set and are encoded by using a single octet.</summary>
    Utf8,
    /// <summary>Sixteen bit Unicode Transformation Format in little-endian byte order. The encoding process creates a variable length result of one or two 8-bit bytes per Unicode code point.</summary>
    Utf16LE,
    /// <summary>Sixteen bit Unicode Transformation Format in big-endian byte order.</summary>
    Utf16BE,
  }
}
