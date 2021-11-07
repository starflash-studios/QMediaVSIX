// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.IContactReader
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Contacts
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3549946926, 5256, 17138, 191, 100, 37, 63, 72, 132, 191, 237)]
  [ExclusiveTo(typeof (ContactReader))]
  internal interface IContactReader
  {
    [RemoteAsync]
    IAsyncOperation<ContactBatch> ReadBatchAsync();

    IVectorView<ContactMatchReason> GetMatchingPropertiesWithMatchReason(
      Contact contact);
  }
}
