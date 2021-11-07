// Decompiled with JetBrains decompiler
// Type: Windows.Networking.BackgroundTransfer.IBackgroundTransferBase
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Security.Credentials;

namespace Windows.Networking.BackgroundTransfer
{
  /// <summary>Represents a background transfer operation.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(714973776, 51049, 17804, 175, 232, 254, 184, 212, 211, 178, 239)]
  public interface IBackgroundTransferBase
  {
    /// <summary>Sets the request headers.</summary>
    /// <param name="headerName">The header name.</param>
    /// <param name="headerValue">The header value.</param>
    void SetRequestHeader(string headerName, string headerValue);

    /// <summary>Gets or sets the credentials used to authenticate with the origin server.</summary>
    /// <returns>The credential to use for authentication.</returns>
    PasswordCredential ServerCredential { get; set; }

    /// <summary>Gets or sets the proxy credentials for the background transfer.</summary>
    /// <returns>The proxy credentials for the transfer.</returns>
    PasswordCredential ProxyCredential { get; set; }

    /// <summary>Gets or sets the method to use for the background transfer.</summary>
    /// <returns>The method to use for the download. This value can be **GET**, **PUT**, **RETR**, or **STOR**.</returns>
    string Method { get; set; }

    /// <summary>Gets are sets a string value indicating the group the transfer will belong to.</summary>
    /// <returns>The group name.</returns>
    string Group { [Deprecated("Group may be altered or unavailable for releases after Windows 8.1. Instead, use TransferGroup.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] get; [Deprecated("Group may be altered or unavailable for releases after Windows 8.1. Instead, use TransferGroup.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] set; }

    /// <summary>Gets or sets the cost policy for the background transfer operation.</summary>
    /// <returns>Specifies whether transfers can occur over costed networks.</returns>
    BackgroundTransferCostPolicy CostPolicy { get; set; }
  }
}
