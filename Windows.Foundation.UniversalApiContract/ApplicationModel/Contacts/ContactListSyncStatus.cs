// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.ContactListSyncStatus
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Contacts
{
  /// <summary>Defines the ContactList sync status.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum ContactListSyncStatus
  {
    /// <summary>Idle.</summary>
    Idle,
    /// <summary>Currently syncing.</summary>
    Syncing,
    /// <summary>The contact list is up-to-date.</summary>
    UpToDate,
    /// <summary>There was an authentication error.</summary>
    AuthenticationError,
    /// <summary>There was a policy error.</summary>
    PolicyError,
    /// <summary>An unknown error occurred.</summary>
    UnknownError,
    /// <summary>The account must be manually removed.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 131072)] ManualAccountRemovalRequired,
  }
}
