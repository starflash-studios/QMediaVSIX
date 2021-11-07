// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.PointerPoint
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Devices.Input;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input
{
  /// <summary>Provides basic properties for the input pointer associated with a single mouse, pen/stylus, or touch contact.</summary>
  [MarshalingBehavior(MarshalingType.None)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IPointerPointStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class PointerPoint : IPointerPoint
  {
    /// <summary>Gets information about the device associated with the input pointer.</summary>
    /// <returns>The input device.</returns>
    public extern PointerDevice PointerDevice { [MethodImpl] get; }

    /// <summary>Gets the location of the pointer input in client coordinates.</summary>
    /// <returns>The client coordinates, in device-independent pixel (DIP).</returns>
    public extern Point Position { [MethodImpl] get; }

    /// <summary>Gets the client coordinates of the input pointer as reported by the input device.</summary>
    /// <returns>The client coordinates, in device-independent pixels (DIP).</returns>
    public extern Point RawPosition { [MethodImpl] get; }

    /// <summary>Gets a unique identifier for the input pointer.</summary>
    /// <returns>A unique value that identifies the input pointer.</returns>
    public extern uint PointerId { [MethodImpl] get; }

    /// <summary>Gets the ID of an input frame.</summary>
    /// <returns>The frame ID.</returns>
    public extern uint FrameId { [MethodImpl] get; }

    /// <summary>Gets the time when the input occurred.</summary>
    /// <returns>The time, relative to the system boot time, in microseconds.</returns>
    public extern ulong Timestamp { [MethodImpl] get; }

    /// <summary>Gets a value that indicates whether the input device (touch, pen/stylus) is touching the digitizer surface, or a mouse button is pressed down.</summary>
    /// <returns>True if pressed down; false otherwise.</returns>
    public extern bool IsInContact { [MethodImpl] get; }

    /// <summary>Gets extended information about the input pointer.</summary>
    /// <returns>The extended properties exposed by the input device.</returns>
    public extern PointerPointProperties Properties { [MethodImpl] get; }

    /// <summary>Retrieves position and state information for the specified pointer.</summary>
    /// <param name="pointerId">The ID of the pointer.</param>
    /// <returns>The pointer property values.</returns>
    [Overload("GetCurrentPoint")]
    [MethodImpl]
    public static extern PointerPoint GetCurrentPoint(uint pointerId);

    /// <summary>Retrieves position and state information for the specified pointer, from the last pointer event up to and including the current pointer event.</summary>
    /// <param name="pointerId">The ID of the pointer.</param>
    /// <returns>The transformed pointer properties (current and historic).</returns>
    [Overload("GetIntermediatePoints")]
    [MethodImpl]
    public static extern IVector<PointerPoint> GetIntermediatePoints(
      uint pointerId);

    /// <summary>Retrieves the transformed information for the specified pointer.</summary>
    /// <param name="pointerId">The ID of the pointer.</param>
    /// <param name="transform">The transform to apply to the pointer.</param>
    /// <returns>The pointer property values.</returns>
    [Overload("GetCurrentPointTransformed")]
    [MethodImpl]
    public static extern PointerPoint GetCurrentPoint(
      uint pointerId,
      IPointerPointTransform transform);

    /// <summary>Retrieves the transformed position and state information for the specified pointer, from the last pointer event up to and including the current pointer event.</summary>
    /// <param name="pointerId">The ID of the pointer.</param>
    /// <param name="transform">The transform to apply to the pointer.</param>
    /// <returns>The transformed pointer properties (current and historic).</returns>
    [Overload("GetIntermediatePointsTransformed")]
    [MethodImpl]
    public static extern IVector<PointerPoint> GetIntermediatePoints(
      uint pointerId,
      IPointerPointTransform transform);
  }
}
