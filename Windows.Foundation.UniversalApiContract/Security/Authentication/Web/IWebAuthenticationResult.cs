// Decompiled with JetBrains decompiler
// Type: Windows.Security.Authentication.Web.IWebAuthenticationResult
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Authentication.Web
{
  [Guid(1677732683, 60905, 18186, 165, 205, 3, 35, 250, 246, 226, 98)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (WebAuthenticationResult))]
  internal interface IWebAuthenticationResult
  {
    string ResponseData { get; }

    WebAuthenticationStatus ResponseStatus { get; }

    uint ResponseErrorDetail { get; }
  }
}
