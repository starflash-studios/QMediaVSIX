// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Email.EmailIrmInfo
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Email
{
  /// <summary>Represents email information rights management (IRM) info.</summary>
  [Activatable(typeof (IEmailIrmInfoFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  public sealed class EmailIrmInfo : IEmailIrmInfo
  {
    [MethodImpl]
    public extern EmailIrmInfo(DateTime expiration, EmailIrmTemplate irmTemplate);

    /// <summary>Initializes a new instance of the EmailIrmInfo class.</summary>
    [MethodImpl]
    public extern EmailIrmInfo();

    /// <summary>Gets or sets a Boolean value that indicates if an email message is allowed to be edited.</summary>
    /// <returns>A Boolean value that indicates if an email message is allowed to be edited.</returns>
    public extern bool CanEdit { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a Boolean value that indicates if the user can copy the contents of an email message to the clipboard.</summary>
    /// <returns>A Boolean value that indicates if the user can copy the contents of an email message to the clipboard.</returns>
    public extern bool CanExtractData { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a Boolean value that indicates if the email message is allowed to be forwarded.</summary>
    /// <returns>A Boolean value that indicates if the email message is allowed to be forwarded.</returns>
    public extern bool CanForward { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a Boolean value that indicates if the user is allowed to change any of the email recipients when responding.</summary>
    /// <returns>A Boolean value that indicates if the user is allowed to change any of the email recipients when responding.</returns>
    public extern bool CanModifyRecipientsOnResponse { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a Boolean value that indicates if the user is allowed to print the contents of the email message or any attachments.</summary>
    /// <returns>A Boolean value that indicates if the user is allowed to print the contents of the email message or any attachments.</returns>
    public extern bool CanPrintData { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a Boolean value that indicates if the recipient is allowed to remove information rights management (IRM) when responding.</summary>
    /// <returns>A Boolean value that indicates if the recipient is allowed to remove IRM when responding.</returns>
    public extern bool CanRemoveIrmOnResponse { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a Boolean value that indicates if the recipient is allowed to reply to the email message.</summary>
    /// <returns>A Boolean value that indicates if the recipient is allowed to reply to the email message.</returns>
    public extern bool CanReply { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a Boolean value that indicates if the recipient is allowed to reply all to the email message.</summary>
    /// <returns>A Boolean value that indicates if the recipient is allowed to reply all to the email message.</returns>
    public extern bool CanReplyAll { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the expiration date for the information rights management (IRM) permissions.</summary>
    /// <returns>The expiration date for the IRM permissions.</returns>
    public extern DateTime ExpirationDate { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a Boolean value that indicates if the sender is the information rights management (IRM) originator.</summary>
    /// <returns>A Boolean value that indicates if the sender is the information rights management (IRM) originator.</returns>
    public extern bool IsIrmOriginator { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a Boolean value that indicates if programmatic access to the message is allowed.</summary>
    /// <returns>A Boolean value that indicates if programmatic access to the message is allowed.</returns>
    public extern bool IsProgramaticAccessAllowed { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the EmailIrmTemplate used to create the information rights management (IRM) info.</summary>
    /// <returns>The EmailIrmTemplate used to create the information rights management (IRM) info.</returns>
    public extern EmailIrmTemplate Template { [MethodImpl] get; [MethodImpl] set; }
  }
}
