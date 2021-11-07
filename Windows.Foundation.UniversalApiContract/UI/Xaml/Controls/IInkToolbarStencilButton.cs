// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IInkToolbarStencilButton
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Input.Inking;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (InkToolbarStencilButton))]
  [Guid(812262934, 23360, 19443, 146, 183, 241, 223, 147, 106, 239, 245)]
  [WebHostHidden]
  internal interface IInkToolbarStencilButton
  {
    InkPresenterRuler Ruler { get; }

    InkPresenterProtractor Protractor { get; }

    InkToolbarStencilKind SelectedStencil { get; set; }

    bool IsRulerItemVisible { get; set; }

    bool IsProtractorItemVisible { get; set; }
  }
}
