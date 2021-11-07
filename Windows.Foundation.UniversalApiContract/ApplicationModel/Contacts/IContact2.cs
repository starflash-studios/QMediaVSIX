// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.IContact2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Contacts
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (Contact))]
  [Guid(4078105445, 47991, 19604, 128, 45, 131, 40, 206, 228, 12, 8)]
  internal interface IContact2 : IContact
  {
    string Id { get; set; }

    string Notes { get; set; }

    IVector<ContactPhone> Phones { get; }

    IVector<ContactEmail> Emails { get; }

    IVector<ContactAddress> Addresses { get; }

    IVector<ContactConnectedServiceAccount> ConnectedServiceAccounts { get; }

    IVector<ContactDate> ImportantDates { get; }

    IVector<string> DataSuppliers { get; }

    IVector<ContactJobInfo> JobInfo { get; }

    IVector<ContactSignificantOther> SignificantOthers { get; }

    IVector<ContactWebsite> Websites { get; }

    IPropertySet ProviderProperties { get; }
  }
}
