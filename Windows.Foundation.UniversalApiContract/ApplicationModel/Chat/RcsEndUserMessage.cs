// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Chat.RcsEndUserMessage
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Chat
{
  /// <summary>Represents a Rich Communication Services (RCS) end user message.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  public sealed class RcsEndUserMessage : IRcsEndUserMessage
  {
    /// <summary>Gets the ID of the transport where this message originated.</summary>
    /// <returns>The ID of the transport where this message originated.</returns>
    public extern string TransportId { [MethodImpl] get; }

    /// <summary>Gets the title of the message.</summary>
    /// <returns>The title of the message.</returns>
    public extern string Title { [MethodImpl] get; }

    /// <summary>Gets the contents of the message.</summary>
    /// <returns>The contents of the message.</returns>
    public extern string Text { [MethodImpl] get; }

    /// <summary>Gets a Boolean value that specifies whether a PIN is required to be sent back with the response.</summary>
    /// <returns>A Boolean value that specifies whether a PIN is required to be sent back with the response.</returns>
    public extern bool IsPinRequired { [MethodImpl] get; }

    /// <summary>Gets the actions to which the user can respond.</summary>
    /// <returns>The actions to which the user can respond.</returns>
    public extern IVectorView<RcsEndUserMessageAction> Actions { [MethodImpl] get; }

    /// <summary>Asynchronously sends the user's selection back.</summary>
    /// <param name="action">Specifies the label of the action.</param>
    /// <returns>An async action indicating that the operation has completed.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction SendResponseAsync(RcsEndUserMessageAction action);

    /// <summary>Asynchronously sends the user's selection back with the specified PIN.</summary>
    /// <param name="action">Specifies the label of the action.</param>
    /// <param name="pin">The PIN to send.</param>
    /// <returns>An async action indicating that the operation has completed.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction SendResponseWithPinAsync(
      RcsEndUserMessageAction action,
      string pin);
  }
}
