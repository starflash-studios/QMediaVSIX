// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.IMediaStreamSample
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Media.Core
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1552791079, 19328, 17249, 152, 55, 108, 183, 72, 26, 217, 214)]
  [ExclusiveTo(typeof (MediaStreamSample))]
  internal interface IMediaStreamSample
  {
    event TypedEventHandler<MediaStreamSample, object> Processed;

    Buffer Buffer { get; }

    TimeSpan Timestamp { get; }

    MediaStreamSamplePropertySet ExtendedProperties { get; }

    MediaStreamSampleProtectionProperties Protection { get; }

    TimeSpan DecodeTimestamp { set; get; }

    TimeSpan Duration { set; get; }

    bool KeyFrame { set; get; }

    bool Discontinuous { set; get; }
  }
}
