// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Inking.IInkPresenterProtractor
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input.Inking
{
  [ExclusiveTo(typeof (InkPresenterProtractor))]
  [Guid(2112090794, 61292, 20113, 167, 59, 91, 112, 213, 111, 189, 23)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface IInkPresenterProtractor : IInkPresenterStencil
  {
    bool AreTickMarksVisible { get; set; }

    bool AreRaysVisible { get; set; }

    bool IsCenterMarkerVisible { get; set; }

    bool IsAngleReadoutVisible { get; set; }

    bool IsResizable { get; set; }

    double Radius { get; set; }

    Color AccentColor { get; set; }
  }
}
