// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IRelativePanelStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Guid(361774119, 61836, 19509, 142, 25, 106, 116, 89, 217, 7, 182)]
  [ExclusiveTo(typeof (RelativePanel))]
  internal interface IRelativePanelStatics
  {
    DependencyProperty LeftOfProperty { get; }

    object GetLeftOf(UIElement element);

    void SetLeftOf(UIElement element, object value);

    DependencyProperty AboveProperty { get; }

    object GetAbove(UIElement element);

    void SetAbove(UIElement element, object value);

    DependencyProperty RightOfProperty { get; }

    object GetRightOf(UIElement element);

    void SetRightOf(UIElement element, object value);

    DependencyProperty BelowProperty { get; }

    object GetBelow(UIElement element);

    void SetBelow(UIElement element, object value);

    DependencyProperty AlignHorizontalCenterWithProperty { get; }

    object GetAlignHorizontalCenterWith(UIElement element);

    void SetAlignHorizontalCenterWith(UIElement element, object value);

    DependencyProperty AlignVerticalCenterWithProperty { get; }

    object GetAlignVerticalCenterWith(UIElement element);

    void SetAlignVerticalCenterWith(UIElement element, object value);

    DependencyProperty AlignLeftWithProperty { get; }

    object GetAlignLeftWith(UIElement element);

    void SetAlignLeftWith(UIElement element, object value);

    DependencyProperty AlignTopWithProperty { get; }

    object GetAlignTopWith(UIElement element);

    void SetAlignTopWith(UIElement element, object value);

    DependencyProperty AlignRightWithProperty { get; }

    object GetAlignRightWith(UIElement element);

    void SetAlignRightWith(UIElement element, object value);

    DependencyProperty AlignBottomWithProperty { get; }

    object GetAlignBottomWith(UIElement element);

    void SetAlignBottomWith(UIElement element, object value);

    DependencyProperty AlignLeftWithPanelProperty { get; }

    bool GetAlignLeftWithPanel(UIElement element);

    void SetAlignLeftWithPanel(UIElement element, bool value);

    DependencyProperty AlignTopWithPanelProperty { get; }

    bool GetAlignTopWithPanel(UIElement element);

    void SetAlignTopWithPanel(UIElement element, bool value);

    DependencyProperty AlignRightWithPanelProperty { get; }

    bool GetAlignRightWithPanel(UIElement element);

    void SetAlignRightWithPanel(UIElement element, bool value);

    DependencyProperty AlignBottomWithPanelProperty { get; }

    bool GetAlignBottomWithPanel(UIElement element);

    void SetAlignBottomWithPanel(UIElement element, bool value);

    DependencyProperty AlignHorizontalCenterWithPanelProperty { get; }

    bool GetAlignHorizontalCenterWithPanel(UIElement element);

    void SetAlignHorizontalCenterWithPanel(UIElement element, bool value);

    DependencyProperty AlignVerticalCenterWithPanelProperty { get; }

    bool GetAlignVerticalCenterWithPanel(UIElement element);

    void SetAlignVerticalCenterWithPanel(UIElement element, bool value);

    DependencyProperty BorderBrushProperty { get; }

    DependencyProperty BorderThicknessProperty { get; }

    DependencyProperty CornerRadiusProperty { get; }

    DependencyProperty PaddingProperty { get; }
  }
}
