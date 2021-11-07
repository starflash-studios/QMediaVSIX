// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Email.DataProvider.EmailMailboxResolveRecipientsRequest
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Email.DataProvider
{
  /// <summary>Details of a request to resolve a list of recipients.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  public sealed class EmailMailboxResolveRecipientsRequest : IEmailMailboxResolveRecipientsRequest
  {
    /// <summary>Gets the mailbox ID where the recipients should be resolved.</summary>
    /// <returns>A mailbox ID.</returns>
    public extern string EmailMailboxId { [MethodImpl] get; }

    /// <summary>Gets the list of recipients to be resolved.</summary>
    /// <returns>A list of recipients.</returns>
    public extern IVectorView<string> Recipients { [MethodImpl] get; }

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction ReportCompletedAsync(
      IIterable<EmailRecipientResolutionResult> resolutionResults);

    /// <summary>Informs the client that the request was not processed successfully. Note that this means the operation failed to execute properly, and does not indicate anything about the recipients. See ReportCompletedAsync to understand how success or failure of resolution for individual recipients is reported.</summary>
    /// <returns>An asynchronous resolve operation on an EmailMailboxResolveRecipientsRequest.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction ReportFailedAsync();
  }
}
