// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.ContactEmailKind
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Contacts
{
  /// <summary>Specifies the kinds of email addresses for a contact.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum ContactEmailKind
  {
    /// <summary>The personal email address of the contact.</summary>
    Personal,
    /// <summary>The work email address of the contact.</summary>
    Work,
    /// <summary>An email address of the contact other than personal or work.</summary>
    Other,
  }
}
