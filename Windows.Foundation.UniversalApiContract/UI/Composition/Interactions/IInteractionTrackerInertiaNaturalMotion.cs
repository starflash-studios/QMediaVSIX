// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.Interactions.IInteractionTrackerInertiaNaturalMotion
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition.Interactions
{
  [Guid(1890376366, 10204, 18669, 163, 195, 109, 97, 201, 160, 41, 210)]
  [ExclusiveTo(typeof (InteractionTrackerInertiaNaturalMotion))]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [WebHostHidden]
  internal interface IInteractionTrackerInertiaNaturalMotion
  {
    ExpressionAnimation Condition { get; set; }

    ScalarNaturalMotionAnimation NaturalMotion { get; set; }
  }
}
