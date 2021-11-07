// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.IContactListSyncManager2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Contacts
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(2841186887, 47957, 20003, 129, 40, 55, 1, 52, 168, 93, 13)]
  [ExclusiveTo(typeof (ContactListSyncManager))]
  internal interface IContactListSyncManager2
  {
    ContactListSyncStatus Status { set; }

    DateTime LastSuccessfulSyncTime { set; }

    DateTime LastAttemptedSyncTime { set; }
  }
}
