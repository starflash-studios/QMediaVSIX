// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Connectivity.IConnectivityManagerStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Connectivity
{
  [ExclusiveTo(typeof (ConnectivityManager))]
  [Guid(1361106097, 20401, 18608, 175, 201, 66, 224, 9, 42, 129, 100)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IConnectivityManagerStatics
  {
    [RemoteAsync]
    IAsyncOperation<ConnectionSession> AcquireConnectionAsync(
      CellularApnContext cellularApnContext);

    void AddHttpRoutePolicy(RoutePolicy routePolicy);

    void RemoveHttpRoutePolicy(RoutePolicy routePolicy);
  }
}
