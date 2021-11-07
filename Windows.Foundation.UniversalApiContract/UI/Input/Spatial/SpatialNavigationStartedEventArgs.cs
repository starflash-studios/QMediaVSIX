// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Spatial.SpatialNavigationStartedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Perception.Spatial;

namespace Windows.UI.Input.Spatial
{
  /// <summary>Provides data for the SpatialGestureRecognizer.NavigationStarted event.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  public sealed class SpatialNavigationStartedEventArgs : ISpatialNavigationStartedEventArgs
  {
    /// <summary>Gets the kind of interaction source associated with this gesture.</summary>
    /// <returns>The interaction source kind.</returns>
    public extern SpatialInteractionSourceKind InteractionSourceKind { [MethodImpl] get; }

    /// <summary>Gets the available pointer poses, such as the user's head gaze and each motion controller's pointer pose, for use in targeting this gesture.</summary>
    /// <param name="coordinateSystem">The coordinate system in which to express the pointer poses.</param>
    /// <returns>The pointer poses.</returns>
    [MethodImpl]
    public extern SpatialPointerPose TryGetPointerPose(
      SpatialCoordinateSystem coordinateSystem);

    /// <summary>Gets whether the navigation gesture the user is performing involves motion on the horizontal axis.</summary>
    /// <returns>Whether the gesture involves horizontal navigation.</returns>
    public extern bool IsNavigatingX { [MethodImpl] get; }

    /// <summary>Gets whether the navigation gesture the user is performing involves motion on the vertical axis.</summary>
    /// <returns>Whether the gesture involves vertical navigation.</returns>
    public extern bool IsNavigatingY { [MethodImpl] get; }

    /// <summary>Gets whether the navigation gesture the user is performing involves motion on the depth axis.</summary>
    /// <returns>Whether the gesture involves depth navigation.</returns>
    public extern bool IsNavigatingZ { [MethodImpl] get; }
  }
}
