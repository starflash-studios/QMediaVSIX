// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Email.IEmailMailboxSyncManager2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Email
{
  [ExclusiveTo(typeof (EmailMailboxSyncManager))]
  [Guid(3448621438, 38337, 20361, 129, 183, 230, 174, 203, 102, 149, 252)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IEmailMailboxSyncManager2
  {
    EmailMailboxSyncStatus Status { set; }

    DateTime LastSuccessfulSyncTime { set; }

    DateTime LastAttemptedSyncTime { set; }
  }
}
