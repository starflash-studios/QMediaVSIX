// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.IKnownContactFieldStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Contacts
{
  [Guid(772676370, 54823, 20426, 186, 212, 31, 175, 22, 140, 125, 20)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (KnownContactField))]
  [Deprecated("IKnownContactFieldStatics may be altered or unavailable for releases after Windows 8.1. Instead, use ContactAddress, ContactPhone, ContactConnectedServiceAccount or ContactEmail.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")]
  internal interface IKnownContactFieldStatics
  {
    string Email { [Deprecated("IKnownContactFieldStatics may be altered or unavailable for releases after Windows 8.1. Instead, use ContactAddress, ContactPhone, ContactConnectedServiceAccount or ContactEmail.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] get; }

    string PhoneNumber { [Deprecated("IKnownContactFieldStatics may be altered or unavailable for releases after Windows 8.1. Instead, use ContactAddress, ContactPhone, ContactConnectedServiceAccount or ContactEmail.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] get; }

    string Location { [Deprecated("IKnownContactFieldStatics may be altered or unavailable for releases after Windows 8.1. Instead, use ContactAddress, ContactPhone, ContactConnectedServiceAccount or ContactEmail.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] get; }

    string InstantMessage { [Deprecated("IKnownContactFieldStatics may be altered or unavailable for releases after Windows 8.1. Instead, use ContactAddress, ContactPhone, ContactConnectedServiceAccount or ContactEmail.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] get; }

    [Deprecated("IKnownContactFieldStatics may be altered or unavailable for releases after Windows 8.1. Instead, use ContactAddress, ContactPhone, ContactConnectedServiceAccount or ContactEmail.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")]
    ContactFieldType ConvertNameToType(string name);

    [Deprecated("IKnownContactFieldStatics may be altered or unavailable for releases after Windows 8.1. Instead, use ContactAddress, ContactPhone, ContactConnectedServiceAccount or ContactEmail.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")]
    string ConvertTypeToName(ContactFieldType type);
  }
}
