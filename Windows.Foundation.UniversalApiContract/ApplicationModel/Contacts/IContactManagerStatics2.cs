// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.IContactManagerStatics2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Contacts
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2709055008, 18392, 18636, 150, 60, 149, 146, 182, 229, 16, 198)]
  [ExclusiveTo(typeof (ContactManager))]
  internal interface IContactManagerStatics2 : IContactManagerStatics
  {
    [Overload("RequestStoreAsync")]
    [RemoteAsync]
    IAsyncOperation<ContactStore> RequestStoreAsync();
  }
}
