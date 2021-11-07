// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.IMediaStreamSampleStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Media.Core
{
  [ExclusiveTo(typeof (MediaStreamSample))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3755942287, 42703, 17785, 190, 65, 115, 221, 148, 26, 217, 114)]
  internal interface IMediaStreamSampleStatics
  {
    MediaStreamSample CreateFromBuffer(IBuffer buffer, TimeSpan timestamp);

    [RemoteAsync]
    IAsyncOperation<MediaStreamSample> CreateFromStreamAsync(
      IInputStream stream,
      uint count,
      TimeSpan timestamp);
  }
}
