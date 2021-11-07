// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Sockets.IDatagramSocket2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Networking.Connectivity;

namespace Windows.Networking.Sockets
{
  [ExclusiveTo(typeof (DatagramSocket))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3627787092, 39581, 16773, 162, 10, 20, 36, 201, 194, 167, 205)]
  internal interface IDatagramSocket2 : IClosable
  {
    [RemoteAsync]
    [Overload("BindServiceNameAndAdapterAsync")]
    IAsyncAction BindServiceNameAsync(string localServiceName, NetworkAdapter adapter);
  }
}
