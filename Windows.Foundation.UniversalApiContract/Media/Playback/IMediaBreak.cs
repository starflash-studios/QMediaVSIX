// Decompiled with JetBrains decompiler
// Type: Windows.Media.Playback.IMediaBreak
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Media.Playback
{
  [ExclusiveTo(typeof (MediaBreak))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(1900798576, 3567, 20156, 164, 137, 107, 52, 147, 14, 21, 88)]
  internal interface IMediaBreak
  {
    MediaPlaybackList PlaybackList { get; }

    IReference<TimeSpan> PresentationPosition { get; }

    MediaBreakInsertionMethod InsertionMethod { get; }

    ValueSet CustomProperties { get; }

    bool CanStart { get; set; }
  }
}
