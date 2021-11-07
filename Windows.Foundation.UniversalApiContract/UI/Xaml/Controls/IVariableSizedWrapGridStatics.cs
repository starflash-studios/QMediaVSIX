// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IVariableSizedWrapGridStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [Guid(4271749209, 33063, 19183, 183, 162, 148, 152, 71, 72, 110, 150)]
  [ExclusiveTo(typeof (VariableSizedWrapGrid))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  internal interface IVariableSizedWrapGridStatics
  {
    DependencyProperty ItemHeightProperty { get; }

    DependencyProperty ItemWidthProperty { get; }

    DependencyProperty OrientationProperty { get; }

    DependencyProperty HorizontalChildrenAlignmentProperty { get; }

    DependencyProperty VerticalChildrenAlignmentProperty { get; }

    DependencyProperty MaximumRowsOrColumnsProperty { get; }

    DependencyProperty RowSpanProperty { get; }

    int GetRowSpan(UIElement element);

    void SetRowSpan(UIElement element, int value);

    DependencyProperty ColumnSpanProperty { get; }

    int GetColumnSpan(UIElement element);

    void SetColumnSpan(UIElement element, int value);
  }
}
