// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IGridStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [ExclusiveTo(typeof (Grid))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1694379679, 63825, 17078, 169, 206, 187, 23, 154, 241, 21, 149)]
  internal interface IGridStatics
  {
    DependencyProperty RowProperty { get; }

    int GetRow(FrameworkElement element);

    void SetRow(FrameworkElement element, int value);

    DependencyProperty ColumnProperty { get; }

    int GetColumn(FrameworkElement element);

    void SetColumn(FrameworkElement element, int value);

    DependencyProperty RowSpanProperty { get; }

    int GetRowSpan(FrameworkElement element);

    void SetRowSpan(FrameworkElement element, int value);

    DependencyProperty ColumnSpanProperty { get; }

    int GetColumnSpan(FrameworkElement element);

    void SetColumnSpan(FrameworkElement element, int value);
  }
}
