// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.ContactListOtherAppWriteAccess
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Contacts
{
  /// <summary>Specifies the level of contact write access granted to other apps.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum ContactListOtherAppWriteAccess
  {
    /// <summary>No write access is granted.</summary>
    None,
    /// <summary>Other apps can only write system contacts.</summary>
    SystemOnly,
    /// <summary>Other apps can only write contacts for this app.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 327680)] Limited,
  }
}
