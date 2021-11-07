// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.UserDataAccounts.Provider.UserDataAccountProviderPartnerAccountKind
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.UserDataAccounts.Provider
{
  /// <summary>Specifies the type of the user data account.</summary>
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  public enum UserDataAccountProviderPartnerAccountKind
  {
    /// <summary>An Microsoft Exchange account</summary>
    Exchange,
    /// <summary>A POP or IMAP account</summary>
    PopOrImap,
  }
}
