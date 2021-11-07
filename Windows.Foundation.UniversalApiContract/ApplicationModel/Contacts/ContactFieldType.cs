// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.ContactFieldType
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Contacts
{
  /// <summary>Defines the type of contact data.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum ContactFieldType
  {
    /// <summary>The contact's email address. Supported on Windows Phone.</summary>
    Email,
    /// <summary>The contact's phone number. Supported on Windows Phone.</summary>
    PhoneNumber,
    /// <summary>The contact's location.</summary>
    /// <deprecated type="deprecate">Location  may be altered or unavailable for releases after Windows 8.1. Instead, use Address.</deprecated>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536), Deprecated("Location  may be altered or unavailable for releases after Windows 8.1. Instead, use Address.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] Location,
    /// <summary>The contact's instant message user name.</summary>
    /// <deprecated type="deprecate">InstantMessage  may be altered or unavailable for releases after Windows 8.1. Instead, use ConnectedServiceAccount.</deprecated>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536), Deprecated("InstantMessage  may be altered or unavailable for releases after Windows 8.1. Instead, use ConnectedServiceAccount.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] InstantMessage,
    /// <summary>A custom value.</summary>
    /// <deprecated type="deprecate">Custom may be altered or unavailable for releases after Windows 8.1. Instead, use one of the specific types.</deprecated>
    [Deprecated("Custom may be altered or unavailable for releases after Windows 8.1. Instead, use one of the specific types.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract"), ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] Custom,
    /// <summary>The contact's connected service account.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] ConnectedServiceAccount,
    /// <summary>The contact's important dates.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] ImportantDate,
    /// <summary>The contact's address. Supported on Windows Phone.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] Address,
    /// <summary>The contact's significant other.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] SignificantOther,
    /// <summary>The contact's notes.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] Notes,
    /// <summary>The contact's Web site.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] Website,
    /// <summary>The contact's job info.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] JobInfo,
  }
}
