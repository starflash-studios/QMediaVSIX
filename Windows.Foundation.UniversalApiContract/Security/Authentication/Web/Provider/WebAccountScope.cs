// Decompiled with JetBrains decompiler
// Type: Windows.Security.Authentication.Web.Provider.WebAccountScope
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Authentication.Web.Provider
{
  /// <summary>Represents the scope of a web account.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum WebAccountScope
  {
    /// <summary>Scope for single-sign-on accounts that appear in PC settings. This is the default scope.</summary>
    PerUser,
    /// <summary>Scope that hides the account from PC settings. Use this scope if you do not want the user's login to persist. For these accounts, only per-app tokens should be retained.</summary>
    PerApplication,
  }
}
