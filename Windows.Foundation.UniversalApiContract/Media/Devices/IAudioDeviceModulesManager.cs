// Decompiled with JetBrains decompiler
// Type: Windows.Media.Devices.IAudioDeviceModulesManager
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Media.Devices
{
  [ExclusiveTo(typeof (AudioDeviceModulesManager))]
  [Guid(1789135949, 38410, 19740, 179, 24, 0, 34, 96, 69, 71, 237)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface IAudioDeviceModulesManager
  {
    event TypedEventHandler<AudioDeviceModulesManager, AudioDeviceModuleNotificationEventArgs> ModuleNotificationReceived;

    IVectorView<AudioDeviceModule> FindAllById(string moduleId);

    IVectorView<AudioDeviceModule> FindAll();
  }
}
