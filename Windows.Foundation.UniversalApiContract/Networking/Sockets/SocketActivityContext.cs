// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Sockets.SocketActivityContext
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Networking.Sockets
{
  /// <summary>The context associated with a socket while transferring ownership of the socket between an app and the socket brokering service.</summary>
  [Activatable(typeof (ISocketActivityContextFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class SocketActivityContext : ISocketActivityContext
  {
    /// <summary>Constructs a new SocketActivityContext object with given context data.</summary>
    /// <param name="data">Context data to be used when the socket broker notifies the app of socket activity.</param>
    [MethodImpl]
    public extern SocketActivityContext(IBuffer data);

    /// <summary>Get the serialized data to associate the app context to a transferred socket.</summary>
    /// <returns>The serialized data to associate the app context to a transferred socket.</returns>
    public extern IBuffer Data { [MethodImpl] get; }
  }
}
