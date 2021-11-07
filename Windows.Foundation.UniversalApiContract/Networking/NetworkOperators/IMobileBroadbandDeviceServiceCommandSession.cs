// Decompiled with JetBrains decompiler
// Type: Windows.Networking.NetworkOperators.IMobileBroadbandDeviceServiceCommandSession
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Networking.NetworkOperators
{
  [ExclusiveTo(typeof (MobileBroadbandDeviceServiceCommandSession))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(4228483653, 37179, 18708, 182, 195, 174, 99, 4, 89, 62, 117)]
  internal interface IMobileBroadbandDeviceServiceCommandSession
  {
    [RemoteAsync]
    IAsyncOperation<MobileBroadbandDeviceServiceCommandResult> SendQueryCommandAsync(
      uint commandId,
      IBuffer data);

    [RemoteAsync]
    IAsyncOperation<MobileBroadbandDeviceServiceCommandResult> SendSetCommandAsync(
      uint commandId,
      IBuffer data);

    void CloseSession();
  }
}
