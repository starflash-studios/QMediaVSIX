// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.CommonNavigationTransitionInfo
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Animation
{
  /// <summary>Provides common parameters for navigation transition animations.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [Static(typeof (ICommonNavigationTransitionInfoStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  public sealed class CommonNavigationTransitionInfo : 
    NavigationTransitionInfo,
    ICommonNavigationTransitionInfo
  {
    /// <summary>Initializes a new instance of the CommonNavigationTransitionInfo class.</summary>
    [MethodImpl]
    public extern CommonNavigationTransitionInfo();

    /// <summary>Gets or sets a Boolean value indicating if staggering is enabled for the navigation transition.</summary>
    /// <returns>A Boolean value indicating if staggering is enabled for the navigation transition.</returns>
    public extern bool IsStaggeringEnabled { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Identifies the IsStaggeringEnabled dependency property.</summary>
    /// <returns>The identifier for the IsStaggeringEnabled dependency property.</returns>
    public static extern DependencyProperty IsStaggeringEnabledProperty { [MethodImpl] get; }

    /// <summary>Identifies the CommonNavigationTransitionInfo.IsStaggerElement attached property.</summary>
    /// <returns>The identifier for the CommonNavigationTransitionInfo.IsStaggerElement attached property.</returns>
    public static extern DependencyProperty IsStaggerElementProperty { [MethodImpl] get; }

    /// <summary>Returns a Boolean value indicating if the specified **UIElement** is the stagger element for the navigation transition.</summary>
    /// <param name="element">The **UIElement** to check as being the stagger element.</param>
    /// <returns>Returns **true** if *element* is the stagger element; otherwise **false**.</returns>
    [MethodImpl]
    public static extern bool GetIsStaggerElement(UIElement element);

    /// <summary>Sets a Boolean value indicating if the specified **UIElement** is the stagger element for the navigation transition.</summary>
    /// <param name="element">The **UIElement** about which to set the stagger element indicator.</param>
    /// <param name="value">Set this value to **true** if *element* is the stagger element; otherwise set it to **false**.</param>
    [MethodImpl]
    public static extern void SetIsStaggerElement(UIElement element, bool value);
  }
}
