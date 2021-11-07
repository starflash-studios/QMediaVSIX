// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Sockets.WebSocketKeepAlive
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.ApplicationModel.Background;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Sockets
{
  /// <summary>Provides the ability to send a WebSocket protocol keep-alive on a connected WebSocket.</summary>
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class WebSocketKeepAlive : IBackgroundTask
  {
    /// <summary>Creates a new WebSocketKeepAlive object.</summary>
    [MethodImpl]
    public extern WebSocketKeepAlive();

    /// <summary>Sends a WebSocket protocol keep-alive on a connected WebSocket.</summary>
    /// <param name="taskInstance">Specific instance of a background task.</param>
    [MethodImpl]
    public extern void Run(IBackgroundTaskInstance taskInstance);
  }
}
