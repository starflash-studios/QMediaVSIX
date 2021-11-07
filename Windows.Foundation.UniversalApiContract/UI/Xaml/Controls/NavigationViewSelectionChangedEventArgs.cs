// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.NavigationViewSelectionChangedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Media.Animation;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Provides data for the NavigationView.SelectionChanged event.</summary>
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class NavigationViewSelectionChangedEventArgs : 
    INavigationViewSelectionChangedEventArgs,
    INavigationViewSelectionChangedEventArgs2
  {
    /// <summary>Gets the newly selected menu item.</summary>
    /// <returns>The newly selected menu item.</returns>
    public extern object SelectedItem { [MethodImpl] get; }

    /// <summary>Gets a value that indicates whether the **SelectedItem** is the menu item for Settings.</summary>
    /// <returns>**true** if the **SelectedItem** is the menu item for Settings; otherwise, **false**.</returns>
    public extern bool IsSettingsSelected { [MethodImpl] get; }

    /// <summary>Gets the container for the selected item.</summary>
    /// <returns>The container for the selected item.</returns>
    public extern NavigationViewItemBase SelectedItemContainer { [MethodImpl] get; }

    /// <summary>Gets the navigation transition recommended for the direction of the navigation.</summary>
    /// <returns>The navigation transition recommended for the direction of the navigation.</returns>
    public extern NavigationTransitionInfo RecommendedNavigationTransitionInfo { [MethodImpl] get; }
  }
}
