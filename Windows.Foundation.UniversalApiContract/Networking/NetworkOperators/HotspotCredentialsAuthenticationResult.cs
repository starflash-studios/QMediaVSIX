// Decompiled with JetBrains decompiler
// Type: Windows.Networking.NetworkOperators.HotspotCredentialsAuthenticationResult
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Data.Xml.Dom;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.NetworkOperators
{
  /// <summary>Represents the results of a Hotspot authentication request.</summary>
  [DualApiPartition(version = 100794368)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class HotspotCredentialsAuthenticationResult : 
    IHotspotCredentialsAuthenticationResult
  {
    /// <summary>Indicates if a network error has occurred that prevented the authentication attempt. If true, the other properties should not be examined.</summary>
    /// <returns>true if an error occurred; otherwise, false.</returns>
    public extern bool HasNetworkErrorOccurred { [MethodImpl] get; }

    /// <summary>Provides the WISPr Response Code for the authentication attempt as returned from the server. Possible values are defined by HotspotAuthenticationResponseCode.</summary>
    /// <returns>The authentication result.</returns>
    public extern HotspotAuthenticationResponseCode ResponseCode { [MethodImpl] get; }

    /// <summary>Provides the most recent Logoff URL as returned from the server in the authentication reply or from an earlier redirect message. If no Logoff URL was provided by the server, this property returns an empty URI.</summary>
    /// <returns>The most recent Logoff URL.</returns>
    public extern Uri LogoffUrl { [MethodImpl] get; }

    /// <summary>Provides the XML blob containing the WISPr authentication reply message from the server.</summary>
    /// <returns>Authentication reply message.</returns>
    public extern XmlDocument AuthenticationReplyXml { [MethodImpl] get; }
  }
}
