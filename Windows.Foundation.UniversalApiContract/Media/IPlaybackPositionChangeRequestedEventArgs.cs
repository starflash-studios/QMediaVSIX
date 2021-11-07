// Decompiled with JetBrains decompiler
// Type: Windows.Media.IPlaybackPositionChangeRequestedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media
{
  [ExclusiveTo(typeof (PlaybackPositionChangeRequestedEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3024699272, 60200, 18785, 156, 20, 51, 94, 68, 243, 225, 37)]
  internal interface IPlaybackPositionChangeRequestedEventArgs
  {
    TimeSpan RequestedPlaybackPosition { get; }
  }
}
