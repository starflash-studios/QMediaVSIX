// Decompiled with JetBrains decompiler
// Type: Windows.Media.Audio.ISpatialAudioFormatConfiguration
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Audio
{
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [ExclusiveTo(typeof (SpatialAudioFormatConfiguration))]
  [Guid(853477800, 20720, 21397, 153, 35, 125, 68, 202, 113, 237, 109)]
  internal interface ISpatialAudioFormatConfiguration
  {
    [RemoteAsync]
    IAsyncAction ReportLicenseChangedAsync(string subtype);

    [RemoteAsync]
    IAsyncAction ReportConfigurationChangedAsync(string subtype);

    MixedRealitySpatialAudioFormatPolicy MixedRealityExclusiveModePolicy { get; set; }
  }
}
