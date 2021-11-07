// Decompiled with JetBrains decompiler
// Type: Windows.Security.Authentication.Web.Core.WebTokenRequestPromptType
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Authentication.Web.Core
{
  /// <summary>Represents the prompt type of a web token request.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum WebTokenRequestPromptType
  {
    /// <summary>The default request type.</summary>
    Default,
    /// <summary>A request with forced authentication. This will require the user to enter their credentials, regardless of whether they are already logged in.</summary>
    ForceAuthentication,
  }
}
