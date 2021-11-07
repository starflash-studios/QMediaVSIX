// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Enumeration.IDeviceSelectedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Enumeration
{
  [Guid(647944926, 7471, 18752, 132, 2, 65, 86, 184, 29, 60, 119)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (DeviceSelectedEventArgs))]
  internal interface IDeviceSelectedEventArgs
  {
    DeviceInformation SelectedDevice { get; }
  }
}
