// Decompiled with JetBrains decompiler
// Type: Windows.Media.Audio.ISpatialAudioDeviceConfiguration
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Audio
{
  [ExclusiveTo(typeof (SpatialAudioDeviceConfiguration))]
  [Guid(4001562676, 25039, 22345, 157, 164, 16, 240, 254, 2, 129, 153)]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  internal interface ISpatialAudioDeviceConfiguration
  {
    string DeviceId { get; }

    bool IsSpatialAudioSupported { get; }

    bool IsSpatialAudioFormatSupported(string subtype);

    string ActiveSpatialAudioFormat { get; }

    string DefaultSpatialAudioFormat { get; }

    [RemoteAsync]
    IAsyncOperation<SetDefaultSpatialAudioFormatResult> SetDefaultSpatialAudioFormatAsync(
      string subtype);

    event TypedEventHandler<SpatialAudioDeviceConfiguration, object> ConfigurationChanged;
  }
}
