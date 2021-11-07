// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Email.EmailMailboxSyncStatus
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Email
{
  /// <summary>Defines the sync status of the mailbox.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum EmailMailboxSyncStatus
  {
    /// <summary>The mailbox is idle.</summary>
    Idle,
    /// <summary>The mailbox is currently syncing.</summary>
    Syncing,
    /// <summary>The mailbox is up to date.</summary>
    UpToDate,
    /// <summary>The mailbox has encountered an authentication error and cannot sync.</summary>
    AuthenticationError,
    /// <summary>The mailbox has encountered a policy error and cannot sync.</summary>
    PolicyError,
    /// <summary>The mailbox has encountered an unknown error and cannot sync.</summary>
    UnknownError,
    /// <summary>The account must be manually removed.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 131072)] ManualAccountRemovalRequired,
  }
}
