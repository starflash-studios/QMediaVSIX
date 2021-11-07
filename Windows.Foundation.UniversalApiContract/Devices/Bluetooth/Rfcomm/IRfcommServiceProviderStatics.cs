// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.Rfcomm.IRfcommServiceProviderStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth.Rfcomm
{
  [Guid(2559083267, 27082, 16698, 132, 247, 67, 68, 199, 41, 41, 151)]
  [ExclusiveTo(typeof (RfcommServiceProvider))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IRfcommServiceProviderStatics
  {
    [RemoteAsync]
    IAsyncOperation<RfcommServiceProvider> CreateAsync(
      RfcommServiceId serviceId);
  }
}
