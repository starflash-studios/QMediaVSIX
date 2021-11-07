// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Sockets.WebSocketError
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Web;

namespace Windows.Networking.Sockets
{
  /// <summary>Provides socket error status on a MessageWebSocket or StreamWebSocket object.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IWebSocketErrorStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [DualApiPartition(version = 100794368)]
  public static class WebSocketError
  {
    /// <summary>Gets a WebErrorStatus value based on an error encountered by a WebSocket operation.</summary>
    /// <param name="hresult">The error encountered by a WebSocket operation represented as an **HRESULT**.</param>
    /// <returns>The socket error status value for a WebSocket operation.</returns>
    [MethodImpl]
    public static extern WebErrorStatus GetStatus(int hresult);
  }
}
