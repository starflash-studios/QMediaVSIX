// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.INavigationView3
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ExclusiveTo(typeof (NavigationView))]
  [Guid(2413800294, 39868, 24483, 144, 67, 160, 43, 180, 248, 239, 55)]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [WebHostHidden]
  internal interface INavigationView3
  {
    NavigationViewPaneDisplayMode PaneDisplayMode { get; set; }

    UIElement PaneHeader { get; set; }

    UIElement PaneCustomContent { get; set; }

    UIElement ContentOverlay { get; set; }

    bool IsPaneVisible { get; set; }

    NavigationViewSelectionFollowsFocus SelectionFollowsFocus { get; set; }

    NavigationViewTemplateSettings TemplateSettings { get; }

    NavigationViewShoulderNavigationEnabled ShoulderNavigationEnabled { get; set; }

    NavigationViewOverflowLabelMode OverflowLabelMode { get; set; }
  }
}
