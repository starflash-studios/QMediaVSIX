// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Inking.IInkPresenterRuler2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input.Inking
{
  [ExclusiveTo(typeof (InkPresenterRuler))]
  [WebHostHidden]
  [Guid(1158876609, 48225, 17620, 164, 35, 84, 113, 42, 230, 113, 196)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface IInkPresenterRuler2
  {
    bool AreTickMarksVisible { get; set; }

    bool IsCompassVisible { get; set; }
  }
}
