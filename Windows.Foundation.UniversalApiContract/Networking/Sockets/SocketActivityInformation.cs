// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Sockets.SocketActivityInformation
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Sockets
{
  /// <summary>Provides information on the transferred socket from the Socket Broker.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [Static(typeof (ISocketActivityInformationStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class SocketActivityInformation : ISocketActivityInformation
  {
    /// <summary>The background task ID used while transferring ownership of the socket.</summary>
    /// <returns>The background task ID.</returns>
    public extern Guid TaskId { [MethodImpl] get; }

    /// <summary>A unique string for this app used to identify the transferred socket. This is passed by the app while transferring the socket ownership to the service.</summary>
    /// <returns>A unique string to identify the transferred socket.</returns>
    public extern string Id { [MethodImpl] get; }

    /// <summary>Gets a SocketActivityKind enumeration value that identifies socket kind.</summary>
    /// <returns>The socket kind.</returns>
    public extern SocketActivityKind SocketKind { [MethodImpl] get; }

    /// <summary>Get the context associated while transferring ownership of the socket.</summary>
    /// <returns>The context associated while transferring ownership of the socket.</returns>
    public extern SocketActivityContext Context { [MethodImpl] get; }

    /// <summary>Based on the socket type, the app can reclaim the ownership of the appropriate DatagramSocket.</summary>
    /// <returns>The DatagramSocket to reclaim.</returns>
    public extern DatagramSocket DatagramSocket { [MethodImpl] get; }

    /// <summary>Based on the socket type, the app can reclaim the ownership of the appropriate StreamSocket.</summary>
    /// <returns>The StreamSocket to reclaim.</returns>
    public extern StreamSocket StreamSocket { [MethodImpl] get; }

    /// <summary>Based on the socket type, the app can reclaim the ownership of the appropriate StreamSocketListener.</summary>
    /// <returns>The StreamSocketListener to reclaim.</returns>
    public extern StreamSocketListener StreamSocketListener { [MethodImpl] get; }

    /// <summary>Gets a list of all the sockets transferred to the socket brokering service by this app.</summary>
    /// <returns>A list of all the sockets transferred to the socket brokering service by this app.</returns>
    public static extern IMapView<string, SocketActivityInformation> AllSockets { [MethodImpl] get; }
  }
}
