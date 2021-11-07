// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Email.IEmailMailboxSyncManager
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Email
{
  [Guid(1367000410, 13713, 19293, 133, 188, 199, 29, 222, 134, 34, 99)]
  [ExclusiveTo(typeof (EmailMailboxSyncManager))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IEmailMailboxSyncManager
  {
    EmailMailboxSyncStatus Status { get; }

    DateTime LastSuccessfulSyncTime { get; }

    DateTime LastAttemptedSyncTime { get; }

    [RemoteAsync]
    IAsyncOperation<bool> SyncAsync();

    event TypedEventHandler<EmailMailboxSyncManager, object> SyncStatusChanged;
  }
}
