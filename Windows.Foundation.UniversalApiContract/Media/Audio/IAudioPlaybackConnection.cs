// Decompiled with JetBrains decompiler
// Type: Windows.Media.Audio.IAudioPlaybackConnection
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Audio
{
  [ExclusiveTo(typeof (AudioPlaybackConnection))]
  [ContractVersion(typeof (UniversalApiContract), 655360)]
  [Guid(441196010, 51964, 20711, 135, 24, 234, 63, 129, 203, 250, 81)]
  internal interface IAudioPlaybackConnection
  {
    void Start();

    [RemoteAsync]
    IAsyncAction StartAsync();

    string DeviceId { get; }

    AudioPlaybackConnectionState State { get; }

    AudioPlaybackConnectionOpenResult Open();

    [RemoteAsync]
    IAsyncOperation<AudioPlaybackConnectionOpenResult> OpenAsync();

    event TypedEventHandler<AudioPlaybackConnection, object> StateChanged;
  }
}
