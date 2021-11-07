// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Vpn.IVpnChannelStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Vpn
{
  /// <summary>Provides static functions for VPN plug-ins.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2297103917, 59416, 20477, 152, 166, 54, 62, 55, 54, 201, 93)]
  public interface IVpnChannelStatics
  {
    /// <summary>A VPN plug-in must always call this function in its background tasks Run() method.</summary>
    /// <param name="thirdPartyPlugIn">The plug-in to be processed.</param>
    /// <param name="@event">
    /// </param>
    void ProcessEventAsync(object thirdPartyPlugIn, object @event);
  }
}
