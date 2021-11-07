// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.ContactMatchReasonKind
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Contacts
{
  /// <summary>Defines the reasons that a Contact matched a search.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum ContactMatchReasonKind
  {
    /// <summary>The contact name field matched.</summary>
    Name,
    /// <summary>The contact email address field matched.</summary>
    EmailAddress,
    /// <summary>The contact phone number field matched.</summary>
    PhoneNumber,
    /// <summary>The contact job info field matched.</summary>
    JobInfo,
    /// <summary>The contact phonetic name field matched.</summary>
    YomiName,
    /// <summary>The contact matched on a field that is not one of the others list in this enum.</summary>
    Other,
  }
}
