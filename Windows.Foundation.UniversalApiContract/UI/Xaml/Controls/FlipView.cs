// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.FlipView
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls.Primitives;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Represents an items control that displays one item at a time, and enables "flip" behavior for traversing its collection of items.</summary>
  [Static(typeof (IFlipViewStatics2), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Composable(typeof (IFlipViewFactory), CompositionType.Public, 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Threading(ThreadingModel.Both)]
  public class FlipView : Selector, IFlipView, IFlipView2
  {
    /// <summary>Initializes a new instance of the FlipView class.</summary>
    [MethodImpl]
    public extern FlipView();

    /// <summary>Gets or sets a value that indicates whether transition animations are always used whether the navigation is touch-based, button-based or programmatic.</summary>
    /// <returns>**true** if transition animations are always used; **false** if transition animations are used only for touch navigation. The default is **true**.</returns>
    public extern bool UseTouchAnimationsForAllNavigation { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Identifies the UseTouchAnimationsForAllNavigation dependency property.</summary>
    /// <returns>The identifier for the UseTouchAnimationsForAllNavigation dependency property.</returns>
    public static extern DependencyProperty UseTouchAnimationsForAllNavigationProperty { [MethodImpl] get; }
  }
}
