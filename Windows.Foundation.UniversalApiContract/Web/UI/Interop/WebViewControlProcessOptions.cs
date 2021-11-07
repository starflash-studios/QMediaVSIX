// Decompiled with JetBrains decompiler
// Type: Windows.Web.UI.Interop.WebViewControlProcessOptions
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Web.UI.Interop
{
  /// <summary>This class contains options that can be set when creating a Windows.Web.UI.Interop.WebViewControl object.</summary>
  [MarshalingBehavior(MarshalingType.Standard)]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [Activatable(393216, "Windows.Foundation.UniversalApiContract")]
  public sealed class WebViewControlProcessOptions : IWebViewControlProcessOptions
  {
    /// <summary>Creates an instance of **WebViewControlProcessOptions**</summary>
    [MethodImpl]
    public extern WebViewControlProcessOptions();

    /// <summary>Gets or sets the enterprise ID for apps that are WIP-enabled.</summary>
    /// <returns>The enterprise ID for apps that are WIP-enabled.</returns>
    public extern string EnterpriseId { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets or sets a boolean value indicating whether the privateNetworkClientServer capability is enabled.</summary>
    /// <returns>A boolean value indicating whether the privateNetworkClientServer capability is enabled.</returns>
    public extern WebViewControlProcessCapabilityState PrivateNetworkClientServerCapability { [MethodImpl] set; [MethodImpl] get; }
  }
}
