// Decompiled with JetBrains decompiler
// Type: Windows.Media.Audio.AudioGraphSettings
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Devices.Enumeration;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Media.MediaProperties;
using Windows.Media.Render;

namespace Windows.Media.Audio
{
  /// <summary>Represents initialization settings for an audio graph. Set the properties of this object to your desired values and then call AudioGraph.CreateAsync to create a new audio graph instance with the specified settings.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [Activatable(typeof (IAudioGraphSettingsFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 167772160)]
  public sealed class AudioGraphSettings : IAudioGraphSettings, IAudioGraphSettings2
  {
    /// <summary>Initializes a new instance of the AudioGraphSettings class with initial settings values optimized for the specified AudioRenderCategory.</summary>
    /// <param name="audioRenderCategory">The AudioRenderCategory that determines the initial settings values.</param>
    [MethodImpl]
    public extern AudioGraphSettings(AudioRenderCategory audioRenderCategory);

    /// <summary>Gets or sets the audio encoding properties setting for the audio graph.</summary>
    /// <returns>The audio encoding properties for the audio graph.</returns>
    public extern AudioEncodingProperties EncodingProperties { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets an object that represents the primary render device for the audio graph.</summary>
    /// <returns>An object that represents the primary render device for the audio graph.</returns>
    public extern DeviceInformation PrimaryRenderDevice { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the quantum size selection mode for the audio graph.</summary>
    /// <returns>An enumeration value indicating the quantum size selection mode. If the audio graph is only to be used with files, it is strongly recommended to use the value SystemDefault.</returns>
    public extern QuantumSizeSelectionMode QuantumSizeSelectionMode { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the desired number of samples per quantum defined for the audio graph.</summary>
    /// <returns>The number of samples per quantum.</returns>
    public extern int DesiredSamplesPerQuantum { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates the audio render category setting for the audio graph.</summary>
    /// <returns>A value that indicates the audio render category setting for an audio graph.</returns>
    public extern AudioRenderCategory AudioRenderCategory { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates the desired audio processing mode setting for the audio graph.</summary>
    /// <returns>A value that indicates the desired audio processing mode setting for the audio graph.</returns>
    public extern AudioProcessing DesiredRenderDeviceAudioProcessing { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the maximum playback speed of input nodes in the AudioGraph.</summary>
    /// <returns>The maximum playback speed of the associated AudioGraph, as a multiplier of the normal speed of the content. So, a value of 2 represents twice the normal speed and a value of 3 represents three times the normal speed. This value must be in the range of 1 to 1024, inclusive. The default value is 1024.</returns>
    public extern double MaxPlaybackSpeedFactor { [MethodImpl] set; [MethodImpl] get; }
  }
}
