// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Enumeration.IDeviceAccessInformation
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Enumeration
{
  [Guid(195730035, 28133, 18709, 141, 221, 154, 5, 84, 166, 245, 69)]
  [ExclusiveTo(typeof (DeviceAccessInformation))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IDeviceAccessInformation
  {
    event TypedEventHandler<DeviceAccessInformation, DeviceAccessChangedEventArgs> AccessChanged;

    DeviceAccessStatus CurrentStatus { get; }
  }
}
