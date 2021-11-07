// Decompiled with JetBrains decompiler
// Type: Windows.Media.Devices.IAudioDeviceController
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Devices
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (AudioDeviceController))]
  [Guid(3990135688, 31175, 20348, 144, 232, 239, 147, 75, 33, 88, 10)]
  internal interface IAudioDeviceController : IMediaDeviceController
  {
    bool Muted { set; get; }

    float VolumePercent { set; get; }
  }
}
