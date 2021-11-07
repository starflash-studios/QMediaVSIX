// Decompiled with JetBrains decompiler
// Type: Windows.Media.Devices.IAudioDeviceModuleNotificationEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Media.Devices
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (AudioDeviceModuleNotificationEventArgs))]
  [Guid(3823357103, 8780, 18622, 149, 107, 154, 19, 19, 78, 150, 232)]
  internal interface IAudioDeviceModuleNotificationEventArgs
  {
    AudioDeviceModule Module { get; }

    IBuffer NotificationData { get; }
  }
}
