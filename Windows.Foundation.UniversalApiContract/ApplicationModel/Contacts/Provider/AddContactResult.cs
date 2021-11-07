// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.Provider.AddContactResult
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Contacts.Provider
{
  /// <summary>Indicates whether a contact was added successfully.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum AddContactResult
  {
    /// <summary>The contact was added.</summary>
    Added,
    /// <summary>The contact was already selected by the user.</summary>
    AlreadyAdded,
    /// <summary>The contact was unavailable and was not added.</summary>
    Unavailable,
  }
}
