// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Chat.ChatMessageValidationStatus
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Chat
{
  /// <summary>Specifies the validation state of a chat message such as valid, no recipients, or too many attachments.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum ChatMessageValidationStatus
  {
    /// <summary>Valid</summary>
    Valid,
    /// <summary>No recipients</summary>
    NoRecipients,
    /// <summary>Invalid data</summary>
    InvalidData,
    /// <summary>Message too large</summary>
    MessageTooLarge,
    /// <summary>Too many recipients</summary>
    TooManyRecipients,
    /// <summary>Transport inactive</summary>
    TransportInactive,
    /// <summary>Transport not found</summary>
    TransportNotFound,
    /// <summary>Too many attachments</summary>
    TooManyAttachments,
    /// <summary>Invalid recipients</summary>
    InvalidRecipients,
    /// <summary>Invalid body</summary>
    InvalidBody,
    /// <summary>Invalid other</summary>
    InvalidOther,
    /// <summary>Valid with large message</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 196608)] ValidWithLargeMessage,
    /// <summary>Voice roaming restriction</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 196608)] VoiceRoamingRestriction,
    /// <summary>Data roaming restriction</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 196608)] DataRoamingRestriction,
  }
}
