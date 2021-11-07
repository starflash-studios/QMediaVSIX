// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.Interactions.IInteractionTracker
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Windows.UI.Composition.Interactions
{
  [Guid(713985201, 4096, 17430, 131, 99, 204, 39, 251, 135, 115, 8)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (InteractionTracker))]
  [WebHostHidden]
  internal interface IInteractionTracker
  {
    CompositionInteractionSourceCollection InteractionSources { get; }

    bool IsPositionRoundingSuggested { get; }

    Vector3 MaxPosition { get; set; }

    float MaxScale { get; set; }

    Vector3 MinPosition { get; set; }

    float MinScale { get; set; }

    Vector3 NaturalRestingPosition { get; }

    float NaturalRestingScale { get; }

    IInteractionTrackerOwner Owner { get; }

    Vector3 Position { get; }

    IReference<Vector3> PositionInertiaDecayRate { get; set; }

    Vector3 PositionVelocityInPixelsPerSecond { get; }

    float Scale { get; }

    IReference<float> ScaleInertiaDecayRate { get; set; }

    float ScaleVelocityInPercentPerSecond { get; }

    void AdjustPositionXIfGreaterThanThreshold(float adjustment, float positionThreshold);

    void AdjustPositionYIfGreaterThanThreshold(float adjustment, float positionThreshold);

    void ConfigurePositionXInertiaModifiers(
      IIterable<InteractionTrackerInertiaModifier> modifiers);

    void ConfigurePositionYInertiaModifiers(
      IIterable<InteractionTrackerInertiaModifier> modifiers);

    void ConfigureScaleInertiaModifiers(
      IIterable<InteractionTrackerInertiaModifier> modifiers);

    int TryUpdatePosition(Vector3 value);

    int TryUpdatePositionBy(Vector3 amount);

    int TryUpdatePositionWithAnimation(CompositionAnimation animation);

    int TryUpdatePositionWithAdditionalVelocity(Vector3 velocityInPixelsPerSecond);

    int TryUpdateScale(float value, Vector3 centerPoint);

    int TryUpdateScaleWithAnimation(CompositionAnimation animation, Vector3 centerPoint);

    int TryUpdateScaleWithAdditionalVelocity(float velocityInPercentPerSecond, Vector3 centerPoint);
  }
}
