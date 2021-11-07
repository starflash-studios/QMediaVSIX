// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.IContactChangeReader
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Contacts
{
  [ExclusiveTo(typeof (ContactChangeReader))]
  [Guid(561191418, 11532, 17120, 169, 218, 62, 205, 86, 167, 138, 71)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IContactChangeReader
  {
    void AcceptChanges();

    void AcceptChangesThrough(ContactChange lastChangeToAccept);

    [RemoteAsync]
    IAsyncOperation<IVectorView<ContactChange>> ReadBatchAsync();
  }
}
