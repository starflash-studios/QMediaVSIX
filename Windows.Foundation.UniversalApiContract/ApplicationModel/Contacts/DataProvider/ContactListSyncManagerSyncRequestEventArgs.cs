// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.DataProvider.ContactListSyncManagerSyncRequestEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Contacts.DataProvider
{
  /// <summary>Encapsulates information about a request to sync a contact list.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  public sealed class ContactListSyncManagerSyncRequestEventArgs : 
    IContactListSyncManagerSyncRequestEventArgs
  {
    /// <summary>Gets the ContactListSyncManagerSyncRequest object associated with this request.</summary>
    /// <returns>A ContactListSyncManagerSyncRequest object describing the sync request.</returns>
    public extern ContactListSyncManagerSyncRequest Request { [MethodImpl] get; }

    /// <summary>Gets a deferral object for this operation.</summary>
    /// <returns>A Deferral object that your code uses to signal when it has finished processing this request.</returns>
    [MethodImpl]
    public extern Deferral GetDeferral();
  }
}
