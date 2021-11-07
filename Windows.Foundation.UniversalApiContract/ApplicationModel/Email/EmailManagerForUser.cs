// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Email.EmailManagerForUser
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.System;

namespace Windows.ApplicationModel.Email
{
  /// <summary>Represents a service that source apps can call to access email data for a specific user.</summary>
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class EmailManagerForUser : IEmailManagerForUser
  {
    /// <summary>Launches the email application with a new message displayed.</summary>
    /// <param name="message">The email message that is displayed when the email application is launched.</param>
    /// <returns>An asynchronous action used to indicate when the operation has completed.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction ShowComposeNewEmailAsync(EmailMessage message);

    /// <summary>Asynchronously returns the EmailStore from the system.</summary>
    /// <param name="accessType">Specifies the access type, such as **AllMailboxesLimitedReadWrite** for all mailboxes or **AppMailboxesReadWrite** for the calling app's mailboxes.</param>
    /// <returns>Returns the EmailStore.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<EmailStore> RequestStoreAsync(
      EmailStoreAccessType accessType);

    /// <summary>Gets the User represented by this email manager.</summary>
    /// <returns>The User represented by this email manager.</returns>
    public extern User User { [MethodImpl] get; }
  }
}
