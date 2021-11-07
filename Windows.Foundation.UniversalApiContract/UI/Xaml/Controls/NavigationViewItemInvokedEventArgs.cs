// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.NavigationViewItemInvokedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Media.Animation;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Provides event data for the NavigationView.ItemInvoked event.</summary>
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  [Activatable(327680, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  public sealed class NavigationViewItemInvokedEventArgs : 
    INavigationViewItemInvokedEventArgs,
    INavigationViewItemInvokedEventArgs2
  {
    /// <summary>Initializes a new instance of the NavigationViewItemInvokedEventArgs class.</summary>
    [MethodImpl]
    public extern NavigationViewItemInvokedEventArgs();

    /// <summary>Gets a reference to the invoked item.</summary>
    /// <returns>The invoked item.</returns>
    public extern object InvokedItem { [MethodImpl] get; }

    /// <summary>Gets a value that indicates whether the **InvokedItem** is the menu item for Settings.</summary>
    /// <returns>**true** if the **InvokedItem** is the menu item for Settings; otherwise, **false**.</returns>
    public extern bool IsSettingsInvoked { [MethodImpl] get; }

    /// <summary>Gets the container for the invoked item.</summary>
    /// <returns>The container for the invoked item.</returns>
    public extern NavigationViewItemBase InvokedItemContainer { [MethodImpl] get; }

    /// <summary>Gets the navigation transition recommended for the direction of the navigation.</summary>
    /// <returns>The navigation transition recommended for the direction of the navigation.</returns>
    public extern NavigationTransitionInfo RecommendedNavigationTransitionInfo { [MethodImpl] get; }
  }
}
