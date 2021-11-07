// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Sockets.IStreamSocket
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Networking.Sockets
{
  [ExclusiveTo(typeof (StreamSocket))]
  [Guid(1772236019, 64635, 18519, 175, 56, 246, 231, 222, 106, 91, 73)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IStreamSocket : IClosable
  {
    StreamSocketControl Control { get; }

    StreamSocketInformation Information { get; }

    IInputStream InputStream { get; }

    IOutputStream OutputStream { get; }

    [Overload("ConnectWithEndpointPairAsync")]
    IAsyncAction ConnectAsync(EndpointPair endpointPair);

    [Overload("ConnectAsync")]
    [RemoteAsync]
    [DefaultOverload]
    IAsyncAction ConnectAsync(HostName remoteHostName, string remoteServiceName);

    [Overload("ConnectWithEndpointPairAndProtectionLevelAsync")]
    IAsyncAction ConnectAsync(
      EndpointPair endpointPair,
      SocketProtectionLevel protectionLevel);

    [Overload("ConnectWithProtectionLevelAsync")]
    [RemoteAsync]
    IAsyncAction ConnectAsync(
      HostName remoteHostName,
      string remoteServiceName,
      SocketProtectionLevel protectionLevel);

    [RemoteAsync]
    IAsyncAction UpgradeToSslAsync(
      SocketProtectionLevel protectionLevel,
      HostName validationHostName);
  }
}
