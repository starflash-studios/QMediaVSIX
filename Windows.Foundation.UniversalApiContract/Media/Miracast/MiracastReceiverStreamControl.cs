// Decompiled with JetBrains decompiler
// Type: Windows.Media.Miracast.MiracastReceiverStreamControl
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Miracast
{
  /// <summary>An object which encapsulates functionality for controlling properties of the audio and video streams.</summary>
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 1)]
  public sealed class MiracastReceiverStreamControl : IMiracastReceiverStreamControl
  {
    /// <summary>Returns an object representing the current settings for the video stream.</summary>
    /// <returns>The current settings for the video stream.</returns>
    [MethodImpl]
    public extern MiracastReceiverVideoStreamSettings GetVideoStreamSettings();

    /// <summary>Returns an object representing the current settings for the video stream.</summary>
    /// <returns>The current settings for the video stream.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<MiracastReceiverVideoStreamSettings> GetVideoStreamSettingsAsync();

    /// <summary>Suggests an appropriate width, height and bitrate to the Miracast Transmitter.</summary>
    /// <param name="settings">A MiracastReceiverVideoStreamSettings object representing the suggested settings.</param>
    [MethodImpl]
    public extern void SuggestVideoStreamSettings(MiracastReceiverVideoStreamSettings settings);

    /// <summary>Asynchronously suggests an appropriate width, height and bitrate to the Miracast Transmitter.</summary>
    /// <param name="settings">A MiracastReceiverVideoStreamSettings object representing the suggested settings.</param>
    /// <returns>An asynchronous task.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction SuggestVideoStreamSettingsAsync(
      MiracastReceiverVideoStreamSettings settings);

    /// <summary>Specifies whether the Miracast Transmitter should mute the audio stream. The default value is false.</summary>
    /// <returns>True if the Miracast Transmitter should mute the audio stream.</returns>
    public extern bool MuteAudio { [MethodImpl] get; [MethodImpl] set; }
  }
}
