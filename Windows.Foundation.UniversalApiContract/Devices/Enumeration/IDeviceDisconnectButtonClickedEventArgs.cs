// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Enumeration.IDeviceDisconnectButtonClickedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Enumeration
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (DeviceDisconnectButtonClickedEventArgs))]
  [Guid(2386867565, 63746, 18944, 181, 54, 243, 121, 146, 230, 162, 167)]
  internal interface IDeviceDisconnectButtonClickedEventArgs
  {
    DeviceInformation Device { get; }
  }
}
