// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Chat.RcsManager
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Chat
{
  /// <summary>Provides access to APIs for handling Rich Communication Services (RCS) messages.</summary>
  [Static(typeof (IRcsManagerStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [Static(typeof (IRcsManagerStatics2), 458752, "Windows.Foundation.UniversalApiContract")]
  public static class RcsManager
  {
    /// <summary>Occurs when one or more RcsTransport instances are added or removed from the list of RcsTransport instances that would be returned from RcsManager.GetTransportsAsync.</summary>
    public static extern event EventHandler<object> TransportListChanged;

    /// <summary>Gets the RcsEndUserMessageManager.</summary>
    /// <returns>The end user message manager.</returns>
    [MethodImpl]
    public static extern RcsEndUserMessageManager GetEndUserMessageManager();

    /// <summary>Gets all instances of RcsTransport.</summary>
    /// <returns>A list of RcsTransport instances.</returns>
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<IVectorView<RcsTransport>> GetTransportsAsync();

    /// <summary>Gets an instance of RcsTransport for the specified transport ID.</summary>
    /// <param name="transportId">The ID of the transport to retrieve.</param>
    /// <returns>An instance of the transport specified by the *transportId* parameter.</returns>
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<RcsTransport> GetTransportAsync(
      string transportId);

    /// <summary>Asynchronously allows a user to leave a particular conversation.</summary>
    /// <param name="conversation">The conversation to leave.</param>
    /// <returns>An async action indicating that the operation has completed.</returns>
    [MethodImpl]
    public static extern IAsyncAction LeaveConversationAsync(
      ChatConversation conversation);
  }
}
