// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.UserDataAccounts.Provider.UserDataAccountProviderOperationKind
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.UserDataAccounts.Provider
{
  /// <summary>Defines the type of an account operation.</summary>
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  public enum UserDataAccountProviderOperationKind
  {
    /// <summary>An add account operation</summary>
    AddAccount,
    /// <summary>An account settings operation</summary>
    Settings,
    /// <summary>An operation to resolve errors on an account</summary>
    ResolveErrors,
  }
}
