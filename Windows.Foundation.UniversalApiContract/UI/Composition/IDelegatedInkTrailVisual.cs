// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.IDelegatedInkTrailVisual
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition
{
  [ExclusiveTo(typeof (DelegatedInkTrailVisual))]
  [ContractVersion(typeof (UniversalApiContract), 786432)]
  [Guid(2238603441, 57771, 23331, 142, 61, 213, 19, 242, 33, 201, 152)]
  [WebHostHidden]
  internal interface IDelegatedInkTrailVisual
  {
    uint AddTrailPoints(InkTrailPoint[] inkPoints);

    uint AddTrailPointsWithPrediction(InkTrailPoint[] inkPoints, InkTrailPoint[] predictedInkPoints);

    void RemoveTrailPoints(uint generationId);

    void StartNewTrail(Color color);
  }
}
