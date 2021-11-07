// Decompiled with JetBrains decompiler
// Type: Windows.Security.Authentication.Web.WebAuthenticationResult
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Authentication.Web
{
  /// <summary>Indicates the result of the authentication operation.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class WebAuthenticationResult : IWebAuthenticationResult
  {
    /// <summary>Contains the protocol data when the operation successfully completes.</summary>
    /// <returns>The returned data.</returns>
    public extern string ResponseData { [MethodImpl] get; }

    /// <summary>Contains the status of the asynchronous operation when it completes.</summary>
    /// <returns>One of the enumerations.</returns>
    public extern WebAuthenticationStatus ResponseStatus { [MethodImpl] get; }

    /// <summary>Returns the HTTP error code when ResponseStatus is equal to WebAuthenticationStatus.ErrorHttp. This is only available if there is an error.</summary>
    /// <returns>The specific HTTP error, for example 400.</returns>
    public extern uint ResponseErrorDetail { [MethodImpl] get; }
  }
}
