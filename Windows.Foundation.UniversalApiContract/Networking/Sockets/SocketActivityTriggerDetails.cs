// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Sockets.SocketActivityTriggerDetails
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Sockets
{
  /// <summary>A object instantiated by the background broker infrastructure and used by an app to retrieve details when a SocketActivityTrigger occurs.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  public sealed class SocketActivityTriggerDetails : ISocketActivityTriggerDetails
  {
    /// <summary>Get the reason the SocketActivityTrigger occurred.</summary>
    /// <returns>The reason the SocketActivityTrigger occurred.</returns>
    public extern SocketActivityTriggerReason Reason { [MethodImpl] get; }

    /// <summary>Get the SocketActivityInformation object for socket that caused the SocketActivityTrigger to occur.</summary>
    /// <returns>Socket activity information for socket that caused the SocketActivityTrigger to occur.</returns>
    public extern SocketActivityInformation SocketInformation { [MethodImpl] get; }
  }
}
