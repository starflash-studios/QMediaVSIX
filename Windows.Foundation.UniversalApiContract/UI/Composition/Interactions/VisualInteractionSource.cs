// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.Interactions.VisualInteractionSource
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;
using Windows.UI.Input;

namespace Windows.UI.Composition.Interactions
{
  /// <summary>Object for configuring input to the InteractionTracker relative to a visual.</summary>
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Static(typeof (IVisualInteractionSourceStatics), 196608, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IVisualInteractionSourceStatics2), 524288, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Composable(typeof (IVisualInteractionSourceObjectFactory), CompositionType.Public, 262144, "Windows.Foundation.UniversalApiContract")]
  [DualApiPartition(version = 167772164)]
  [Threading(ThreadingModel.Both)]
  public class VisualInteractionSource : 
    CompositionObject,
    IVisualInteractionSource,
    IVisualInteractionSource2,
    IVisualInteractionSource3,
    ICompositionInteractionSource
  {
    /// <summary>Indicates whether panning on the x-axis is railed.</summary>
    /// <returns>Boolean value indicating whether panning on the x-axis is railed.</returns>
    public extern bool IsPositionXRailsEnabled { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Indicates whether panning on the y-axis is railed.</summary>
    /// <returns>Boolean value indicating whether panning on the y-axis is railed.</returns>
    public extern bool IsPositionYRailsEnabled { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Indicates what input should be redirected to the InteractionTracker.</summary>
    /// <returns>Indicates what input should be redirected to the InteractionTracker.</returns>
    public extern VisualInteractionSourceRedirectionMode ManipulationRedirectionMode { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>The PositionXChainingMode property defines the chaining behavior for an InteractionSource in the X direction. There are three types of InteractionChainingMode s: </summary>
    /// <returns>Chaining mode for the X-axis.</returns>
    public extern InteractionChainingMode PositionXChainingMode { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Source mode for the X-axis.</summary>
    /// <returns>Source mode for the X-axis.</returns>
    public extern InteractionSourceMode PositionXSourceMode { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>The PositionYChainingMode property defines the chaining behavior for an InteractionSource in the Y direction. There are three types of InteractionChainingMode s: </summary>
    /// <returns>Chaining mode for the Y-axis.</returns>
    public extern InteractionChainingMode PositionYChainingMode { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Source mode for the Y-axis.</summary>
    /// <returns>Source mode for the Y-axis.</returns>
    public extern InteractionSourceMode PositionYSourceMode { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>The ScaleChainingMode property defines the chaining behavior for an InteractionSource in the Scale direction. There are three types of InteractionChainingMode s: Auto, Always, Never. When Scale chaining is enabled, input will flow to the nearest ancestor’s VisualInteractionSource whenever the interaction (such as panning) would otherwise take InteractionTracker ’s position past it’s minimum or maximum Scale position.</summary>
    /// <returns>Chaining mode for the scale axis.</returns>
    public extern InteractionChainingMode ScaleChainingMode { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Defines how interactions are processed for an VisualInteractionSource on the scale axis. There are 3 types of InteractionSourceMode s to choose from: Interactions are </summary>
    /// <returns>Source mode for the scale axis.</returns>
    public extern InteractionSourceMode ScaleSourceMode { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>The visual that is used for hit-testing and defines the co-ordinate space for gesture recognition.</summary>
    /// <returns>The visual that is used for hit-testing and defines the co-ordinate space for gesture recognition.</returns>
    public extern Visual Source { [MethodImpl] get; }

    /// <summary>Indicates that configured manipulations for the given pointer stream should be sent to the InteractionTracker, not the app's UI thread, starting at the given PointerPoint.</summary>
    /// <param name="pointerPoint">Indicates that configured manipulations for the given pointer stream should be sent to the InteractionTracker, not the app's UI thread, starting at the given PointerPoint.</param>
    [MethodImpl]
    public extern void TryRedirectForManipulation(PointerPoint pointerPoint);

    /// <summary>The amount of position change to be applied during the upcoming frame. Defaults to 0. Readable only via expression/animation.</summary>
    /// <returns>The change in position of the interaction source.</returns>
    public extern Vector3 DeltaPosition { [MethodImpl] get; }

    /// <summary>The amount of scale change to be applied during the upcoming frame. Multiplicative. Defaults to 1. Readable only via expression/animation.</summary>
    /// <returns>The change in scale of the visual interaction source.</returns>
    public extern float DeltaScale { [MethodImpl] get; }

    /// <summary>The total amount of position change since the start of the interaction. Defaults to 0. Readable only via expression/animation.</summary>
    /// <returns>The position of the interaction source.</returns>
    public extern Vector3 Position { [MethodImpl] get; }

    /// <summary>The instantaneous rate of change of position in the interaction, in pixels per second. Defaults to 0. Readble only via expression/animation.</summary>
    /// <returns>The position velocity of the interaction source.</returns>
    public extern Vector3 PositionVelocity { [MethodImpl] get; }

    /// <summary>The total percentage-difference in scale since the start of the interaction. Multiplicative. Defaults to 1. Readable only via expression/animation.</summary>
    /// <returns>The scale of the interaction source.</returns>
    public extern float Scale { [MethodImpl] get; }

    /// <summary>The instantaneous rate of change of scale in the interaction, in percent per second. Additive. Defaults to 0. Readble only via expression/animation.</summary>
    /// <returns>The scale velocity of the interaction source.</returns>
    public extern float ScaleVelocity { [MethodImpl] get; }

    [MethodImpl]
    public extern void ConfigureCenterPointXModifiers(
      IIterable<CompositionConditionalValue> conditionalValues);

    [MethodImpl]
    public extern void ConfigureCenterPointYModifiers(
      IIterable<CompositionConditionalValue> conditionalValues);

    [MethodImpl]
    public extern void ConfigureDeltaPositionXModifiers(
      IIterable<CompositionConditionalValue> conditionalValues);

    [MethodImpl]
    public extern void ConfigureDeltaPositionYModifiers(
      IIterable<CompositionConditionalValue> conditionalValues);

    [MethodImpl]
    public extern void ConfigureDeltaScaleModifiers(
      IIterable<CompositionConditionalValue> conditionalValues);

    /// <summary>Gets the configuration for pointer wheel input.</summary>
    /// <returns>The configuration for pointer wheel input.</returns>
    public extern InteractionSourceConfiguration PointerWheelConfig { [MethodImpl] get; }

    /// <summary>Creates an instance of VisualInteractionSource from an element that implements IVisualElement.</summary>
    /// <param name="source">The element to use as the source of the interaction, typically a XAML UIElement.</param>
    /// <returns>Returns the created VisualInteractionSource object.</returns>
    [MethodImpl]
    public static extern VisualInteractionSource CreateFromIVisualElement(
      IVisualElement source);

    /// <summary>Creates an instance of VisualInteractionSource.</summary>
    /// <param name="source">The visual to use as the source of the interaction.</param>
    /// <returns>Returns the created VisualInteractionSource object.</returns>
    [MethodImpl]
    public static extern VisualInteractionSource Create(Visual source);
  }
}
