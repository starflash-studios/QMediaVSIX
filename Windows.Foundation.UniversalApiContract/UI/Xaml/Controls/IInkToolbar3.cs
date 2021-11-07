// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IInkToolbar3
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Input.Inking;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  [ExclusiveTo(typeof (InkToolbar))]
  [Guid(2829508336, 31400, 21286, 183, 196, 136, 174, 37, 1, 51, 98)]
  internal interface IInkToolbar3
  {
    InkPresenter TargetInkPresenter { get; set; }
  }
}
