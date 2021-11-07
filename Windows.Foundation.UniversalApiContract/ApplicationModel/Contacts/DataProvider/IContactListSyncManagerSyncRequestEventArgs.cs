// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.DataProvider.IContactListSyncManagerSyncRequestEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Contacts.DataProvider
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(361647532, 17517, 20240, 175, 194, 2, 104, 62, 197, 51, 166)]
  [ExclusiveTo(typeof (ContactListSyncManagerSyncRequestEventArgs))]
  internal interface IContactListSyncManagerSyncRequestEventArgs
  {
    ContactListSyncManagerSyncRequest Request { get; }

    Deferral GetDeferral();
  }
}
