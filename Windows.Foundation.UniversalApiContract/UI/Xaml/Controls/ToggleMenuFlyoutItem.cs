// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ToggleMenuFlyoutItem
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Represents an item in a MenuFlyout that a user can change between two states, checked or unchecked.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IToggleMenuFlyoutItemStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [Composable(typeof (IToggleMenuFlyoutItemFactory), CompositionType.Public, 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  public class ToggleMenuFlyoutItem : MenuFlyoutItem, IToggleMenuFlyoutItem
  {
    /// <summary>Initializes a new instance of the ToggleMenuFlyoutItem class.</summary>
    [MethodImpl]
    public extern ToggleMenuFlyoutItem();

    /// <summary>Gets or sets whether the ToggleMenuFlyoutItem is checked.</summary>
    /// <returns>**true** if the ToggleMenuFlyoutItem is checked; **false** if the ToggleMenuFlyoutItem is unchecked. The default is **false**.</returns>
    public extern bool IsChecked { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Identifies the IsChecked dependency property.</summary>
    /// <returns>The identifier for the IsChecked dependency property.</returns>
    public static extern DependencyProperty IsCheckedProperty { [MethodImpl] get; }
  }
}
