// Decompiled with JetBrains decompiler
// Type: Windows.Web.UI.Interop.WebViewControlProcess
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Web.UI.Interop
{
  /// <summary>This class represents the process that one or more Windows.Web.UI.Interop.WebViewControl classes will live in.</summary>
  [Activatable(typeof (IWebViewControlProcessFactory), 393216, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [MarshalingBehavior(MarshalingType.Standard)]
  [Activatable(393216, "Windows.Foundation.UniversalApiContract")]
  public sealed class WebViewControlProcess : IWebViewControlProcess
  {
    /// <summary>Creates an instance of **WebViewControlProcess** with options.</summary>
    /// <param name="processOptions">The process options. For more info, see Windows.Web.UI.Interop.WebViewControlProcessOptions.</param>
    [MethodImpl]
    public extern WebViewControlProcess(WebViewControlProcessOptions processOptions);

    /// <summary>Creates an instance of **WebViewControlProcess**.</summary>
    [MethodImpl]
    public extern WebViewControlProcess();

    /// <summary>Gets the ID of this process.</summary>
    /// <returns>The ID of this process.</returns>
    public extern uint ProcessId { [MethodImpl] get; }

    /// <summary>Gets the enterprise ID of this proces.</summary>
    /// <returns>The enterprise ID of this process.</returns>
    public extern string EnterpriseId { [MethodImpl] get; }

    /// <summary>Gets a boolean value indicating whether the privateNetworkClientServer capability is enabled in this process.</summary>
    /// <returns>A boolean value indicating whether the privateNetworkClientServer capability is enabled in this process.</returns>
    public extern bool IsPrivateNetworkClientServerCapabilityEnabled { [MethodImpl] get; }

    /// <summary>Creates a Windows.Web.UI.Interop.WebViewControl within the context of this process.</summary>
    /// <param name="hostWindowHandle">The parent window.</param>
    /// <param name="bounds">The initial bounds of the window.</param>
    /// <returns>An asynchronous operation that completes with a Windows.Web.UI.Interop.WebViewControl.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<WebViewControl> CreateWebViewControlAsync(
      long hostWindowHandle,
      Rect bounds);

    /// <summary>Gets a vector containing all the Windows.Web.UI.Interop.WebViewControl objects hosted within this process.</summary>
    /// <returns>A vector containing all the Windows.Web.UI.Interop.WebViewControl objects hosted within this process.</returns>
    [MethodImpl]
    public extern IVectorView<WebViewControl> GetWebViewControls();

    /// <summary>Terminates the process.</summary>
    [MethodImpl]
    public extern void Terminate();

    /// <summary>Fires when this process is terminated.</summary>
    public extern event TypedEventHandler<WebViewControlProcess, object> ProcessExited;
  }
}
