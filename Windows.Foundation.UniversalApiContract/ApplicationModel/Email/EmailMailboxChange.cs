// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Email.EmailMailboxChange
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Email
{
  /// <summary>The functionality described in this topic is not available to all UWP apps. As part of the store app submission process, Microsoft must approve your use of these APIs and provision your developer account before you can publish an app that uses them.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  public sealed class EmailMailboxChange : IEmailMailboxChange
  {
    /// <summary>Gets the type of change that was made to the mailbox. This includes whether it was a folder or message that was changed and whether the item was created, deleted, or modified, or if change tracking was lost for this change.</summary>
    /// <returns>The type of change that was made to the mailbox.</returns>
    public extern EmailMailboxChangeType ChangeType { [MethodImpl] get; }

    /// <summary>Gets the flags that indicate what actions have been affected on the mailbox.</summary>
    /// <returns>The flags that indicate what actions have been affected on the mailbox.</returns>
    public extern IVector<EmailMailboxAction> MailboxActions { [MethodImpl] get; }

    /// <summary>Gets the message to which the change applies.</summary>
    /// <returns>The message to which the change applies.</returns>
    public extern EmailMessage Message { [MethodImpl] get; }

    /// <summary>Gets the folder to which the change applies.</summary>
    /// <returns>The folder to which the change applies.</returns>
    public extern EmailFolder Folder { [MethodImpl] get; }
  }
}
