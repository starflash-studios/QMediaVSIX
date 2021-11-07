// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.Interactions.IInteractionTracker5
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Windows.UI.Composition.Interactions
{
  [Guid(3555679650, 41556, 16612, 136, 213, 68, 228, 225, 107, 88, 9)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 655360)]
  [ExclusiveTo(typeof (InteractionTracker))]
  internal interface IInteractionTracker5
  {
    [Overload("TryUpdatePositionWithOption")]
    int TryUpdatePosition(
      Vector3 value,
      InteractionTrackerClampingOption option,
      InteractionTrackerPositionUpdateOption posUpdateOption);
  }
}
