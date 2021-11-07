// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Email.DataProvider.EmailMailboxDownloadAttachmentRequest
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Email.DataProvider
{
  /// <summary>Details of a request to download an attachment.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Threading(ThreadingModel.Both)]
  public sealed class EmailMailboxDownloadAttachmentRequest : IEmailMailboxDownloadAttachmentRequest
  {
    /// <summary>Gets the email mailbox ID.</summary>
    /// <returns>The mailbox ID of the mailbox that holds the attachment.</returns>
    public extern string EmailMailboxId { [MethodImpl] get; }

    /// <summary>Gets the email message ID of the message associated with the attachment.</summary>
    /// <returns>The email message ID.</returns>
    public extern string EmailMessageId { [MethodImpl] get; }

    /// <summary>Gets the attachment ID of the attachment to be downloaded.</summary>
    /// <returns>The ID of the attachment. Use the EmailAttachment.Id value for the attachment you want to download.</returns>
    public extern string EmailAttachmentId { [MethodImpl] get; }

    /// <summary>Informs the email client that the request was processed successfully.</summary>
    /// <returns>An asynchronous download operation on an EmailMailboxDownloadAttachmentRequest object.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction ReportCompletedAsync();

    /// <summary>Informs the client that the request was not processed successfully.</summary>
    /// <returns>An asynchronous download operation on an EmailMailboxDownloadAttachmentRequest.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction ReportFailedAsync();
  }
}
