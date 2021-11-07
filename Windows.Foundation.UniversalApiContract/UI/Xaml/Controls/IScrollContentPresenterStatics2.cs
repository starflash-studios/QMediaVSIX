// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IScrollContentPresenterStatics2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [Guid(3782410010, 50806, 21067, 143, 32, 150, 21, 33, 73, 208, 94)]
  [ExclusiveTo(typeof (ScrollContentPresenter))]
  [WebHostHidden]
  internal interface IScrollContentPresenterStatics2
  {
    DependencyProperty CanContentRenderOutsideBoundsProperty { get; }

    DependencyProperty SizesContentToTemplatedParentProperty { get; }
  }
}
