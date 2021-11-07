// Decompiled with JetBrains decompiler
// Type: Windows.Networking.NetworkOperators.HotspotAuthenticationContext
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Data.Xml.Dom;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Networking.Connectivity;

namespace Windows.Networking.NetworkOperators
{
  /// <summary>Provides the authentication context that contains details of the current authentication attempt and provides methods to perform the authentication.</summary>
  [Threading(ThreadingModel.Both)]
  [Static(typeof (IHotspotAuthenticationContextStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class HotspotAuthenticationContext : 
    IHotspotAuthenticationContext,
    IHotspotAuthenticationContext2
  {
    /// <summary>Gets the SSID of the WLAN access point of the hotspot.</summary>
    /// <returns>A byte array that contains the SSID.</returns>
    public extern byte[] WirelessNetworkId { [MethodImpl] get; }

    /// <summary>Gets the network interface that is connected to the WLAN access point of the hotspot.</summary>
    /// <returns>An object that uniquely identifies the network.</returns>
    public extern NetworkAdapter NetworkAdapter { [MethodImpl] get; }

    /// <summary>Gets the URL of the web page where the Wireless Internet Service Provider roaming (WISPr) redirect message was found.</summary>
    /// <returns>A URI that contains the HTTPS or HTTP redirect URL.</returns>
    public extern Uri RedirectMessageUrl { [MethodImpl] get; }

    /// <summary>Gets the XML blob of the Wireless Internet Service Provider roaming (WISPr) redirect message of the hotspot.</summary>
    /// <returns>The WISPr XML blob from the hotspot redirect message.</returns>
    public extern XmlDocument RedirectMessageXml { [MethodImpl] get; }

    /// <summary>Gets the HTTPS URL specified in the Wireless Internet Service Provider roaming (WISPr) redirect message.</summary>
    /// <returns>A URI that contains the HTTPS authentication URL.</returns>
    public extern Uri AuthenticationUrl { [MethodImpl] get; }

    /// <summary>Provides credentials to Windows for hotspot authentication</summary>
    /// <param name="userName">The *UserName* parameter of the Wireless Internet Service Provider roaming (WISPr) authentication protocol. IssueCredentials performs URL encoding before submitting the value to the server. If this string is empty, the corresponding authentication parameter is skipped.</param>
    /// <param name="password">The *Password* parameter of the WISPr authentication protocol. IssueCredentials performs URL encoding before submitting the value to the server. If this string is empty, the corresponding authentication parameter is skipped.</param>
    /// <param name="extraParameters">Additional parameters to be appended to the authentication string. IssueCredentials appends this parameter after an "&amp;" character to the HTTP POST string as is without any encoding. This can be used to add multiple parameters. The default for this parameter is an empty string.</param>
    /// <param name="markAsManualConnectOnFailure">If **true**, an application permanently disables the auto-connect property on a connection. If authentication fails, the connection will be disconnected and not retried in the current user session. Otherwise, **false**.</param>
    [MethodImpl]
    public extern void IssueCredentials(
      string userName,
      string password,
      string extraParameters,
      bool markAsManualConnectOnFailure);

    /// <summary>Aborts the current authentication attempt and disconnects the WLAN interface from the hotspot.</summary>
    /// <param name="markAsManual">If **true**, Windows disables the auto-connect property for the corresponding WLAN profile and avoids future auto-connects to this hotspot. Otherwise, **false**.</param>
    [MethodImpl]
    public extern void AbortAuthentication(bool markAsManual);

    /// <summary>Skips Wireless Internet Service Provider roaming (WISPr) Windows authentication.</summary>
    [MethodImpl]
    public extern void SkipAuthentication();

    /// <summary>Called by a background task handler to launch the foreground application when there is an authentication attempt to complete.</summary>
    /// <param name="packageRelativeApplicationId">The foreground application ID within its application package. The application must belong to the same package as the background task handler.</param>
    /// <param name="applicationParameters">Optional command line parameters that are passed to the application at launch.</param>
    [MethodImpl]
    public extern void TriggerAttentionRequired(
      string packageRelativeApplicationId,
      string applicationParameters);

    /// <summary>Asynchronously provides credentials to Windows for hotspot authentication Windows does not cache these credentials and another authentication event will be raised when the system connects to the same hotspot again.</summary>
    /// <param name="userName">The *UserName* parameter of the Wireless Internet Service Provider roaming (WISPr) authentication protocol. IssueCredentials performs URL encoding before submitting the value to the server. If this string is empty, the corresponding authentication parameter is skipped.</param>
    /// <param name="password">The *Password* parameter of the WISPr authentication protocol. IssueCredentials performs URL encoding before submitting the value to the server. If this string is empty, the corresponding authentication parameter is skipped.</param>
    /// <param name="extraParameters">Additional parameters to be appended to the authentication string. IssueCredentials appends this parameter after an "&amp;" character to the HTTP POST string as is without any encoding. This can be used to add multiple parameters. The default for this parameter is an empty string.</param>
    /// <param name="markAsManualConnectOnFailure">If **true**, an application permanently disables the auto-connect property on a connection. If authentication fails, the connection will be disconnected and not retried in the current user session. Otherwise, **false**.</param>
    /// <returns>Results of the Hotspot authentication request.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<HotspotCredentialsAuthenticationResult> IssueCredentialsAsync(
      string userName,
      string password,
      string extraParameters,
      bool markAsManualConnectOnFailure);

    /// <summary>Gets the context of an authentication attempt.</summary>
    /// <param name="evenToken">The event token retrieved from the network operator hotspot authentication event. The token is a GUID in string format.</param>
    /// <param name="context">The network operator hotspot authentication context.</param>
    /// <returns>If **true**, the authentication context was retrieved. The authentication context can only be retrieved if the calling application matches the application ID specified in the hotspot profile of the underlying WLAN connection and if the authentication hasn’t be completed by the corresponding context already or timed out.</returns>
    [MethodImpl]
    public static extern bool TryGetAuthenticationContext(
      string evenToken,
      out HotspotAuthenticationContext context);
  }
}
