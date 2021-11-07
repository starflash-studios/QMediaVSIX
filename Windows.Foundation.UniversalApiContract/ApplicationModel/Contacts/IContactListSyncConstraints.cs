// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.IContactListSyncConstraints
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Contacts
{
  [ExclusiveTo(typeof (ContactListSyncConstraints))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(2997927681, 12386, 20014, 150, 157, 1, 141, 25, 135, 243, 20)]
  internal interface IContactListSyncConstraints
  {
    bool CanSyncDescriptions { get; set; }

    IReference<int> MaxHomePhoneNumbers { get; set; }

    IReference<int> MaxMobilePhoneNumbers { get; set; }

    IReference<int> MaxWorkPhoneNumbers { get; set; }

    IReference<int> MaxOtherPhoneNumbers { get; set; }

    IReference<int> MaxPagerPhoneNumbers { get; set; }

    IReference<int> MaxBusinessFaxPhoneNumbers { get; set; }

    IReference<int> MaxHomeFaxPhoneNumbers { get; set; }

    IReference<int> MaxCompanyPhoneNumbers { get; set; }

    IReference<int> MaxAssistantPhoneNumbers { get; set; }

    IReference<int> MaxRadioPhoneNumbers { get; set; }

    IReference<int> MaxPersonalEmailAddresses { get; set; }

    IReference<int> MaxWorkEmailAddresses { get; set; }

    IReference<int> MaxOtherEmailAddresses { get; set; }

    IReference<int> MaxHomeAddresses { get; set; }

    IReference<int> MaxWorkAddresses { get; set; }

    IReference<int> MaxOtherAddresses { get; set; }

    IReference<int> MaxBirthdayDates { get; set; }

    IReference<int> MaxAnniversaryDates { get; set; }

    IReference<int> MaxOtherDates { get; set; }

    IReference<int> MaxOtherRelationships { get; set; }

    IReference<int> MaxSpouseRelationships { get; set; }

    IReference<int> MaxPartnerRelationships { get; set; }

    IReference<int> MaxSiblingRelationships { get; set; }

    IReference<int> MaxParentRelationships { get; set; }

    IReference<int> MaxChildRelationships { get; set; }

    IReference<int> MaxJobInfo { get; set; }

    IReference<int> MaxWebsites { get; set; }
  }
}
