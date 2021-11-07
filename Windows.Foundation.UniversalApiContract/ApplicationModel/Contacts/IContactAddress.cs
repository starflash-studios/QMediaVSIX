// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.IContactAddress
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Contacts
{
  [ExclusiveTo(typeof (ContactAddress))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2537149338, 17102, 18546, 141, 112, 48, 99, 170, 88, 75, 112)]
  internal interface IContactAddress
  {
    string StreetAddress { get; set; }

    string Locality { get; set; }

    string Region { get; set; }

    string Country { get; set; }

    string PostalCode { get; set; }

    ContactAddressKind Kind { get; set; }

    string Description { get; set; }
  }
}
