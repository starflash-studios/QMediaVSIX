// Decompiled with JetBrains decompiler
// Type: Windows.UI.Core.ITouchHitTestingEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Core
{
  [WebHostHidden]
  [Guid(586397731, 2940, 16974, 157, 247, 51, 212, 249, 98, 147, 27)]
  [ExclusiveTo(typeof (TouchHitTestingEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ITouchHitTestingEventArgs : ICoreWindowEventArgs
  {
    CoreProximityEvaluation ProximityEvaluation { get; set; }

    Point Point { get; }

    Rect BoundingBox { get; }

    [Overload("EvaluateProximityToRect")]
    [DefaultOverload]
    CoreProximityEvaluation EvaluateProximity(Rect controlBoundingBox);

    [Overload("EvaluateProximityToPolygon")]
    CoreProximityEvaluation EvaluateProximity(Point[] controlVertices);
  }
}
