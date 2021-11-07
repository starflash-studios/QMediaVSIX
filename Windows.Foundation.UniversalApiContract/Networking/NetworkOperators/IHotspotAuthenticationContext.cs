// Decompiled with JetBrains decompiler
// Type: Windows.Networking.NetworkOperators.IHotspotAuthenticationContext
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Data.Xml.Dom;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Networking.Connectivity;

namespace Windows.Networking.NetworkOperators
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3881224081, 4099, 19941, 131, 199, 222, 97, 216, 136, 49, 208)]
  [ExclusiveTo(typeof (HotspotAuthenticationContext))]
  internal interface IHotspotAuthenticationContext
  {
    byte[] WirelessNetworkId { get; }

    NetworkAdapter NetworkAdapter { get; }

    Uri RedirectMessageUrl { get; }

    XmlDocument RedirectMessageXml { get; }

    Uri AuthenticationUrl { get; }

    void IssueCredentials(
      string userName,
      string password,
      string extraParameters,
      bool markAsManualConnectOnFailure);

    void AbortAuthentication(bool markAsManual);

    void SkipAuthentication();

    void TriggerAttentionRequired(string packageRelativeApplicationId, string applicationParameters);
  }
}
