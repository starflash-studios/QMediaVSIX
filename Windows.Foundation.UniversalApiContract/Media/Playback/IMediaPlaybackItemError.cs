// Decompiled with JetBrains decompiler
// Type: Windows.Media.Playback.IMediaPlaybackItemError
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Playback
{
  [ExclusiveTo(typeof (MediaPlaybackItemError))]
  [Guid(1778118443, 56534, 19961, 164, 80, 219, 244, 198, 241, 194, 194)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IMediaPlaybackItemError
  {
    MediaPlaybackItemErrorCode ErrorCode { get; }

    HResult ExtendedError { get; }
  }
}
