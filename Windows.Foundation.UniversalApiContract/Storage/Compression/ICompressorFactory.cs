// Decompiled with JetBrains decompiler
// Type: Windows.Storage.Compression.ICompressorFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Storage.Compression
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1597871780, 11515, 17452, 168, 186, 215, 209, 27, 3, 157, 160)]
  [ExclusiveTo(typeof (Compressor))]
  internal interface ICompressorFactory
  {
    Compressor CreateCompressor(IOutputStream underlyingStream);

    Compressor CreateCompressorEx(
      IOutputStream underlyingStream,
      CompressAlgorithm algorithm,
      uint blockSize);
  }
}
