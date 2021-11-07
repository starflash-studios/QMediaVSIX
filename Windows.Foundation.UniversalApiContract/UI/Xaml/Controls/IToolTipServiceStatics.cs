// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IToolTipServiceStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls.Primitives;

namespace Windows.UI.Xaml.Controls
{
  [Guid(2263239160, 57925, 18602, 168, 200, 209, 7, 62, 215, 99, 25)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (ToolTipService))]
  internal interface IToolTipServiceStatics
  {
    DependencyProperty PlacementProperty { get; }

    PlacementMode GetPlacement(DependencyObject element);

    void SetPlacement(DependencyObject element, PlacementMode value);

    DependencyProperty PlacementTargetProperty { get; }

    UIElement GetPlacementTarget(DependencyObject element);

    void SetPlacementTarget(DependencyObject element, UIElement value);

    DependencyProperty ToolTipProperty { get; }

    object GetToolTip(DependencyObject element);

    void SetToolTip(DependencyObject element, object value);
  }
}
