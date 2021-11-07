// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.ContactListSyncConstraints
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Contacts
{
  /// <summary>Specifies limits on how much contact list data can be synchronized.</summary>
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  public sealed class ContactListSyncConstraints : IContactListSyncConstraints
  {
    /// <summary>Gets or sets a Boolean value that indicates whether to synchronize contact descriptions.</summary>
    /// <returns>**True** indicates that contact descriptions will be synchronized; **false**, otherwise.</returns>
    public extern bool CanSyncDescriptions { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the maximum number of home phone numbers that can be synchronized.</summary>
    /// <returns>The maximum number of home phone numbers that can be synchronized.</returns>
    public extern IReference<int> MaxHomePhoneNumbers { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the maximum number of mobile phone numbers that can be synchronized.</summary>
    /// <returns>The maximum number of mobile phone numbers that can be synchronized.</returns>
    public extern IReference<int> MaxMobilePhoneNumbers { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the maximum number of work phone numbers that can be synchronized.</summary>
    /// <returns>The maximum number of work phone numbers that can be synchronized.</returns>
    public extern IReference<int> MaxWorkPhoneNumbers { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the maximum number of 'other phone' numbers that can be synchronized.</summary>
    /// <returns>The maximum number of 'other phone' numbers that can be synchronized.</returns>
    public extern IReference<int> MaxOtherPhoneNumbers { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the maximum number of page phone numbers that can be synchronized.</summary>
    /// <returns>The maximum number of page phone numbers that can be synchronized.</returns>
    public extern IReference<int> MaxPagerPhoneNumbers { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the maximum number of business fax numbers that can be synchronized.</summary>
    /// <returns>The maximum number of business fax numbers that can be synchronized.</returns>
    public extern IReference<int> MaxBusinessFaxPhoneNumbers { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the maximum number of home fax phone numbers that can be synchronized.</summary>
    /// <returns>The maximum number of home fax phone numbers that can be synchronized.</returns>
    public extern IReference<int> MaxHomeFaxPhoneNumbers { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the maximum number of company phone numbers that can be synchronized.</summary>
    /// <returns>The maximum number of company phone numbers that can be synchronized.</returns>
    public extern IReference<int> MaxCompanyPhoneNumbers { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the maximum number of assistant phone numbers that can be synchronized.</summary>
    /// <returns>The maximum number of assistant phone numbers that can be synchronized.</returns>
    public extern IReference<int> MaxAssistantPhoneNumbers { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the maximum number of radio phone numbers that can be synchronized.</summary>
    /// <returns>The maximum number of radio phone numbers that can be synchronized.</returns>
    public extern IReference<int> MaxRadioPhoneNumbers { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the maximum number of personal email addresses that can be synchronized.</summary>
    /// <returns>The maximum number of personal email addresses that can be synchronized.</returns>
    public extern IReference<int> MaxPersonalEmailAddresses { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the maximum number of work email addresses that can be synchronized.</summary>
    /// <returns>The maximum number of work email addresses that can be synchronized.</returns>
    public extern IReference<int> MaxWorkEmailAddresses { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the maximum number of 'other email' addresses that can be synchronized.</summary>
    /// <returns>The maximum number of 'other email' addresses that can be synchronized.</returns>
    public extern IReference<int> MaxOtherEmailAddresses { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the maximum number of home addresses that can be synchronized.</summary>
    /// <returns>The maximum number of home addresses that can be synchronized.</returns>
    public extern IReference<int> MaxHomeAddresses { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the maximum number of work addresses that can be synchronized.</summary>
    /// <returns>The maximum number of work addresses that can be synchronized.</returns>
    public extern IReference<int> MaxWorkAddresses { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the maximum number of 'other address' entries that can be synchronized.</summary>
    /// <returns>The maximum number of 'other address' entries that can be synchronized.</returns>
    public extern IReference<int> MaxOtherAddresses { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the maximum number of birthday dates that can be synchronized.</summary>
    /// <returns>The maximum number of birthday dates that can be synchronized.</returns>
    public extern IReference<int> MaxBirthdayDates { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the maximum number of anniversary dates that can be synchronized.</summary>
    /// <returns>The maximum number of anniversary dates that can be synchronized.</returns>
    public extern IReference<int> MaxAnniversaryDates { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the maximum number of 'other dates' that can be synchronized.</summary>
    /// <returns>The maximum number of 'other dates' that can be synchronized.</returns>
    public extern IReference<int> MaxOtherDates { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the maximum number of 'other relationship' entries that can be synchronized.</summary>
    /// <returns>The maximum number of 'other relationship' entries that can be synchronized.</returns>
    public extern IReference<int> MaxOtherRelationships { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the maximum number of spouse relationships that can be synchronized.</summary>
    /// <returns>The maximum number of spouse relationships that can be synchronized.</returns>
    public extern IReference<int> MaxSpouseRelationships { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the maximum number of partner relationships that can be synchronized.</summary>
    /// <returns>The maximum number of partner relationships that can be synchronized.</returns>
    public extern IReference<int> MaxPartnerRelationships { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the maximum number of sibling relationships that can be synchronized.</summary>
    /// <returns>The maximum number of sibling relationships that can be synchronized.</returns>
    public extern IReference<int> MaxSiblingRelationships { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the maximum number of parent relationships that can be synchronized.</summary>
    /// <returns>The maximum number of parent relationships that can be synchronized.</returns>
    public extern IReference<int> MaxParentRelationships { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the maximum number of child relationships that can be synchronized.</summary>
    /// <returns>The maximum number of child relationships that can be synchronized.</returns>
    public extern IReference<int> MaxChildRelationships { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the maximum number of job info entries that can be synchronized.</summary>
    /// <returns>The maximum number of job info entries that can be synchronized.</returns>
    public extern IReference<int> MaxJobInfo { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the maximum number of website entries that can be synchronized.</summary>
    /// <returns>The maximum number of website entries that can be synchronized.</returns>
    public extern IReference<int> MaxWebsites { [MethodImpl] get; [MethodImpl] set; }
  }
}
