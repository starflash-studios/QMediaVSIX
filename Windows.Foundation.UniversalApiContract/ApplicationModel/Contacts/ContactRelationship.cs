// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.ContactRelationship
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Contacts
{
  /// <summary>Defines a value that indicates the nature of a contact relationship, such as spouse, partner, sibling, parent and so on.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum ContactRelationship
  {
    /// <summary>Other</summary>
    Other,
    /// <summary>Spouse</summary>
    Spouse,
    /// <summary>Partner</summary>
    Partner,
    /// <summary>Sibling</summary>
    Sibling,
    /// <summary>Parent</summary>
    Parent,
    /// <summary>Child</summary>
    Child,
  }
}
