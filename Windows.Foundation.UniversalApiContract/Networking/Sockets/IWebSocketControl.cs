// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Sockets.IWebSocketControl
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Security.Credentials;

namespace Windows.Networking.Sockets
{
  /// <summary>Provides socket control data on an IWebSocket object.</summary>
  [Guid(784645571, 55717, 17754, 152, 17, 222, 36, 212, 83, 55, 233)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public interface IWebSocketControl
  {
    /// <summary>The size, in bytes, of the send buffer to be used for sending data on an IWebSocket object.</summary>
    /// <returns>The size, in bytes, of the send buffer to be used for sending data.</returns>
    uint OutboundBufferSizeInBytes { get; set; }

    /// <summary>The credential to use to authenticate to the WebSocket server through HTTP header authentication using an IWebSocket object.</summary>
    /// <returns>The credential to use to authenticate to the WebSocket server through HTTP header authentication.</returns>
    PasswordCredential ServerCredential { get; set; }

    /// <summary>The credential to use to authenticate to the proxy server through HTTP header authentication using an IWebSocket object.</summary>
    /// <returns>The credential to use to authenticate to the proxy server through HTTP header authentication.</returns>
    PasswordCredential ProxyCredential { get; set; }

    /// <summary>Gets a collection that can be used to add a list of supported sub-protocols that will be advertised to the server during the connect handshake.</summary>
    /// <returns>A collection that contains the WebSocket sub-protocols supported by the IWebSocket object.</returns>
    IVector<string> SupportedProtocols { get; }
  }
}
