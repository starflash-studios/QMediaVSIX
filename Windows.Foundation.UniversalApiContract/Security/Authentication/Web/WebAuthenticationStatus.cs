// Decompiled with JetBrains decompiler
// Type: Windows.Security.Authentication.Web.WebAuthenticationStatus
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Authentication.Web
{
  /// <summary>Contains the status of the authentication operation.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum WebAuthenticationStatus
  {
    /// <summary>The operation succeeded, and the response data is available.</summary>
    Success,
    /// <summary>The operation was canceled by the user.</summary>
    UserCancel,
    /// <summary>The operation failed because a specific HTTP error was returned, for example 404.</summary>
    ErrorHttp,
  }
}
