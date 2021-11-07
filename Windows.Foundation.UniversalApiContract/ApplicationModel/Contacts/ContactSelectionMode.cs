// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.ContactSelectionMode
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Contacts
{
  /// <summary>Specifies whether you want to request an entire contact, or only specific fields.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum ContactSelectionMode
  {
    /// <summary>Specifies that you want to select the entire contact.</summary>
    Contacts,
    /// <summary>Specifies that you want to select only certain fields.</summary>
    Fields,
  }
}
