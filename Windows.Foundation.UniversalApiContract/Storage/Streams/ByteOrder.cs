// Decompiled with JetBrains decompiler
// Type: Windows.Storage.Streams.ByteOrder
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage.Streams
{
  /// <summary>Specifies the byte order of a stream.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum ByteOrder
  {
    /// <summary>The least significant byte (lowest address) is stored first.</summary>
    LittleEndian,
    /// <summary>The most significant byte (highest address) is stored first.</summary>
    BigEndian,
  }
}
