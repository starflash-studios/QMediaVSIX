// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Email.EmailMailboxActionKind
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Email
{
  /// <summary>Defines the kind of action to be taken.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum EmailMailboxActionKind
  {
    /// <summary>Mark the email message as seen.</summary>
    MarkMessageAsSeen,
    /// <summary>Mark the email message as having been read.</summary>
    MarkMessageRead,
    /// <summary>Change the flag state on the email message.</summary>
    ChangeMessageFlagState,
    /// <summary>Move the email message.</summary>
    MoveMessage,
    /// <summary>Save a draft of the email message.</summary>
    SaveDraft,
    /// <summary>Send the email message.</summary>
    SendMessage,
    /// <summary>Create a reply email message addressed to the sender in response to this email message.</summary>
    CreateResponseReplyMessage,
    /// <summary>Create a reply email message addressed to the sender and all recipients in response to this email message.</summary>
    CreateResponseReplyAllMessage,
    /// <summary>Create an email message to be forwarded containing the content of this email message.</summary>
    CreateResponseForwardMessage,
    /// <summary>Move this folder.</summary>
    MoveFolder,
    /// <summary>Enable sync for this folder.</summary>
    MarkFolderForSyncEnabled,
  }
}
