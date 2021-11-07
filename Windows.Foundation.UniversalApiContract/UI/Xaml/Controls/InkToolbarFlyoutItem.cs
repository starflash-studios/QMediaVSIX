// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.InkToolbarFlyoutItem
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls.Primitives;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Represents an InkToolbar button on a flyout. This item can be a basic button, a radio button, a radio toggle button, or a check box.</summary>
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Static(typeof (IInkToolbarFlyoutItemStatics), 262144, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Composable(typeof (IInkToolbarFlyoutItemFactory), CompositionType.Public, 262144, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [Threading(ThreadingModel.Both)]
  public class InkToolbarFlyoutItem : ButtonBase, IInkToolbarFlyoutItem
  {
    /// <summary>Initializes a new instance of the InkToolbarFlyoutItem class.</summary>
    [MethodImpl]
    public extern InkToolbarFlyoutItem();

    /// <summary>Gets or sets the type of button to use on the flyout.</summary>
    /// <returns>The type of button.</returns>
    public extern InkToolbarFlyoutItemKind Kind { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets whether the flyout item is checked.</summary>
    /// <returns>**true** if checked. Otherwise, **false**.</returns>
    public extern bool IsChecked { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Occurs when the flyout item is checked.</summary>
    public extern event TypedEventHandler<InkToolbarFlyoutItem, object> Checked;

    /// <summary>Occurs when the flyout item is unchecked.</summary>
    public extern event TypedEventHandler<InkToolbarFlyoutItem, object> Unchecked;

    /// <summary>Identifies the Kind dependency property.</summary>
    /// <returns>The identifier for the Kind dependency property.</returns>
    public static extern DependencyProperty KindProperty { [MethodImpl] get; }

    /// <summary>Identifies the IsChecked dependency property.</summary>
    /// <returns>The identifier for the IsChecked dependency property.</returns>
    public static extern DependencyProperty IsCheckedProperty { [MethodImpl] get; }
  }
}
