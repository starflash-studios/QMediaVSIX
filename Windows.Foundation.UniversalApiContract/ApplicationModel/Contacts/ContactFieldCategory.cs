// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.ContactFieldCategory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Contacts
{
  /// <summary>Defines the categories that contact data can belong to.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum ContactFieldCategory
  {
    /// <summary>The data doesn't belong to a category</summary>
    None,
    /// <summary>The Home category.</summary>
    Home,
    /// <summary>The Work category.</summary>
    Work,
    /// <summary>The Mobile category.</summary>
    Mobile,
    /// <summary>The Other category.</summary>
    Other,
  }
}
