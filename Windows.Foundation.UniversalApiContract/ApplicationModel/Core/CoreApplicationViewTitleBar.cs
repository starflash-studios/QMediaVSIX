// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Core.CoreApplicationViewTitleBar
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Core
{
  /// <summary>Enables an app to define a custom title bar that displays in the app's window.</summary>
  [Muse(Version = 167772160)]
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Standard)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class CoreApplicationViewTitleBar : ICoreApplicationViewTitleBar
  {
    /// <summary>Gets or sets a value that specifies whether this title bar should replace the default window title bar.</summary>
    /// <returns>Set to **true** to replace the default window title bar; otherwise, **false**.</returns>
    public extern bool ExtendViewIntoTitleBar { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets the width of the system-reserved region of the upper-left corner of the app window. This region is reserved when the current language is a right-to-left language.</summary>
    /// <returns>The width of the system-reserved region of the upper-left corner of the app window</returns>
    public extern double SystemOverlayLeftInset { [MethodImpl] get; }

    /// <summary>Gets the width of the system-reserved region of the upper-right corner of the app window. This region is reserved when the current language is a left-to-right language.</summary>
    /// <returns>The width of the system-reserved region of the upper-right corner of the app window.</returns>
    public extern double SystemOverlayRightInset { [MethodImpl] get; }

    /// <summary>Gets the height of the title bar.</summary>
    /// <returns>The height of the custom title bar.</returns>
    public extern double Height { [MethodImpl] get; }

    /// <summary>Occurs when the title bar needs to respond to size changes. The most common trigger for this event is when the app window moves to a screen that has a different DPI. Use this event to verify and update the positioning of UI elements that depend on the title bar's size.</summary>
    public extern event TypedEventHandler<CoreApplicationViewTitleBar, object> LayoutMetricsChanged;

    /// <summary>Gets a value that specifies whether this title bar is visible.</summary>
    /// <returns>**true** if this title bar is visible; otherwise, **false**.</returns>
    public extern bool IsVisible { [MethodImpl] get; }

    /// <summary>Occurs when the visibility of the title bar (indicated by the IsVisible property) changes.</summary>
    public extern event TypedEventHandler<CoreApplicationViewTitleBar, object> IsVisibleChanged;
  }
}
