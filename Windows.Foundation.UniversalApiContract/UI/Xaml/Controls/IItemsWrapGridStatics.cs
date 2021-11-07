// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IItemsWrapGridStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [Guid(1321550461, 9376, 17562, 183, 99, 48, 119, 186, 15, 45, 213)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [ExclusiveTo(typeof (ItemsWrapGrid))]
  internal interface IItemsWrapGridStatics
  {
    DependencyProperty GroupPaddingProperty { get; }

    DependencyProperty OrientationProperty { get; }

    DependencyProperty MaximumRowsOrColumnsProperty { get; }

    DependencyProperty ItemWidthProperty { get; }

    DependencyProperty ItemHeightProperty { get; }

    DependencyProperty GroupHeaderPlacementProperty { get; }

    DependencyProperty CacheLengthProperty { get; }
  }
}
