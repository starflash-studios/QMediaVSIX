// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.ContactPhoneKind
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Contacts
{
  /// <summary>Specifies the kinds of phones for a contact.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum ContactPhoneKind
  {
    /// <summary>The home phone of the contact.</summary>
    Home,
    /// <summary>The mobile phone of the contact.</summary>
    Mobile,
    /// <summary>The work phone of the contact.</summary>
    Work,
    /// <summary>A phone of the contact other than home, mobile, or work.</summary>
    Other,
    /// <summary>The pager number of the contact.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] Pager,
    /// <summary>The business fax of the contact.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] BusinessFax,
    /// <summary>The home fax of the contact.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] HomeFax,
    /// <summary>The company phone of the contact.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] Company,
    /// <summary>The phone number of the contact's assistant.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] Assistant,
    /// <summary>The radio address of the contact.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] Radio,
  }
}
