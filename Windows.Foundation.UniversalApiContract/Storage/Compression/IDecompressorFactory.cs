// Decompiled with JetBrains decompiler
// Type: Windows.Storage.Compression.IDecompressorFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Storage.Compression
{
  [Guid(1396171346, 7586, 17121, 136, 52, 3, 121, 210, 141, 116, 47)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (Decompressor))]
  internal interface IDecompressorFactory
  {
    Decompressor CreateDecompressor(IInputStream underlyingStream);
  }
}
