// Decompiled with JetBrains decompiler
// Type: Windows.Devices.WiFi.WiFiConnectionStatus
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.WiFi
{
  /// <summary>Status of the connection attempt.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum WiFiConnectionStatus
  {
    /// <summary>Connection failed for a reason other than those in this list.</summary>
    UnspecifiedFailure,
    /// <summary>Connection succeeded.</summary>
    Success,
    /// <summary>Connection failed because access to the network has been revoked.</summary>
    AccessRevoked,
    /// <summary>Connection failed because an invalid credential was presented.</summary>
    InvalidCredential,
    /// <summary>Connection failed because the network is not available.</summary>
    NetworkNotAvailable,
    /// <summary>Connection failed because the connection attempt timed out.</summary>
    Timeout,
    /// <summary>Connection failed because the authentication protocol is not supported.</summary>
    UnsupportedAuthenticationProtocol,
  }
}
