// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.Interactions.IInteractionTracker4
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Windows.UI.Composition.Interactions
{
  [Guid(3956417212, 1199, 19143, 132, 125, 6, 234, 54, 232, 10, 22)]
  [ExclusiveTo(typeof (InteractionTracker))]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [WebHostHidden]
  internal interface IInteractionTracker4
  {
    [Overload("TryUpdatePositionWithOption")]
    int TryUpdatePosition(Vector3 value, InteractionTrackerClampingOption option);

    [Overload("TryUpdatePositionByWithOption")]
    int TryUpdatePositionBy(Vector3 amount, InteractionTrackerClampingOption option);

    bool IsInertiaFromImpulse { get; }
  }
}
