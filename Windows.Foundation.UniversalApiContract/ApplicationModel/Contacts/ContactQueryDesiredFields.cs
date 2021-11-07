// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.ContactQueryDesiredFields
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Contacts
{
  /// <summary>Defines which fields must exist on a contact in order to match a search operation.</summary>
  [Flags]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum ContactQueryDesiredFields : uint
  {
    /// <summary>No required fields</summary>
    None = 0,
    /// <summary>The contact must have a phone number.</summary>
    PhoneNumber = 1,
    /// <summary>The contact must have an email address.</summary>
    EmailAddress = 2,
    /// <summary>The contact must have a postal address.</summary>
    PostalAddress = 4,
  }
}
