// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IGridStatics2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [Guid(761685592, 22710, 18971, 132, 27, 135, 91, 169, 59, 93, 106)]
  [ExclusiveTo(typeof (Grid))]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IGridStatics2
  {
    DependencyProperty BorderBrushProperty { get; }

    DependencyProperty BorderThicknessProperty { get; }

    DependencyProperty CornerRadiusProperty { get; }

    DependencyProperty PaddingProperty { get; }
  }
}
