// Decompiled with JetBrains decompiler
// Type: Windows.Media.Audio.SpatialAudioFormatConfiguration
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Audio
{
  /// <summary>Provides a way to configure Spatial Audio Formats.</summary>
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [Static(typeof (ISpatialAudioFormatConfigurationStatics), 458752, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 1)]
  public sealed class SpatialAudioFormatConfiguration : ISpatialAudioFormatConfiguration
  {
    /// <summary>Allows a spatial audio format companion app to report that the license has changed for a specific format.</summary>
    /// <param name="subtype">String of the GUID for the spatial audio format that's license has changed.</param>
    /// <returns>An async action.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction ReportLicenseChangedAsync(string subtype);

    /// <summary>Allows a spatial audio format companion app to report that the configuration has changed for a specific format.</summary>
    /// <param name="subtype">String of the GUID for the spatial audio format that's configuration has changed.</param>
    /// <returns>An async action.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction ReportConfigurationChangedAsync(string subtype);

    /// <summary>Specifies which policy to use when picking a spatial audio format in mixed reality.</summary>
    /// <returns>An enumeration that specifies how to handle spatial audio in Mixed Reality.</returns>
    public extern MixedRealitySpatialAudioFormatPolicy MixedRealityExclusiveModePolicy { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets an instance of SpatialAudioFormatConfiguration.</summary>
    /// <returns>An instance of SpatialAudioFormatConfiguration.</returns>
    [MethodImpl]
    public static extern SpatialAudioFormatConfiguration GetDefault();
  }
}
