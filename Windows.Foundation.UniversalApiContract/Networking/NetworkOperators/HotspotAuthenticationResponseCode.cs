// Decompiled with JetBrains decompiler
// Type: Windows.Networking.NetworkOperators.HotspotAuthenticationResponseCode
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.NetworkOperators
{
  /// <summary>Defines values used to indicate status of connection authentication with a mobile hotspot. Provides the response code from the WISPr server for an authentication attempt.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum HotspotAuthenticationResponseCode
  {
    /// <summary>No response returned.</summary>
    NoError = 0,
    /// <summary>Hotspot authentication successful.</summary>
    LoginSucceeded = 50, // 0x00000032
    /// <summary>Hotspot authentication failed.</summary>
    LoginFailed = 100, // 0x00000064
    /// <summary>No response from authentication server.</summary>
    RadiusServerError = 102, // 0x00000066
    /// <summary>An error occurred that requires contacting the network administrator.</summary>
    NetworkAdministratorError = 105, // 0x00000069
    /// <summary>The authentication request was aborted.</summary>
    LoginAborted = 151, // 0x00000097
    /// <summary>An internal error occurred in the access gateway.</summary>
    AccessGatewayInternalError = 255, // 0x000000FF
  }
}
