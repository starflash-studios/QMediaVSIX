// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Sockets.IStreamSocket2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Networking.Connectivity;

namespace Windows.Networking.Sockets
{
  [Guid(701556085, 62228, 19721, 173, 240, 15, 189, 150, 127, 189, 159)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (StreamSocket))]
  internal interface IStreamSocket2 : IClosable
  {
    [Overload("ConnectWithProtectionLevelAndAdapterAsync")]
    [RemoteAsync]
    IAsyncAction ConnectAsync(
      HostName remoteHostName,
      string remoteServiceName,
      SocketProtectionLevel protectionLevel,
      NetworkAdapter adapter);
  }
}
