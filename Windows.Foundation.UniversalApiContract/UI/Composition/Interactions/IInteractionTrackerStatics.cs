// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.Interactions.IInteractionTrackerStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition.Interactions
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (InteractionTracker))]
  [Guid(3148208055, 26000, 17560, 141, 108, 235, 98, 181, 20, 201, 42)]
  internal interface IInteractionTrackerStatics
  {
    InteractionTracker Create(Compositor compositor);

    InteractionTracker CreateWithOwner(
      Compositor compositor,
      IInteractionTrackerOwner owner);
  }
}
