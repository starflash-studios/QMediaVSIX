// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Spatial.SpatialPointerPose
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Perception;
using Windows.Perception.People;
using Windows.Perception.Spatial;

namespace Windows.UI.Input.Spatial
{
  /// <summary>Represents the available spatial pointer poses, such as the user's head gaze, eye gaze and each motion controller's pointer pose, for use in targeting hand gestures, motion controller presses, and speech interactions.</summary>
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [Static(typeof (ISpatialPointerPoseStatics), 131072, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class SpatialPointerPose : 
    ISpatialPointerPose,
    ISpatialPointerPose2,
    ISpatialPointerPose3
  {
    /// <summary>Gets the timestamp when the pointing rays are determined.</summary>
    /// <returns>The timestamp.</returns>
    public extern PerceptionTimestamp Timestamp { [MethodImpl] get; }

    /// <summary>Gets the user's head gaze for this timestamp.</summary>
    /// <returns>The head gaze.</returns>
    public extern HeadPose Head { [MethodImpl] get; }

    /// <summary>Gets the pointer pose for a particular spatial interaction source, such as a motion controller, at a given timestamp.</summary>
    /// <param name="source">The spatial interaction source for which a pointer pose should be determined.</param>
    /// <returns>The interaction source pointer pose.</returns>
    [MethodImpl]
    public extern SpatialPointerInteractionSourcePose TryGetInteractionSourcePose(
      SpatialInteractionSource source);

    /// <summary>Gets the user's eye gaze for this timestamp.</summary>
    /// <returns>The eye gaze if supported by the current headset; otherwise, null.</returns>
    public extern EyesPose Eyes { [MethodImpl] get; }

    /// <summary>Gets whether the user's head gaze is being captured by system UI at the moment (preventing gaze-driven presses from being delivered to the view associated with this SpatialPointerPose ).</summary>
    /// <returns>Whether head gaze is being captured by the system.</returns>
    public extern bool IsHeadCapturedBySystem { [MethodImpl] get; }

    /// <summary>Gets the head gaze and motion controller pointer poses for the specified timestamp.</summary>
    /// <param name="coordinateSystem">The coordinate system in which to express the pointer poses.</param>
    /// <param name="timestamp">The timestamp, past or future.</param>
    /// <returns>The pointer poses, or null if the specified coordinate system cannot be located.</returns>
    [MethodImpl]
    public static extern SpatialPointerPose TryGetAtTimestamp(
      SpatialCoordinateSystem coordinateSystem,
      PerceptionTimestamp timestamp);
  }
}
