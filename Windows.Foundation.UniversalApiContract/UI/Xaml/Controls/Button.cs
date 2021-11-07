// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Button
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls.Primitives;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Represents a templated button control that interprets a Click user interaction.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IButtonStaticsWithFlyout), 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [WebHostHidden]
  [Composable(typeof (IButtonFactory), CompositionType.Public, 65536, "Windows.Foundation.UniversalApiContract")]
  public class Button : ButtonBase, IButton, IButtonWithFlyout
  {
    /// <summary>Initializes a new instance of the Button class.</summary>
    [MethodImpl]
    public extern Button();

    /// <summary>Gets or sets the flyout associated with this button.</summary>
    /// <returns>The flyout associated with this button, if any; otherwise, **null**. The default is **null**.</returns>
    public extern FlyoutBase Flyout { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Identifies the Flyout dependency property.</summary>
    /// <returns>The identifier for the Flyout dependency property.</returns>
    public static extern DependencyProperty FlyoutProperty { [MethodImpl] get; }
  }
}
