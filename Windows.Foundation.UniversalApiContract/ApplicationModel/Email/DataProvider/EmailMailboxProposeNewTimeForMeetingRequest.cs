// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Email.DataProvider.EmailMailboxProposeNewTimeForMeetingRequest
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Email.DataProvider
{
  /// <summary>Details of a request to propose a new time for a meeting.</summary>
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  public sealed class EmailMailboxProposeNewTimeForMeetingRequest : 
    IEmailMailboxProposeNewTimeForMeetingRequest
  {
    /// <summary>Gets the mailbox ID to use to send the proposed new meeting time.</summary>
    /// <returns>A mailbox ID.</returns>
    public extern string EmailMailboxId { [MethodImpl] get; }

    /// <summary>Gets the message ID of the meeting invitation for which a new time is being proposed.</summary>
    /// <returns>A message ID.</returns>
    public extern string EmailMessageId { [MethodImpl] get; }

    /// <summary>Gets the proposed new start time for the meeting.</summary>
    /// <returns>The new start time.</returns>
    public extern DateTime NewStartTime { [MethodImpl] get; }

    /// <summary>Gets the proposed new duration of the meeting.</summary>
    /// <returns>The new duration of the meeting.</returns>
    public extern TimeSpan NewDuration { [MethodImpl] get; }

    /// <summary>Gets the subject of the proposal for a new meeting time.</summary>
    /// <returns>A subject line. Data providers that use email use this value for the Subject of the email.</returns>
    public extern string Subject { [MethodImpl] get; }

    /// <summary>Gets the comment to be added to the proposal for a new meeting time.</summary>
    /// <returns>The comment, as text.</returns>
    public extern string Comment { [MethodImpl] get; }

    /// <summary>Informs the email client that the request was processed successfully.</summary>
    /// <returns>An asynchronous move operation on an EmailMailboxProposeNewTimeForMeetingRequest.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction ReportCompletedAsync();

    /// <summary>Informs the client that the request was not processed successfully.</summary>
    /// <returns>An asynchronous proposal operation on an EmailMailboxProposeNewTimeForMeetingRequest.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction ReportFailedAsync();
  }
}
