// Decompiled with JetBrains decompiler
// Type: Windows.Media.Audio.SpatialAudioDeviceConfiguration
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Audio
{
  /// <summary>Represents a audio device, providing information and control for its current spatial audio setup.</summary>
  [Static(typeof (ISpatialAudioDeviceConfigurationStatics), 458752, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [DualApiPartition(version = 1)]
  public sealed class SpatialAudioDeviceConfiguration : ISpatialAudioDeviceConfiguration
  {
    /// <summary>The ID of the device this object represents.</summary>
    /// <returns>String representation of the device ID.</returns>
    public extern string DeviceId { [MethodImpl] get; }

    /// <summary>Specifies whether this device can support any form of spatial audio.</summary>
    /// <returns>Bool indicating whether this device supports spatial audio.</returns>
    public extern bool IsSpatialAudioSupported { [MethodImpl] get; }

    /// <summary>Specifies whether this device can support the given spatial audio format.</summary>
    /// <param name="subtype">A string of the GUID for the spatial audo format to check. SpatialAudioFormatSubtype enum will return the neccesary strings.</param>
    /// <returns>Bool indicating whether the format is supported or not.</returns>
    [MethodImpl]
    public extern bool IsSpatialAudioFormatSupported(string subtype);

    /// <summary>Provides the currently active spatial audio format for this device. This could have been changed by the system and therefore may not be the same as the default.</summary>
    /// <returns>A string of the GUID for the active spatial audio format.</returns>
    public extern string ActiveSpatialAudioFormat { [MethodImpl] get; }

    /// <summary>Provides the default spatial audio format for this device. This is the format the user has selected.</summary>
    /// <returns>A string of the GUID for the default spatial audio format.</returns>
    public extern string DefaultSpatialAudioFormat { [MethodImpl] get; }

    /// <summary>Tries to set the specified spatial audio format for this device. The caller must be the app that owns this spatial audio format.</summary>
    /// <param name="subtype">A string of the GUID for the spatial audio format to set. SpatialAudioFormatSubtype enum will return the neccesary string.</param>
    /// <returns>A result indicating success or why the call failed to set the specified format.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<SetDefaultSpatialAudioFormatResult> SetDefaultSpatialAudioFormatAsync(
      string subtype);

    /// <summary>Occurs when the spatial audio state of the device has changed.</summary>
    public extern event TypedEventHandler<SpatialAudioDeviceConfiguration, object> ConfigurationChanged;

    /// <summary>Creates a SpatialAudioDeviceConfiguration for the given device ID.</summary>
    /// <param name="deviceId">The device ID of the device to represent.</param>
    /// <returns>The SpatialAudioDeviceConfiguration for the device.</returns>
    [MethodImpl]
    public static extern SpatialAudioDeviceConfiguration GetForDeviceId(
      string deviceId);
  }
}
