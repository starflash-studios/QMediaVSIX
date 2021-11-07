// Decompiled with JetBrains decompiler
// Type: Windows.Media.Control.IGlobalSystemMediaTransportControlsSessionPlaybackControls
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Control
{
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [ExclusiveTo(typeof (GlobalSystemMediaTransportControlsSessionPlaybackControls))]
  [Guid(1694606310, 48250, 20538, 187, 27, 104, 241, 88, 243, 251, 3)]
  internal interface IGlobalSystemMediaTransportControlsSessionPlaybackControls
  {
    bool IsPlayEnabled { get; }

    bool IsPauseEnabled { get; }

    bool IsStopEnabled { get; }

    bool IsRecordEnabled { get; }

    bool IsFastForwardEnabled { get; }

    bool IsRewindEnabled { get; }

    bool IsNextEnabled { get; }

    bool IsPreviousEnabled { get; }

    bool IsChannelUpEnabled { get; }

    bool IsChannelDownEnabled { get; }

    bool IsPlayPauseToggleEnabled { get; }

    bool IsShuffleEnabled { get; }

    bool IsRepeatEnabled { get; }

    bool IsPlaybackRateEnabled { get; }

    bool IsPlaybackPositionEnabled { get; }
  }
}
