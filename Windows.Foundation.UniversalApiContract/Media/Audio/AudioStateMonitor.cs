// Decompiled with JetBrains decompiler
// Type: Windows.Media.Audio.AudioStateMonitor
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Media.Capture;
using Windows.Media.Devices;
using Windows.Media.Render;

namespace Windows.Media.Audio
{
  /// <summary>Allows a UWP app to determine if any of the app's audio streams are currently being muted or having their volume reduced by the system.</summary>
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IAudioStateMonitorStatics), 393216, "Windows.Foundation.UniversalApiContract")]
  public sealed class AudioStateMonitor : IAudioStateMonitor
  {
    /// <summary>Occurs when the system changes the sound level of the audio streams being monitored by the AudioStateMonitor.</summary>
    public extern event TypedEventHandler<AudioStateMonitor, object> SoundLevelChanged;

    /// <summary>Gets a value indicating the current sound level of the audio streams being monitored by the AudioStateMonitor.</summary>
    /// <returns>A value indicating the current sound level of the monitored audio streams.</returns>
    public extern SoundLevel SoundLevel { [MethodImpl] get; }

    /// <summary>Initializes a new instance of the AudioStateMonitor class that monitors the sound level for all audio render streams.</summary>
    /// <returns>An AudioStateMonitor object.</returns>
    [Overload("CreateForRenderMonitoring")]
    [MethodImpl]
    public static extern AudioStateMonitor CreateForRenderMonitoring();

    /// <summary>Initializes a new instance of the AudioStateMonitor class that monitors the sound level for audio render streams with the specified MediaCategory.</summary>
    /// <param name="category">A value from the MediaCategory enumeration indicating the categories of audio streams that will be monitored. The system may use the category of an audio stream to determine if it should be muted or have its volume lowered in response to a particular system event.</param>
    /// <returns>An AudioStateMonitor object.</returns>
    [Overload("CreateForRenderMonitoringWithCategory")]
    [MethodImpl]
    public static extern AudioStateMonitor CreateForRenderMonitoring(
      AudioRenderCategory category);

    /// <summary>Initializes a new instance of the AudioStateMonitor class that monitors the sound level for render streams with the specified MediaCategory and  AudioDeviceRole.</summary>
    /// <param name="category">A value from the MediaCategory enumeration indicating the categories of audio streams that will be monitored. The system may use the category of an audio stream to determine if it should be muted or have its volume lowered in response to a particular system event.</param>
    /// <param name="role">A value from the AudioDeviceRole enumeration indicating the device role of audio streams that will be monitored. The system may use the device role of an audio stream to determine if it should be muted or have its volume lowered in response to a particular system event.</param>
    /// <returns>An AudioStateMonitor object.</returns>
    [Overload("CreateForRenderMonitoringWithCategoryAndDeviceRole")]
    [MethodImpl]
    public static extern AudioStateMonitor CreateForRenderMonitoring(
      AudioRenderCategory category,
      AudioDeviceRole role);

    /// <summary>Initializes a new instance of the AudioStateMonitor class that monitors the sound level for audio render streams with the specified MediaCategory that are using the specified audio device.</summary>
    /// <param name="category">A value from the MediaCategory enumeration indicating the categories of audio streams that will be monitored. The system may use the category of an audio stream to determine if it should be muted or have its volume lowered in response to a particular system event.</param>
    /// <param name="deviceId">A string containing the unique identifier of a audio device for which associated audio streams will be monitored.</param>
    /// <returns>An AudioStateMonitor object.</returns>
    [MethodImpl]
    public static extern AudioStateMonitor CreateForRenderMonitoringWithCategoryAndDeviceId(
      AudioRenderCategory category,
      string deviceId);

    /// <summary>Initializes a new instance of the AudioStateMonitor class that monitors the sound level for all audio capture streams.</summary>
    /// <returns>An AudioStateMonitor object.</returns>
    [Overload("CreateForCaptureMonitoring")]
    [MethodImpl]
    public static extern AudioStateMonitor CreateForCaptureMonitoring();

    /// <summary>Initializes a new instance of the AudioStateMonitor class that monitors the sound level for audio capture streams with the specified MediaCategory.</summary>
    /// <param name="category">A value from the MediaCategory enumeration indicating the categories of audio streams that will be monitored. The system may use the category of an audio stream to determine if it should be muted or have its volume lowered in response to a particular system event.</param>
    /// <returns>An AudioStateMonitor object.</returns>
    [Overload("CreateForCaptureMonitoringWithCategory")]
    [MethodImpl]
    public static extern AudioStateMonitor CreateForCaptureMonitoring(
      MediaCategory category);

    /// <summary>Initializes a new instance of the AudioStateMonitor class that monitors the sound level for audio capture streams with the specified MediaCategory and  AudioDeviceRole.</summary>
    /// <param name="category">A value from the MediaCategory enumeration indicating the categories of audio streams that will be monitored. The system may use the category of an audio stream to determine if it should be muted or have its volume lowered in response to a particular system event.</param>
    /// <param name="role">A value from the AudioDeviceRole enumeration indicating the device role of audio streams that will be monitored. The system may use the device role of an audio stream to determine if it should be muted or have its volume lowered in response to a particular system event.</param>
    /// <returns>An AudioStateMonitor object.</returns>
    [Overload("CreateForCaptureMonitoringWithCategoryAndDeviceRole")]
    [MethodImpl]
    public static extern AudioStateMonitor CreateForCaptureMonitoring(
      MediaCategory category,
      AudioDeviceRole role);

    /// <summary>Initializes a new instance of the AudioStateMonitor class that monitors the sound level for audio capture streams with the specified MediaCategory that are using the specified audio device.</summary>
    /// <param name="category">A value from the MediaCategory enumeration indicating the categories of audio streams that will be monitored. The system may use the category of an audio stream to determine if it should be muted or have its volume lowered in response to a particular system event.</param>
    /// <param name="deviceId">A string containing the unique identifier of a audio device for which associated audio streams will be monitored.</param>
    /// <returns>An AudioStateMonitor object.</returns>
    [MethodImpl]
    public static extern AudioStateMonitor CreateForCaptureMonitoringWithCategoryAndDeviceId(
      MediaCategory category,
      string deviceId);
  }
}
