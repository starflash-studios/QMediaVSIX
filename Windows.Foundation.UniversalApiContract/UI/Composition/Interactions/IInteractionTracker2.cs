// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.Interactions.IInteractionTracker2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition.Interactions
{
  [Guid(628529726, 52845, 17548, 131, 134, 146, 98, 13, 36, 7, 86)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (InteractionTracker))]
  internal interface IInteractionTracker2
  {
    void ConfigureCenterPointXInertiaModifiers(
      IIterable<CompositionConditionalValue> conditionalValues);

    void ConfigureCenterPointYInertiaModifiers(
      IIterable<CompositionConditionalValue> conditionalValues);
  }
}
