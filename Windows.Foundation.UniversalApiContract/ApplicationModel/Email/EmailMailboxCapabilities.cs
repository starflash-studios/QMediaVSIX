// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Email.EmailMailboxCapabilities
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Email
{
  /// <summary>Represents the capabilities associated with an email mailbox.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class EmailMailboxCapabilities : 
    IEmailMailboxCapabilities,
    IEmailMailboxCapabilities2,
    IEmailMailboxCapabilities3
  {
    /// <summary>Gets or sets a Boolean value indicating whether an account is allowed to forward meeting requests.</summary>
    /// <returns>A Boolean value indicating whether an account is allowed to forward meeting requests.</returns>
    public extern bool CanForwardMeetings { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a Boolean value indicating whether an account is allowed to get and set automatic reply email messages intended for external audiences.</summary>
    /// <returns>A Boolean value indicating whether an account is allowed to get and set automatic reply email messages intended for external audiences.</returns>
    public extern bool CanGetAndSetExternalAutoReplies { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a Boolean value indicating whether an account is allowed to get and set automatic reply email messages intended for internal audiences.</summary>
    /// <returns>A Boolean value indicating whether an account is allowed to get and set automatic reply email messages intended for internal audiences.</returns>
    public extern bool CanGetAndSetInternalAutoReplies { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a Boolean value indicating whether the email mailbox is allowed to update meeting responses.</summary>
    /// <returns>The Boolean value indicating whether the email mailbox is allowed to update meeting responses.</returns>
    public extern bool CanUpdateMeetingResponses { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a Boolean value indicating whether a search of specific folders on the server can be initiated from this email mailbox.</summary>
    /// <returns>The Boolean value indicating whether a search of specific folders on the server can be initiated from this email mailbox.</returns>
    public extern bool CanServerSearchFolders { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a Boolean value indicating whether a search of the server can be initiated from this email mailbox.</summary>
    /// <returns>The Boolean value indicating whether a search of the server can be initiated from this email mailbox.</returns>
    public extern bool CanServerSearchMailbox { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a Boolean value indicating whether an account is allowed to propose a new meeting time.</summary>
    /// <returns>A Boolean value indicating whether an account is allowed to propose a new meeting time.</returns>
    public extern bool CanProposeNewTimeForMeetings { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a Boolean value indicating whether the email mailbox is allowed to attempt smart send.</summary>
    /// <returns>The Boolean value indicating whether the email mailbox is allowed to attempt smart send.</returns>
    public extern bool CanSmartSend { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a Boolean value that indicates whether the email mailbox is capable of resolving recipients.</summary>
    /// <returns>The Boolean value that indicates whether the email mailbox is capable of resolving recipients.</returns>
    public extern bool CanResolveRecipients { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a Boolean value that indicates whether the email mailbox is capable of validating certificates.</summary>
    /// <returns>The Boolean value that indicates whether the email mailbox is capable of validating certificates.</returns>
    public extern bool CanValidateCertificates { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a Boolean value indicating if folders in the mailbox can be emptied.</summary>
    /// <returns>A Boolean value indicating if folders in the mailbox can be emptied.</returns>
    public extern bool CanEmptyFolder { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a Boolean value indicating if folders can be created in the mailbox.</summary>
    /// <returns>A Boolean value indicating if folders can be created in the mailbox.</returns>
    public extern bool CanCreateFolder { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a Boolean value indicating if folders can be deleted from the mailbox.</summary>
    /// <returns>A Boolean value indicating if folders can be deleted from the mailbox.</returns>
    public extern bool CanDeleteFolder { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a Boolean value indicating if folders in the mailbox can be moved.</summary>
    /// <returns>A Boolean value indicating if folders in the mailbox can be moved.</returns>
    public extern bool CanMoveFolder { [MethodImpl] get; [MethodImpl] set; }
  }
}
