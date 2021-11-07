// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Email.EmailMailboxChangeType
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Email
{
  /// <summary>Defines the type of change made to the mailbox item.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum EmailMailboxChangeType
  {
    /// <summary>A message was created.</summary>
    MessageCreated,
    /// <summary>A message was modified.</summary>
    MessageModified,
    /// <summary>A message was deleted.</summary>
    MessageDeleted,
    /// <summary>A folder was created.</summary>
    FolderCreated,
    /// <summary>A folder was modified.</summary>
    FolderModified,
    /// <summary>A folder was deleted.</summary>
    FolderDeleted,
    /// <summary>Change unknown because change tracking was lost.</summary>
    ChangeTrackingLost,
  }
}
