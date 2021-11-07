// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Sockets.IWebSocketControl2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Security.Cryptography.Certificates;

namespace Windows.Networking.Sockets
{
  /// <summary>Provides socket control data on an IWebSocket object. This interface extends the IWebSocketControl interface with an additional property.</summary>
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(2042871299, 62154, 17950, 175, 78, 150, 101, 188, 45, 6, 32)]
  public interface IWebSocketControl2 : IWebSocketControl
  {
    /// <summary>Gets a list of ignorable server certificate errors. Get this list and add ChainValidationResult values for server certificate errors that you wish to ignore during the secure WebSocket (**wss://** protocol) server certificate validation process.</summary>
    /// <returns>A list of ChainValidationResult values indicating the server certificate errors to ignore when validating server certificates. By default, the list is empty, and all errors cause validation to fail.</returns>
    IVector<ChainValidationResult> IgnorableServerCertificateErrors { get; }
  }
}
