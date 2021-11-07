// Decompiled with JetBrains decompiler
// Type: Windows.Media.Playback.IMediaPlaybackItemFailedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Playback
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (MediaPlaybackItemFailedEventArgs))]
  [Guid(1996690250, 59815, 18371, 134, 44, 198, 86, 211, 6, 131, 212)]
  internal interface IMediaPlaybackItemFailedEventArgs
  {
    MediaPlaybackItem Item { get; }

    MediaPlaybackItemError Error { get; }
  }
}
