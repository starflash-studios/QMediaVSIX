// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.WebViewNewWindowRequestedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Provides data for the WebView.NewWindowRequested event.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class WebViewNewWindowRequestedEventArgs : IWebViewNewWindowRequestedEventArgs
  {
    /// <summary>Gets the Uniform Resource Identifier (URI) of the content the WebView is attempting to navigate to.</summary>
    /// <returns>The Uniform Resource Identifier (URI) of the content the WebView is attempting to navigate to.</returns>
    public extern Uri Uri { [MethodImpl] get; }

    /// <summary>Gets the Uniform Resource Identifier (URI) of the content where the navigation was initiated.</summary>
    /// <returns>The Uniform Resource Identifier (URI) of the content where the navigation was initiated.</returns>
    public extern Uri Referrer { [MethodImpl] get; }

    /// <summary>Gets or sets a value that marks the routed event as handled. A **true** value for Handled prevents other handlers along the event route from handling the same event again.</summary>
    /// <returns>**true** to mark the routed event handled. **false** to leave the routed event unhandled, which permits the event to potentially route further and be acted on by other handlers. The default is **false**.</returns>
    public extern bool Handled { [MethodImpl] get; [MethodImpl] set; }
  }
}
