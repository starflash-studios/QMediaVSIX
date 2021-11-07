// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Spatial.SpatialInteractionManager
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Perception;

namespace Windows.UI.Input.Spatial
{
  /// <summary>Provides access to user input from hands, motion controllers, and system voice commands.</summary>
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [Static(typeof (ISpatialInteractionManagerStatics), 131072, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (ISpatialInteractionManagerStatics2), 524288, "Windows.Foundation.UniversalApiContract")]
  public sealed class SpatialInteractionManager : ISpatialInteractionManager
  {
    /// <summary>Occurs when a new hand, motion controller, or speech source has been detected.</summary>
    public extern event TypedEventHandler<SpatialInteractionManager, SpatialInteractionSourceEventArgs> SourceDetected;

    /// <summary>Occurs when a hand, motion controller, or speech source is no longer available.</summary>
    public extern event TypedEventHandler<SpatialInteractionManager, SpatialInteractionSourceEventArgs> SourceLost;

    /// <summary>Occurs when a hand, motion controller, or speech source has experienced a change to its SpatialInteractionSourceState.</summary>
    public extern event TypedEventHandler<SpatialInteractionManager, SpatialInteractionSourceEventArgs> SourceUpdated;

    /// <summary>Occurs when a hand, motion controller, or speech source has entered a pressed state.</summary>
    public extern event TypedEventHandler<SpatialInteractionManager, SpatialInteractionSourceEventArgs> SourcePressed;

    /// <summary>Occurs when a hand, motion controller, or speech source has exited a pressed state.</summary>
    public extern event TypedEventHandler<SpatialInteractionManager, SpatialInteractionSourceEventArgs> SourceReleased;

    /// <summary>Occurs when a new interaction is available for routing to a SpatialGestureRecognizer.</summary>
    public extern event TypedEventHandler<SpatialInteractionManager, SpatialInteractionDetectedEventArgs> InteractionDetected;

    /// <summary>Get the state of all interaction sources detected for the specified timestamp.</summary>
    /// <param name="timeStamp">The time to query the state of interaction sources.</param>
    /// <returns>The source states detected.</returns>
    [MethodImpl]
    public extern IVectorView<SpatialInteractionSourceState> GetDetectedSourcesAtTimestamp(
      PerceptionTimestamp timeStamp);

    /// <summary>Gets whether the specified interaction source is supported on this device.</summary>
    /// <param name="kind">The interaction source.</param>
    /// <returns>Whether the interaction source is supported.</returns>
    [MethodImpl]
    public static extern bool IsSourceKindSupported(SpatialInteractionSourceKind kind);

    /// <summary>Get the SpatialInteractionManager associated with the current CoreWindow.</summary>
    /// <returns>The spatial interaction manager.</returns>
    [MethodImpl]
    public static extern SpatialInteractionManager GetForCurrentView();
  }
}
