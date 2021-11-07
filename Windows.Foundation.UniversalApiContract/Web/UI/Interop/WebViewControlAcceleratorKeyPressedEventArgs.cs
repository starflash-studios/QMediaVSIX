// Decompiled with JetBrains decompiler
// Type: Windows.Web.UI.Interop.WebViewControlAcceleratorKeyPressedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.System;
using Windows.UI.Core;

namespace Windows.Web.UI.Interop
{
  /// <summary>This class provides information for the Windows.Web.UI.Interop.WebViewControl.AcceleratorKeyPressed event.</summary>
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [MarshalingBehavior(MarshalingType.Standard)]
  public sealed class WebViewControlAcceleratorKeyPressedEventArgs : 
    IWebViewControlAcceleratorKeyPressedEventArgs
  {
    /// <summary>Gets the event type.</summary>
    /// <returns>The event type.</returns>
    public extern CoreAcceleratorKeyEventType EventType { [MethodImpl] get; }

    /// <summary>Gets the virtual key.</summary>
    /// <returns>The virtual key.</returns>
    public extern VirtualKey VirtualKey { [MethodImpl] get; }

    /// <summary>Gets the key status.</summary>
    /// <returns>The key status.</returns>
    public extern CorePhysicalKeyStatus KeyStatus { [MethodImpl] get; }

    /// <summary>Gets the routing stage.</summary>
    /// <returns>The routing stage.</returns>
    public extern WebViewControlAcceleratorKeyRoutingStage RoutingStage { [MethodImpl] get; }

    /// <summary>Gets or sets a value that marks the routed event as handled. A true value for Handled prevents other handlers along the event route from handling the same event again.</summary>
    /// <returns>Setting Handled to true will prevent WebViewControl from receiving the key in the event.</returns>
    public extern bool Handled { [MethodImpl] get; [MethodImpl] set; }
  }
}
