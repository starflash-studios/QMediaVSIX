// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IToolTip
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls.Primitives;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (ToolTip))]
  [Guid(2112214879, 17429, 17055, 181, 35, 105, 155, 219, 140, 48, 219)]
  [WebHostHidden]
  internal interface IToolTip
  {
    double HorizontalOffset { get; set; }

    bool IsOpen { get; set; }

    PlacementMode Placement { get; set; }

    UIElement PlacementTarget { get; set; }

    double VerticalOffset { get; set; }

    ToolTipTemplateSettings TemplateSettings { get; }

    event RoutedEventHandler Closed;

    event RoutedEventHandler Opened;
  }
}
