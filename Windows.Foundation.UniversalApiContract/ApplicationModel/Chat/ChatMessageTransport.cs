// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Chat.ChatMessageTransport
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Chat
{
  /// <summary>Represents the identity of a transport for sending and receiving messages. Physically, a chat message transport is a SIM slot on the phone.</summary>
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class ChatMessageTransport : IChatMessageTransport, IChatMessageTransport2
  {
    /// <summary>Gets a Boolean value that indicates whether the current application is set as the messaging notification provider.</summary>
    /// <returns>A value indicating if the app is set as a notification provider.</returns>
    public extern bool IsAppSetAsNotificationProvider { [MethodImpl] get; }

    /// <summary>Gets a Boolean value that indicates whether the messaging transport is active.</summary>
    /// <returns>A value indicating if the transport is active.</returns>
    public extern bool IsActive { [MethodImpl] get; }

    /// <summary>Gets a descriptive name identifying the messaging transport.</summary>
    /// <returns>The friendly name for the transport.</returns>
    public extern string TransportFriendlyName { [MethodImpl] get; }

    /// <summary>Gets the messaging transport’s identifier.</summary>
    /// <returns>The ID of the transport.</returns>
    public extern string TransportId { [MethodImpl] get; }

    /// <summary>Sets the current application to handle messaging notifications.</summary>
    /// <returns>An asynchronous action.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction RequestSetAsNotificationProviderAsync();

    /// <summary>Gets the configuration of the message transport.</summary>
    /// <returns>The configuration of the message transport.</returns>
    public extern ChatMessageTransportConfiguration Configuration { [MethodImpl] get; }

    /// <summary>Gets the type of the message transport.</summary>
    /// <returns>The type of the message transport.</returns>
    public extern ChatMessageTransportKind TransportKind { [MethodImpl] get; }
  }
}
