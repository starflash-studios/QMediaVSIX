// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Chat.ChatRecipientDeliveryInfo
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Chat
{
  /// <summary>Represent the delivery info about a chat recipient.</summary>
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class ChatRecipientDeliveryInfo : IChatRecipientDeliveryInfo
  {
    /// <summary>Initializes a new instance of the ChatRecipientDeliveryInfo class.</summary>
    [MethodImpl]
    public extern ChatRecipientDeliveryInfo();

    /// <summary>Gets or sets the transport address of the recipient.</summary>
    /// <returns>The transport address of the recipient.</returns>
    public extern string TransportAddress { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the time the message was sent to the recipient.</summary>
    /// <returns>The time the message was sent to the recipient.</returns>
    public extern IReference<DateTime> DeliveryTime { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the time the recipient read the message.</summary>
    /// <returns>The time the recipient read the message.</returns>
    public extern IReference<DateTime> ReadTime { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the category for the TransportErrorCode.</summary>
    /// <returns>The category for the TransportErrorCode.</returns>
    public extern ChatTransportErrorCodeCategory TransportErrorCodeCategory { [MethodImpl] get; }

    /// <summary>Gets the interpreted error code for the transport.</summary>
    /// <returns>The interpreted error code for the transport.</returns>
    public extern ChatTransportInterpretedErrorCode TransportInterpretedErrorCode { [MethodImpl] get; }

    /// <summary>Get the transport error code.</summary>
    /// <returns>The transport error code.</returns>
    public extern int TransportErrorCode { [MethodImpl] get; }

    /// <summary>Gets a Boolean value indicating whether the error for the message that was sent to the recipient is permanent.</summary>
    /// <returns>A Boolean value indicating whether the error for the message that was sent to the recipient is permanent.</returns>
    public extern bool IsErrorPermanent { [MethodImpl] get; }

    /// <summary>Gets the status of the message.</summary>
    /// <returns>The status of the message.</returns>
    public extern ChatMessageStatus Status { [MethodImpl] get; }
  }
}
