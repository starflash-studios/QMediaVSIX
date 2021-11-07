// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ISplitView
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Media;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [ExclusiveTo(typeof (SplitView))]
  [Guid(2535599921, 14404, 17054, 147, 156, 22, 115, 21, 83, 34, 161)]
  internal interface ISplitView
  {
    UIElement Content { get; set; }

    UIElement Pane { get; set; }

    bool IsPaneOpen { get; set; }

    double OpenPaneLength { get; set; }

    double CompactPaneLength { get; set; }

    SplitViewPanePlacement PanePlacement { get; set; }

    SplitViewDisplayMode DisplayMode { get; set; }

    SplitViewTemplateSettings TemplateSettings { get; }

    Brush PaneBackground { get; set; }

    event TypedEventHandler<SplitView, SplitViewPaneClosingEventArgs> PaneClosing;

    event TypedEventHandler<SplitView, object> PaneClosed;
  }
}
