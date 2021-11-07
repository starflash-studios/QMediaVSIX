// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Email.EmailManager
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.System;

namespace Windows.ApplicationModel.Email
{
  /// <summary>Allows an application to launch the email application with a new message displayed. Use this to allow users to send email from your application.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IEmailManagerStatics2), 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IEmailManagerStatics3), 196608, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [Static(typeof (IEmailManagerStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public static class EmailManager
  {
    /// <summary>Gets the EmailManagerForUser object for the specified user.</summary>
    /// <param name="user">The user account to use to get the EmailManagerForUser object.</param>
    /// <returns>Returns the email manager for the account specified by the *user* parameter.</returns>
    [MethodImpl]
    public static extern EmailManagerForUser GetForUser(User user);

    /// <summary>Gets an email store that is within the specified scope.</summary>
    /// <param name="accessType">The enumerator of scope.</param>
    /// <returns>The requested email store.</returns>
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<EmailStore> RequestStoreAsync(
      EmailStoreAccessType accessType);

    /// <summary>Launches the email application with a new message displayed.</summary>
    /// <param name="message">The email message that is displayed when the email application is launched.</param>
    /// <returns>An asynchronous action used to indicate when the operation has completed.</returns>
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncAction ShowComposeNewEmailAsync(EmailMessage message);
  }
}
