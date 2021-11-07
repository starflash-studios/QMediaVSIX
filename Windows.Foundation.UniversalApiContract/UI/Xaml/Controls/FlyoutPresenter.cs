// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.FlyoutPresenter
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Displays the content of a Flyout.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Composable(typeof (IFlyoutPresenterFactory), CompositionType.Public, 65536, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [Static(typeof (IFlyoutPresenterStatics2), 524288, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public class FlyoutPresenter : ContentControl, IFlyoutPresenter, IFlyoutPresenter2
  {
    /// <summary>Initializes a new instance of the FlyoutPresenter class.</summary>
    [MethodImpl]
    public extern FlyoutPresenter();

    /// <summary>Gets or sets a value that indicates whether the default shadow effect is shown.</summary>
    /// <returns>**true** if the default shadow effect is shown; otherwise, **false**. The default is **true**.</returns>
    public extern bool IsDefaultShadowEnabled { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Identifies the IsDefaultShadowEnabled dependency property.</summary>
    /// <returns>The identifier for the IsDefaultShadowEnabled dependency property.</returns>
    public static extern DependencyProperty IsDefaultShadowEnabledProperty { [MethodImpl] get; }
  }
}
