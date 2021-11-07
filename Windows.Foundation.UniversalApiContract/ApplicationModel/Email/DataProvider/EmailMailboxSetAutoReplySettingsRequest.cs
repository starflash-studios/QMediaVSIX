// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Email.DataProvider.EmailMailboxSetAutoReplySettingsRequest
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Email.DataProvider
{
  /// <summary>Details of a request to set auto-reply settings.</summary>
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  public sealed class EmailMailboxSetAutoReplySettingsRequest : 
    IEmailMailboxSetAutoReplySettingsRequest
  {
    /// <summary>Gets the mailbox ID whose auto-reply settings are being set.</summary>
    /// <returns>A mailbox ID.</returns>
    public extern string EmailMailboxId { [MethodImpl] get; }

    /// <summary>Gets the new settings.</summary>
    /// <returns>An EmailMailboxAutoReplySettings object describing the new auto-reply settings.</returns>
    public extern EmailMailboxAutoReplySettings AutoReplySettings { [MethodImpl] get; }

    /// <summary>Informs the email client that the request was processed successfully.</summary>
    /// <returns>An asynchronous set operation on an EmailMailboxSetAutoReplySettingsRequest.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction ReportCompletedAsync();

    /// <summary>Informs the client that the request was not processed successfully.</summary>
    /// <returns>An asynchronous set operation on an EmailMailboxSetAutoReplySettingsRequest.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction ReportFailedAsync();
  }
}
