// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.Interactions.IInteractionTrackerInertiaStateEnteredArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Windows.UI.Composition.Interactions
{
  [ExclusiveTo(typeof (InteractionTrackerInertiaStateEnteredArgs))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [WebHostHidden]
  [Guid(2266008818, 59391, 20349, 159, 253, 215, 47, 30, 64, 155, 99)]
  internal interface IInteractionTrackerInertiaStateEnteredArgs
  {
    IReference<Vector3> ModifiedRestingPosition { get; }

    IReference<float> ModifiedRestingScale { get; }

    Vector3 NaturalRestingPosition { get; }

    float NaturalRestingScale { get; }

    Vector3 PositionVelocityInPixelsPerSecond { get; }

    int RequestId { get; }

    float ScaleVelocityInPercentPerSecond { get; }
  }
}
