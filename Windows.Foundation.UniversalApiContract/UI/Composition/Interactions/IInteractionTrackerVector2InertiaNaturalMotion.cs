// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.Interactions.IInteractionTrackerVector2InertiaNaturalMotion
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition.Interactions
{
  [Guid(1595369820, 5677, 19463, 148, 0, 194, 130, 178, 130, 118, 202)]
  [ExclusiveTo(typeof (InteractionTrackerVector2InertiaNaturalMotion))]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  internal interface IInteractionTrackerVector2InertiaNaturalMotion
  {
    ExpressionAnimation Condition { get; set; }

    Vector2NaturalMotionAnimation NaturalMotion { get; set; }
  }
}
