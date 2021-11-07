// Decompiled with JetBrains decompiler
// Type: Windows.UI.Core.CoreProximityEvaluation
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Core
{
  /// <summary>Contains the rank of an object as the probable target of the touch contact area.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  public struct CoreProximityEvaluation
  {
    /// <summary>Rank of an object as the probable target compared to the other objects that intersect the touch contact area. The value is a CoreProximityEvaluationScore.</summary>
    public int Score;
    /// <summary>Adjusted touch point that hits the closest object identified by the value of **Score**.</summary>
    public Point AdjustedPoint;
  }
}
