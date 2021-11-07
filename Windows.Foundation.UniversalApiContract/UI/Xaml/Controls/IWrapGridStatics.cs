// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IWrapGridStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ExclusiveTo(typeof (WrapGrid))]
  [WebHostHidden]
  [Guid(3494538135, 5067, 18332, 162, 133, 228, 229, 104, 70, 196, 203)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IWrapGridStatics
  {
    DependencyProperty ItemWidthProperty { get; }

    DependencyProperty ItemHeightProperty { get; }

    DependencyProperty OrientationProperty { get; }

    DependencyProperty HorizontalChildrenAlignmentProperty { get; }

    DependencyProperty VerticalChildrenAlignmentProperty { get; }

    DependencyProperty MaximumRowsOrColumnsProperty { get; }
  }
}
