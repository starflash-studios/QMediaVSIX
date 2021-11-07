// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Email.EmailSpecialFolderKind
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Email
{
  /// <summary>Defines the email special folders.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum EmailSpecialFolderKind
  {
    /// <summary>This is not a special folder.</summary>
    None,
    /// <summary>This is the root folder.</summary>
    Root,
    /// <summary>This is the inbox folder.</summary>
    Inbox,
    /// <summary>This is the outbox folder.</summary>
    Outbox,
    /// <summary>This is the drafts folder.</summary>
    Drafts,
    /// <summary>This is the deleted items folder.</summary>
    DeletedItems,
    /// <summary>This is the sent items folder.</summary>
    Sent,
  }
}
