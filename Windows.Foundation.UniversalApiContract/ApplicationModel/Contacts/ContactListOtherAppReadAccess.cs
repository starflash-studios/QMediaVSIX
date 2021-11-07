// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.ContactListOtherAppReadAccess
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Contacts
{
  /// <summary>Specifies the level of contact read access granted to other apps.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum ContactListOtherAppReadAccess
  {
    /// <summary>Only apps specially provisioned by Microsoft can read these contacts.</summary>
    SystemOnly,
    /// <summary>All apps can read the DisplayName and Picture properties, other properites are only available to specially provisioned apps.</summary>
    Limited,
    /// <summary>All apps can read all properties.</summary>
    Full,
    /// <summary>No other apps can read any of the contact information.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 196608)] None,
  }
}
