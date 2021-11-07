// Decompiled with JetBrains decompiler
// Type: Windows.Security.Authentication.Web.Provider.WebProviderTokenResponse
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Security.Authentication.Web.Core;

namespace Windows.Security.Authentication.Web.Provider
{
  /// <summary>Represents a web provider token response.</summary>
  [DualApiPartition(version = 167772160)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(typeof (IWebProviderTokenResponseFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  public sealed class WebProviderTokenResponse : IWebProviderTokenResponse
  {
    /// <summary>Creates a new instance of the WebProviderTokenResponse class.</summary>
    /// <param name="webTokenResponse">The web token response from the client.</param>
    [MethodImpl]
    public extern WebProviderTokenResponse(WebTokenResponse webTokenResponse);

    /// <summary>Gets the response from the provider to the client.</summary>
    /// <returns>The response from the provider to the client.</returns>
    public extern WebTokenResponse ClientResponse { [MethodImpl] get; }
  }
}
