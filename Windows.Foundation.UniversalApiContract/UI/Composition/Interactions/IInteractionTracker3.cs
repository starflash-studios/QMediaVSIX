// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.Interactions.IInteractionTracker3
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition.Interactions
{
  [ExclusiveTo(typeof (InteractionTracker))]
  [WebHostHidden]
  [Guid(3871725474, 23627, 17094, 132, 183, 246, 148, 65, 177, 128, 145)]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  internal interface IInteractionTracker3
  {
    void ConfigureVector2PositionInertiaModifiers(
      IIterable<InteractionTrackerVector2InertiaModifier> modifiers);
  }
}
