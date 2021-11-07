// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.MenuFlyoutPresenter
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls.Primitives;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Displays the content of a MenuFlyout control.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IMenuFlyoutPresenterStatics3), 524288, "Windows.Foundation.UniversalApiContract")]
  [Composable(typeof (IMenuFlyoutPresenterFactory), CompositionType.Public, 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  public class MenuFlyoutPresenter : 
    ItemsControl,
    IMenuFlyoutPresenter,
    IMenuFlyoutPresenter2,
    IMenuFlyoutPresenter3
  {
    /// <summary>Initializes a new instance of the MenuFlyoutPresenter class.</summary>
    [MethodImpl]
    public extern MenuFlyoutPresenter();

    /// <summary>Gets an object that provides calculated values that can be referenced as [TemplateBinding](https://docs.microsoft.com/previous-versions/windows/apps/hh758288(v=win.10)) sources when defining templates for a MenuFlyoutPresenter control.</summary>
    /// <returns>An object that provides calculated values for templates.</returns>
    public extern MenuFlyoutPresenterTemplateSettings TemplateSettings { [MethodImpl] get; }

    /// <summary>Gets or sets a value that indicates whether the default shadow effect is shown.</summary>
    /// <returns>**true** if the default shadow effect is shown; otherwise, **false**. The default is **true**.</returns>
    public extern bool IsDefaultShadowEnabled { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Identifies the IsDefaultShadowEnabled dependency property.</summary>
    /// <returns>The identifier for the IsDefaultShadowEnabled dependency property.</returns>
    public static extern DependencyProperty IsDefaultShadowEnabledProperty { [MethodImpl] get; }
  }
}
