// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.Interactions.IVisualInteractionSource2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Windows.UI.Composition.Interactions
{
  [Guid(2861648019, 42812, 16717, 128, 208, 36, 155, 173, 47, 189, 147)]
  [ExclusiveTo(typeof (VisualInteractionSource))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [WebHostHidden]
  internal interface IVisualInteractionSource2
  {
    Vector3 DeltaPosition { get; }

    float DeltaScale { get; }

    Vector3 Position { get; }

    Vector3 PositionVelocity { get; }

    float Scale { get; }

    float ScaleVelocity { get; }

    void ConfigureCenterPointXModifiers(
      IIterable<CompositionConditionalValue> conditionalValues);

    void ConfigureCenterPointYModifiers(
      IIterable<CompositionConditionalValue> conditionalValues);

    void ConfigureDeltaPositionXModifiers(
      IIterable<CompositionConditionalValue> conditionalValues);

    void ConfigureDeltaPositionYModifiers(
      IIterable<CompositionConditionalValue> conditionalValues);

    void ConfigureDeltaScaleModifiers(
      IIterable<CompositionConditionalValue> conditionalValues);
  }
}
