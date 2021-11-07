// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Email.DataProvider.EmailMailboxUpdateMeetingResponseRequest
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Email.DataProvider
{
  /// <summary>Details of a request from a client to update a meeting response.</summary>
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class EmailMailboxUpdateMeetingResponseRequest : 
    IEmailMailboxUpdateMeetingResponseRequest
  {
    /// <summary>Gets the mailbox ID of the mailbox that holds the meeting response to be updated.</summary>
    /// <returns>A mailbox ID.</returns>
    public extern string EmailMailboxId { [MethodImpl] get; }

    /// <summary>Gets the message ID of the meeting response to be updated.</summary>
    /// <returns>A message ID.</returns>
    public extern string EmailMessageId { [MethodImpl] get; }

    /// <summary>Gets the response value to be used in updating the meeting response.</summary>
    /// <returns>An EmailMeetingResponseType value specifying the new response in the updated meeting response.</returns>
    public extern EmailMeetingResponseType Response { [MethodImpl] get; }

    /// <summary>Gets the subject to be used on the updated meeting response.</summary>
    /// <returns>The subject, as text.</returns>
    public extern string Subject { [MethodImpl] get; }

    /// <summary>Gets the comment to be used in updating the meeting response.</summary>
    /// <returns>The comment text.</returns>
    public extern string Comment { [MethodImpl] get; }

    /// <summary>Gets a value that indicates whether an update should be sent to the meeting owner when the meeting response is updated.</summary>
    /// <returns>When true, notify the owner that the meeting response has been updated.</returns>
    public extern bool SendUpdate { [MethodImpl] get; }

    /// <summary>Informs the email client that the request was processed successfully.</summary>
    /// <returns>An asynchronous update operation on an EmailMailboxUpdateMeetingResponseRequest.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction ReportCompletedAsync();

    /// <summary>Informs the client that the request was not processed successfully.</summary>
    /// <returns>An asynchronous update operation on an EmailMailboxUpdateMeetingResponseRequest.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction ReportFailedAsync();
  }
}
