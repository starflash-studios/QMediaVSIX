// Decompiled with JetBrains decompiler
// Type: Windows.Networking.NetworkOperators.IMobileBroadbandModem
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Networking.NetworkOperators
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (MobileBroadbandModem))]
  [Guid(3493161234, 59897, 20327, 160, 61, 67, 24, 154, 49, 107, 241)]
  internal interface IMobileBroadbandModem
  {
    MobileBroadbandAccount CurrentAccount { get; }

    MobileBroadbandDeviceInformation DeviceInformation { get; }

    uint MaxDeviceServiceCommandSizeInBytes { get; }

    uint MaxDeviceServiceDataSizeInBytes { get; }

    IVectorView<MobileBroadbandDeviceServiceInformation> DeviceServices { get; }

    MobileBroadbandDeviceService GetDeviceService(Guid deviceServiceId);

    bool IsResetSupported { get; }

    [RemoteAsync]
    IAsyncAction ResetAsync();

    [RemoteAsync]
    IAsyncOperation<MobileBroadbandModemConfiguration> GetCurrentConfigurationAsync();

    MobileBroadbandNetwork CurrentNetwork { get; }
  }
}
