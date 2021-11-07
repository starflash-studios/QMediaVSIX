// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Sockets.IStreamSocketListener2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Networking.Connectivity;

namespace Windows.Networking.Sockets
{
  [ExclusiveTo(typeof (StreamSocketListener))]
  [Guid(1703788862, 47934, 17496, 178, 50, 237, 16, 136, 105, 75, 152)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IStreamSocketListener2 : IClosable
  {
    [RemoteAsync]
    [Overload("BindServiceNameWithProtectionLevelAsync")]
    IAsyncAction BindServiceNameAsync(
      string localServiceName,
      SocketProtectionLevel protectionLevel);

    [RemoteAsync]
    [Overload("BindServiceNameWithProtectionLevelAndAdapterAsync")]
    IAsyncAction BindServiceNameAsync(
      string localServiceName,
      SocketProtectionLevel protectionLevel,
      NetworkAdapter adapter);
  }
}
