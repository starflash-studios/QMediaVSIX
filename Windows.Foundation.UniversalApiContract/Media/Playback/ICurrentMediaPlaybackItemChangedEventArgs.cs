// Decompiled with JetBrains decompiler
// Type: Windows.Media.Playback.ICurrentMediaPlaybackItemChangedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Playback
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(390310034, 23619, 18965, 150, 122, 87, 45, 45, 15, 38, 198)]
  [ExclusiveTo(typeof (CurrentMediaPlaybackItemChangedEventArgs))]
  internal interface ICurrentMediaPlaybackItemChangedEventArgs
  {
    MediaPlaybackItem NewItem { get; }

    MediaPlaybackItem OldItem { get; }
  }
}
