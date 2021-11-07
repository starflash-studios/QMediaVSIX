// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.INavigationViewStatics3
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [Guid(2607507895, 63302, 21840, 145, 225, 238, 12, 154, 133, 192, 94)]
  [ExclusiveTo(typeof (NavigationView))]
  internal interface INavigationViewStatics3
  {
    DependencyProperty PaneDisplayModeProperty { get; }

    DependencyProperty PaneHeaderProperty { get; }

    DependencyProperty PaneCustomContentProperty { get; }

    DependencyProperty ContentOverlayProperty { get; }

    DependencyProperty IsPaneVisibleProperty { get; }

    DependencyProperty SelectionFollowsFocusProperty { get; }

    DependencyProperty TemplateSettingsProperty { get; }

    DependencyProperty ShoulderNavigationEnabledProperty { get; }

    DependencyProperty OverflowLabelModeProperty { get; }
  }
}
