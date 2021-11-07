// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IInkToolbarStencilButtonStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (InkToolbarStencilButton))]
  [WebHostHidden]
  [Guid(1195950207, 25572, 16909, 147, 154, 107, 114, 67, 233, 209, 36)]
  internal interface IInkToolbarStencilButtonStatics
  {
    DependencyProperty RulerProperty { get; }

    DependencyProperty ProtractorProperty { get; }

    DependencyProperty SelectedStencilProperty { get; }

    DependencyProperty IsRulerItemVisibleProperty { get; }

    DependencyProperty IsProtractorItemVisibleProperty { get; }
  }
}
