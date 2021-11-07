// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.INavigationViewTemplateSettingsStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ExclusiveTo(typeof (NavigationViewTemplateSettings))]
  [WebHostHidden]
  [Guid(747134553, 63417, 20600, 174, 182, 141, 122, 3, 192, 93, 2)]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  internal interface INavigationViewTemplateSettingsStatics
  {
    DependencyProperty TopPaddingProperty { get; }

    DependencyProperty OverflowButtonVisibilityProperty { get; }

    DependencyProperty PaneToggleButtonVisibilityProperty { get; }

    DependencyProperty BackButtonVisibilityProperty { get; }

    DependencyProperty TopPaneVisibilityProperty { get; }

    DependencyProperty LeftPaneVisibilityProperty { get; }

    DependencyProperty SingleSelectionFollowsFocusProperty { get; }
  }
}
