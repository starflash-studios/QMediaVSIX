// Decompiled with JetBrains decompiler
// Type: Windows.Security.Authentication.Web.WebAuthenticationOptions
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Authentication.Web
{
  /// <summary>Contains the options available to the asynchronous operation.</summary>
  [Flags]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum WebAuthenticationOptions : uint
  {
    /// <summary>No options are requested.</summary>
    None = 0,
    /// <summary>Tells the web authentication broker to not render any UI. This option will throw an exception if used with AuthenticateAndContinue; AuthenticateSilentlyAsync, which includes this option implicitly, should be used instead.</summary>
    SilentMode = 1,
    /// <summary>Tells the web authentication broker to return the window title string of the webpage in the ResponseData property.</summary>
    UseTitle = 2,
    /// <summary>Tells the web authentication broker to return the body of the HTTP POST in the ResponseData property. For use with single sign-on (SSO) only.</summary>
    UseHttpPost = 4,
    /// <summary>Tells the web authentication broker to render the webpage in an app container that supports privateNetworkClientServer, enterpriseAuthentication, and sharedUserCertificate capabilities. Note the application that uses this flag must have these capabilities as well.</summary>
    UseCorporateNetwork = 8,
  }
}
