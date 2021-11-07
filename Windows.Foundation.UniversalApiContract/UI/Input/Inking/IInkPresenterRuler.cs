// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Inking.IInkPresenterRuler
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input.Inking
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [WebHostHidden]
  [ExclusiveTo(typeof (InkPresenterRuler))]
  [Guid(1826258266, 57031, 19927, 135, 122, 33, 51, 241, 131, 212, 138)]
  internal interface IInkPresenterRuler : IInkPresenterStencil
  {
    double Length { get; set; }

    double Width { get; set; }
  }
}
