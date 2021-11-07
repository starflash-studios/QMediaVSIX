// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Chat.ChatMessageNotificationTriggerDetails
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Chat
{
  /// <summary>Represents the message notification triggered from a registered background task. A chat app can receive notifications of incoming messages or send events by setting a task trigger and task entry point.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class ChatMessageNotificationTriggerDetails : 
    IChatMessageNotificationTriggerDetails,
    IChatMessageNotificationTriggerDetails2
  {
    /// <summary>Gets the message associated with the notification. This is either an incoming message or an outgoing message with a send status event.</summary>
    /// <returns>The chat message associated with the trigger.</returns>
    public extern ChatMessage ChatMessage { [MethodImpl] get; }

    /// <summary>Gets a Boolean value indicating if the background task should issue a toast notification for the message.</summary>
    /// <returns>A Boolean value indicating if the background task should issue a toast notification for the message.</returns>
    public extern bool ShouldDisplayToast { [MethodImpl] get; }

    /// <summary>Gets a Boolean value indicating that the background task should update the app's tile count for the message.</summary>
    /// <returns>A Boolean value indicating that the background task should update the app's tile count for the message.</returns>
    public extern bool ShouldUpdateDetailText { [MethodImpl] get; }

    /// <summary>Gets a Boolean value indicating if the background task should update the app’s lock screen count.</summary>
    /// <returns>A Boolean value indicating if the background task should update the app’s lock screen count.</returns>
    public extern bool ShouldUpdateBadge { [MethodImpl] get; }

    /// <summary>Gets a Boolean value indicating if the Windows Action Center should be updated with the message.</summary>
    /// <returns>A Boolean value indicating if the Windows Action Center should be updated.</returns>
    public extern bool ShouldUpdateActionCenter { [MethodImpl] get; }
  }
}
