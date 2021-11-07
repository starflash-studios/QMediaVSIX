// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Primitives.NavigationViewItemPresenter
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Primitives
{
  /// <summary>Represents the visual elements of a NavigationViewItem.</summary>
  [Static(typeof (INavigationViewItemPresenterStatics), 458752, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [Threading(ThreadingModel.Both)]
  [WebHostHidden]
  [Composable(typeof (INavigationViewItemPresenterFactory), CompositionType.Public, 458752, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  public class NavigationViewItemPresenter : ContentControl, INavigationViewItemPresenter
  {
    /// <summary>Initializes a new instance of the NavigationViewItemPresenter class.</summary>
    [MethodImpl]
    public extern NavigationViewItemPresenter();

    /// <summary>Gets or sets the icon in a NavigationView item.</summary>
    /// <returns>The NavigationView item's icon.</returns>
    public extern IconElement Icon { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Identifies the Icon dependency property.</summary>
    /// <returns>The identifier for the Icon dependency property.</returns>
    public static extern DependencyProperty IconProperty { [MethodImpl] get; }
  }
}
