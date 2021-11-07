// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.KnownContactField
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Contacts
{
  /// <summary>A static class that contains the names of contact fields for storing commonly requested information like email address and phone numbers.</summary>
  /// <deprecated type="deprecate">KnownContactField  may be altered or unavailable for releases after Windows 8.1. Instead, use ContactAddress, ContactPhone, ContactConnectedServiceAccount or ContactEmail.</deprecated>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Deprecated("KnownContactField  may be altered or unavailable for releases after Windows 8.1. Instead, use ContactAddress, ContactPhone, ContactConnectedServiceAccount or ContactEmail.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IKnownContactFieldStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  public static class KnownContactField
  {
    /// <summary>Contains the name of the field used for email addresses.</summary>
    /// <returns>The name of the field.</returns>
    public static extern string Email { [Deprecated("IKnownContactFieldStatics may be altered or unavailable for releases after Windows 8.1. Instead, use ContactAddress, ContactPhone, ContactConnectedServiceAccount or ContactEmail.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>Contains the name of the field used for phone numbers.</summary>
    /// <returns>The name of the field.</returns>
    public static extern string PhoneNumber { [Deprecated("IKnownContactFieldStatics may be altered or unavailable for releases after Windows 8.1. Instead, use ContactAddress, ContactPhone, ContactConnectedServiceAccount or ContactEmail.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>Contains the name of the field used for the contact's location.</summary>
    /// <returns>The name of the field.</returns>
    public static extern string Location { [Deprecated("IKnownContactFieldStatics may be altered or unavailable for releases after Windows 8.1. Instead, use ContactAddress, ContactPhone, ContactConnectedServiceAccount or ContactEmail.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>Contains the name of the field used for instant messaging accounts.</summary>
    /// <returns>The name of the field.</returns>
    public static extern string InstantMessage { [Deprecated("IKnownContactFieldStatics may be altered or unavailable for releases after Windows 8.1. Instead, use ContactAddress, ContactPhone, ContactConnectedServiceAccount or ContactEmail.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>Converts a string representing the name of a field to its corresponding type.</summary>
    /// <deprecated type="deprecate">IKnownContactFieldStatics may be altered or unavailable for releases after Windows 8.1. Instead, use ContactAddress, ContactPhone, ContactConnectedServiceAccount or ContactEmail.</deprecated>
    /// <param name="name">The name of the field.</param>
    /// <returns>The type of field.</returns>
    [Deprecated("IKnownContactFieldStatics may be altered or unavailable for releases after Windows 8.1. Instead, use ContactAddress, ContactPhone, ContactConnectedServiceAccount or ContactEmail.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public static extern ContactFieldType ConvertNameToType(string name);

    /// <summary>Converts the type of a field to its corresponding string name.</summary>
    /// <deprecated type="deprecate">IKnownContactFieldStatics may be altered or unavailable for releases after Windows 8.1. Instead, use ContactAddress, ContactPhone, ContactConnectedServiceAccount or ContactEmail.</deprecated>
    /// <param name="type">The type of field.</param>
    /// <returns>The name of the field.</returns>
    [Deprecated("IKnownContactFieldStatics may be altered or unavailable for releases after Windows 8.1. Instead, use ContactAddress, ContactPhone, ContactConnectedServiceAccount or ContactEmail.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public static extern string ConvertTypeToName(ContactFieldType type);
  }
}
