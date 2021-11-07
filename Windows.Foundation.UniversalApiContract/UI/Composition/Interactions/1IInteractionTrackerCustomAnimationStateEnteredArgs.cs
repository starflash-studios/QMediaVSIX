// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.Interactions.IInteractionTrackerCustomAnimationStateEnteredArgs2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition.Interactions
{
  [ExclusiveTo(typeof (InteractionTrackerCustomAnimationStateEnteredArgs))]
  [WebHostHidden]
  [Guid(1205172663, 2437, 24217, 176, 36, 47, 50, 195, 128, 193, 164)]
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  internal interface IInteractionTrackerCustomAnimationStateEnteredArgs2
  {
    bool IsFromBinding { get; }
  }
}
