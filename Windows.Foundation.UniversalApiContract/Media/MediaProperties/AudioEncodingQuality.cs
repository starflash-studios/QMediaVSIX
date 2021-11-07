// Decompiled with JetBrains decompiler
// Type: Windows.Media.MediaProperties.AudioEncodingQuality
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.MediaProperties
{
  /// <summary>Describes the level of quality of the audio encoding. The higher the quality, the better the audio fidelity, and the larger the resulting file.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum AudioEncodingQuality
  {
    /// <summary>**Auto** fills in the proper settings based on the current camera settings. So when **Auto** is used, settings that are manually modified are ignored. For example, if you create a preset profile using one the static create methods, such as CreateM4a, and specify **Auto** as the encoding quality, any changes you make to the properties will be overwritten with values based on the current camera settings.</summary>
    Auto,
    /// <summary>Stereo, Professional audio sampling rate (48 kHz), 192 kilobits per second (kbps) data transfer rate.</summary>
    High,
    /// <summary>Stereo, CD quality sampling rate (44.1 kHz), 128 kilobits per second (kbps) data transfer rate.</summary>
    Medium,
    /// <summary>Mono, CD quality sampling rate (44.1 kHz), 96 kilobits per second (kbps) data transfer rate.</summary>
    Low,
  }
}
