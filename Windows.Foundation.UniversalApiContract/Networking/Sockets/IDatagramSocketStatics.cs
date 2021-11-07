// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Sockets.IDatagramSocketStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Sockets
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (DatagramSocket))]
  [Guid(3922078446, 5268, 18977, 187, 126, 133, 137, 252, 117, 29, 157)]
  internal interface IDatagramSocketStatics
  {
    [RemoteAsync]
    [Overload("GetEndpointPairsAsync")]
    IAsyncOperation<IVectorView<EndpointPair>> GetEndpointPairsAsync(
      HostName remoteHostName,
      string remoteServiceName);

    [RemoteAsync]
    [Overload("GetEndpointPairsWithSortOptionsAsync")]
    IAsyncOperation<IVectorView<EndpointPair>> GetEndpointPairsAsync(
      HostName remoteHostName,
      string remoteServiceName,
      HostNameSortOptions sortOptions);
  }
}
