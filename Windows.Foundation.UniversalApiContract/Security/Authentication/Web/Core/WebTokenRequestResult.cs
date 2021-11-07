// Decompiled with JetBrains decompiler
// Type: Windows.Security.Authentication.Web.Core.WebTokenRequestResult
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Security.Authentication.Web.Core
{
  /// <summary>Represents the results of a web token request to an identity provider.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 167772160)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class WebTokenRequestResult : IWebTokenRequestResult
  {
    /// <summary>Gets the response data from the web token provider.</summary>
    /// <returns>The response from the web token provider.</returns>
    public extern IVectorView<WebTokenResponse> ResponseData { [MethodImpl] get; }

    /// <summary>Gets the status of the request.</summary>
    /// <returns>The status of the request.</returns>
    public extern WebTokenRequestStatus ResponseStatus { [MethodImpl] get; }

    /// <summary>Gets the error returned by the web provider, if any.</summary>
    /// <returns>The error returned by the web provider.</returns>
    public extern WebProviderError ResponseError { [MethodImpl] get; }

    /// <summary>Invalidates the current cached WebTokenRequestResult. See Remarks for proper usage.</summary>
    /// <returns>This method does not return an object or value.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction InvalidateCacheAsync();
  }
}
