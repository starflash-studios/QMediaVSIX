// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Email.DataProvider.EmailMailboxGetAutoReplySettingsRequest
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Email.DataProvider
{
  /// <summary>Details of a request to get auto-reply settings.</summary>
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  public sealed class EmailMailboxGetAutoReplySettingsRequest : 
    IEmailMailboxGetAutoReplySettingsRequest
  {
    /// <summary>Gets the email box ID of the mailbox whose settings are being retrieved.</summary>
    /// <returns>A mailbox ID.</returns>
    public extern string EmailMailboxId { [MethodImpl] get; }

    /// <summary>Gets the requested format of the auto-reply settings.</summary>
    /// <returns>An EmailMailboxAutoReplyMessageResponseKind value representing the requested format of the returned settings.</returns>
    public extern EmailMailboxAutoReplyMessageResponseKind RequestedFormat { [MethodImpl] get; }

    /// <summary>Informs the email client that the request was processed successfully.</summary>
    /// <param name="autoReplySettings">The requested settings, in the requested format.</param>
    /// <returns>An asynchronous get operation on an EmailMailboxGetAutoReplySettingsRequest.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction ReportCompletedAsync(
      EmailMailboxAutoReplySettings autoReplySettings);

    /// <summary>Informs the client that the request was not processed successfully.</summary>
    /// <returns>An asynchronous get operation on an EmailMailboxGetAutoReplySettingsRequest.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction ReportFailedAsync();
  }
}
