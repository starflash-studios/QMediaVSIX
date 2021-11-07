// Decompiled with JetBrains decompiler
// Type: Windows.Media.Audio.ISpatialAudioDeviceConfigurationStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Audio
{
  [ExclusiveTo(typeof (SpatialAudioDeviceConfiguration))]
  [Guid(1052999547, 37741, 19972, 151, 40, 40, 39, 217, 247, 88, 196)]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  internal interface ISpatialAudioDeviceConfigurationStatics
  {
    SpatialAudioDeviceConfiguration GetForDeviceId(string deviceId);
  }
}
