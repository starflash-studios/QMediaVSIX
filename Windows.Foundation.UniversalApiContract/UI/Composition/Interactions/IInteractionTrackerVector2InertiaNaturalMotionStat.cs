// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.Interactions.IInteractionTrackerVector2InertiaNaturalMotionStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition.Interactions
{
  [ExclusiveTo(typeof (InteractionTrackerVector2InertiaNaturalMotion))]
  [Guid(2181044808, 2496, 17231, 129, 137, 20, 28, 102, 223, 54, 47)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  internal interface IInteractionTrackerVector2InertiaNaturalMotionStatics
  {
    InteractionTrackerVector2InertiaNaturalMotion Create(
      Compositor compositor);
  }
}
