// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.IContactInformation
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.ApplicationModel.Contacts
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (ContactInformation))]
  [Guid(660518612, 27182, 17016, 169, 20, 228, 96, 213, 240, 136, 246)]
  internal interface IContactInformation
  {
    string Name { get; }

    [RemoteAsync]
    IAsyncOperation<IRandomAccessStreamWithContentType> GetThumbnailAsync();

    IVectorView<ContactField> Emails { get; }

    IVectorView<ContactField> PhoneNumbers { get; }

    IVectorView<ContactLocationField> Locations { get; }

    IVectorView<ContactInstantMessageField> InstantMessages { get; }

    IVectorView<ContactField> CustomFields { get; }

    IVectorView<ContactField> QueryCustomFields(string customName);
  }
}
