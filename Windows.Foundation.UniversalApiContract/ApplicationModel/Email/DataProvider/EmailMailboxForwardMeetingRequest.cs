// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Email.DataProvider.EmailMailboxForwardMeetingRequest
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Email.DataProvider
{
  /// <summary>Details of a request to forward a meeting invitation.</summary>
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  public sealed class EmailMailboxForwardMeetingRequest : IEmailMailboxForwardMeetingRequest
  {
    /// <summary>Gets the mailbox ID for the meeting invitation to be forwarded.</summary>
    /// <returns>A mailbox ID.</returns>
    public extern string EmailMailboxId { [MethodImpl] get; }

    /// <summary>The message ID of the meeting invitation to be forwarded.</summary>
    /// <returns>A message ID.</returns>
    public extern string EmailMessageId { [MethodImpl] get; }

    /// <summary>Gets the list of recipients for the forwarded meeting invitation.</summary>
    /// <returns>A list of EmailRecipient objects specifying the recipients of the forwarded invitation.</returns>
    public extern IVectorView<EmailRecipient> Recipients { [MethodImpl] get; }

    /// <summary>Gets the subject of the forwarded meeting invitation.</summary>
    /// <returns>The subject line of the forwarded invitation.</returns>
    public extern string Subject { [MethodImpl] get; }

    /// <summary>Gets the forward header type.</summary>
    /// <returns>An EmailMessageBodyKind value describing the ForwardHeader content.</returns>
    public extern EmailMessageBodyKind ForwardHeaderType { [MethodImpl] get; }

    /// <summary>Gets the forward header for the forwarded invitation. The forward header is the set of message headers that appear at the beginning of the email message that holds the invitation. It is only used by data providers that generate emails when forwarding invitations.</summary>
    /// <returns>The forwarding header.</returns>
    public extern string ForwardHeader { [MethodImpl] get; }

    /// <summary>Gets the comment to be added to the forwarded meeting invitation. When a data provider forwards an invitation as an email message, the comment appears between the forward header and the body of the forwarded invitation.</summary>
    /// <returns>The comment to be added to the meeting invitation.</returns>
    public extern string Comment { [MethodImpl] get; }

    /// <summary>Informs the email client that the request was processed successfully.</summary>
    /// <returns>An asynchronous forward operation on an EmailMailboxForwardMeetingRequest.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction ReportCompletedAsync();

    /// <summary>Informs the client that the request was not processed successfully.</summary>
    /// <returns>An asynchronous forward operation on an EmailMailboxForwardMeetingRequest.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction ReportFailedAsync();
  }
}
