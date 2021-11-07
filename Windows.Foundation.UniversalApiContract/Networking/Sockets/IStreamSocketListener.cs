// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Sockets.IStreamSocketListener
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Sockets
{
  [ExclusiveTo(typeof (StreamSocketListener))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(4283511863, 57247, 19952, 191, 130, 14, 197, 215, 179, 90, 174)]
  internal interface IStreamSocketListener : IClosable
  {
    StreamSocketListenerControl Control { get; }

    StreamSocketListenerInformation Information { get; }

    [RemoteAsync]
    IAsyncAction BindServiceNameAsync(string localServiceName);

    [RemoteAsync]
    IAsyncAction BindEndpointAsync(HostName localHostName, string localServiceName);

    event TypedEventHandler<StreamSocketListener, StreamSocketListenerConnectionReceivedEventArgs> ConnectionReceived;
  }
}
