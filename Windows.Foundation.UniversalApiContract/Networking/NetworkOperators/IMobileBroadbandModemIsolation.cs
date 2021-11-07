// Decompiled with JetBrains decompiler
// Type: Windows.Networking.NetworkOperators.IMobileBroadbandModemIsolation
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.NetworkOperators
{
  [Guid(3043069932, 58977, 17200, 155, 180, 52, 128, 33, 46, 195, 84)]
  [ExclusiveTo(typeof (MobileBroadbandModemIsolation))]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  internal interface IMobileBroadbandModemIsolation
  {
    void AddAllowedHost(HostName host);

    void AddAllowedHostRange(HostName first, HostName last);

    [RemoteAsync]
    IAsyncAction ApplyConfigurationAsync();

    [RemoteAsync]
    IAsyncAction ClearConfigurationAsync();
  }
}
