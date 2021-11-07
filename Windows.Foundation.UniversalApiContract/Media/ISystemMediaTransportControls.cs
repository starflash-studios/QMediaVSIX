// Decompiled with JetBrains decompiler
// Type: Windows.Media.ISystemMediaTransportControls
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media
{
  [ExclusiveTo(typeof (SystemMediaTransportControls))]
  [Guid(2583314420, 5954, 17062, 144, 46, 8, 125, 65, 249, 101, 236)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ISystemMediaTransportControls
  {
    MediaPlaybackStatus PlaybackStatus { get; set; }

    SystemMediaTransportControlsDisplayUpdater DisplayUpdater { get; }

    SoundLevel SoundLevel { get; }

    bool IsEnabled { get; set; }

    bool IsPlayEnabled { get; set; }

    bool IsStopEnabled { get; set; }

    bool IsPauseEnabled { get; set; }

    bool IsRecordEnabled { get; set; }

    bool IsFastForwardEnabled { get; set; }

    bool IsRewindEnabled { get; set; }

    bool IsPreviousEnabled { get; set; }

    bool IsNextEnabled { get; set; }

    bool IsChannelUpEnabled { get; set; }

    bool IsChannelDownEnabled { get; set; }

    event TypedEventHandler<SystemMediaTransportControls, SystemMediaTransportControlsButtonPressedEventArgs> ButtonPressed;

    event TypedEventHandler<SystemMediaTransportControls, SystemMediaTransportControlsPropertyChangedEventArgs> PropertyChanged;
  }
}
