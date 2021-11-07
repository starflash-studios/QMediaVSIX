// Decompiled with JetBrains decompiler
// Type: Windows.Media.Audio.AudioDeviceNodeCreationStatus
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Audio
{
  /// <summary>Defines status values for audio device node creation.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum AudioDeviceNodeCreationStatus
  {
    /// <summary>Audio device node creation succeeded.</summary>
    Success,
    /// <summary>The audio device is not available.</summary>
    DeviceNotAvailable,
    /// <summary>The format for audio device node creation is not supported.</summary>
    FormatNotSupported,
    /// <summary>An unknown failure occurred in creation of the audio device node.</summary>
    UnknownFailure,
    /// <summary>Access to the audio device was denied.</summary>
    AccessDenied,
  }
}
