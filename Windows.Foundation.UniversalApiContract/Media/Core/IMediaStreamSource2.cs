// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.IMediaStreamSource2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Core
{
  [Guid(3965046957, 11882, 20340, 173, 187, 181, 98, 209, 83, 56, 73)]
  [ExclusiveTo(typeof (MediaStreamSource))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IMediaStreamSource2 : IMediaStreamSource, IMediaSource
  {
    event TypedEventHandler<MediaStreamSource, MediaStreamSourceSampleRenderedEventArgs> SampleRendered;
  }
}
