// Decompiled with JetBrains decompiler
// Type: Windows.Media.Audio.MixedRealitySpatialAudioFormatPolicy
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Audio
{
  /// <summary>Specifies which policy to use when picking a spatial audio format in mixed reality.</summary>
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  public enum MixedRealitySpatialAudioFormatPolicy
  {
    /// <summary>Use the system defined default for Mixed Reality.</summary>
    UseMixedRealityDefaultSpatialAudioFormat,
    /// <summary>Use the device configuration's default.</summary>
    UseDeviceConfigurationDefaultSpatialAudioFormat,
  }
}
