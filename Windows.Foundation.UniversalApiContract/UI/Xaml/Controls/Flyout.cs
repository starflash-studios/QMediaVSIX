// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Flyout
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls.Primitives;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Represents a control that displays lightweight UI that is either information, or requires user interaction. Unlike a dialog, a Flyout can be light dismissed by clicking or tapping outside of it, pressing the device’s back button, or pressing the ‘Esc’ key.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  [global::Windows.UI.Xaml.Markup.ContentProperty(Name = "Content")]
  [Threading(ThreadingModel.Both)]
  [Composable(typeof (IFlyoutFactory), CompositionType.Public, 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IFlyoutStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public class Flyout : FlyoutBase, IFlyout
  {
    /// <summary>Initializes a new instance of the Flyout class.</summary>
    [MethodImpl]
    public extern Flyout();

    /// <summary>Gets or sets the content of the Flyout.</summary>
    /// <returns>The content of the Flyout.</returns>
    public extern UIElement Content { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the Style applied to the Flyout content.</summary>
    /// <returns>The applied Style for the Flyout content, if present; otherwise, **null**. The default is **null**.</returns>
    public extern Style FlyoutPresenterStyle { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the identifier for the Content dependency property.</summary>
    /// <returns>The identifier for the Content dependency property.</returns>
    public static extern DependencyProperty ContentProperty { [MethodImpl] get; }

    /// <summary>Gets the identifier for the FlyoutPresenterStyle dependency property.</summary>
    /// <returns>The identifier for the FlyoutPresenterStyle dependency property.</returns>
    public static extern DependencyProperty FlyoutPresenterStyleProperty { [MethodImpl] get; }
  }
}
