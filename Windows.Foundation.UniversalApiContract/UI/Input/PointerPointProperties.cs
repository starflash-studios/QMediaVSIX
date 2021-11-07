// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.PointerPointProperties
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input
{
  /// <summary>Provides extended properties for a PointerPoint object.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.None)]
  public sealed class PointerPointProperties : IPointerPointProperties, IPointerPointProperties2
  {
    /// <summary>Gets a value that indicates the force that the pointer device (typically a pen/stylus) exerts on the surface of the digitizer.</summary>
    /// <returns>A value from 0 to 1.0. The default value is 0.5.</returns>
    public extern float Pressure { [MethodImpl] get; }

    /// <summary>Gets a value that indicates whether the digitizer pen is inverted.</summary>
    /// <returns>True if inverted; otherwise false.</returns>
    public extern bool IsInverted { [MethodImpl] get; }

    /// <summary>Gets a value that indicates whether the input is from a pen eraser.</summary>
    /// <returns>True if the input is from a pen eraser; otherwise false.</returns>
    public extern bool IsEraser { [MethodImpl] get; }

    /// <summary>Gets the counter-clockwise angle of rotation around the major axis of the pointer device (the z-axis, perpendicular to the surface of the digitizer). A value of 0.0 degrees indicates the device is oriented towards the top of the digitizer.</summary>
    /// <returns>A value between 0.0 and 359.0 in degrees of rotation. The default value is 0.0.</returns>
    public extern float Orientation { [MethodImpl] get; }

    /// <summary>Gets the plane angle between the Y-Z plane and the plane that contains the Y axis and the axis of the input device (typically a pen/stylus).</summary>
    /// <returns>The value is 0.0 when the finger or pen is perpendicular to the digitizer surface, between 0.0 and 90.0 when tilted to the right of perpendicular, and between 0.0 and -90.0 when tilted to the left of perpendicular. The default value is 0.0.</returns>
    public extern float XTilt { [MethodImpl] get; }

    /// <summary>Gets the plane angle between the X-Z plane and the plane that contains the X axis and the axis of the input device (typically a pen/stylus).</summary>
    /// <returns>The value is 0.0 when the finger or pen is perpendicular to the digitizer surface, between 0.0 and 90.0 when tilted towards the user, and between 0.0 and -90.0 when tilted away from the user. The default value is 0.0.</returns>
    public extern float YTilt { [MethodImpl] get; }

    /// <summary>Gets the clockwise rotation in degrees of a pen device around its own major axis (such as when the user spins the pen in their fingers).</summary>
    /// <returns>A value between 0.0 and 359.0 in degrees of rotation. The default value is 0.0.</returns>
    public extern float Twist { [MethodImpl] get; }

    /// <summary>Gets the bounding rectangle of the contact area (typically from touch input).</summary>
    /// <returns>The bounding rectangle of the contact area, using client window coordinates in device-independent pixel (DIP).</returns>
    public extern Rect ContactRect { [MethodImpl] get; }

    /// <summary>Gets the bounding rectangle of the raw input (typically from touch input).</summary>
    /// <returns>The bounding rectangle of the raw input, in device-independent pixel (DIP)</returns>
    public extern Rect ContactRectRaw { [MethodImpl] get; }

    /// <summary>Gets a value that indicates whether the pointer device rejected the touch contact.</summary>
    /// <returns>True if the touch contact was accepted; otherwise false.</returns>
    public extern bool TouchConfidence { [MethodImpl] get; }

    /// <summary>Gets a value that indicates whether the pointer input was triggered by the primary action mode of an input device.</summary>
    /// <returns>True if the primary action mode; otherwise false.</returns>
    public extern bool IsLeftButtonPressed { [MethodImpl] get; }

    /// <summary>Gets a value that indicates whether the pointer input was triggered by the secondary action mode (if supported) of an input device.</summary>
    /// <returns>True if the secondary action mode; otherwise false.</returns>
    public extern bool IsRightButtonPressed { [MethodImpl] get; }

    /// <summary>Gets a value that indicates whether the pointer input was triggered by the tertiary action mode of an input device.</summary>
    /// <returns>True if the tertiary action mode; otherwise false.</returns>
    public extern bool IsMiddleButtonPressed { [MethodImpl] get; }

    /// <summary>Gets a value (the raw value reported by the device) that indicates the change in wheel button input from the last pointer event.</summary>
    /// <returns>The number of notches or distance thresholds crossed since the last pointer event. The default value is 0.</returns>
    public extern int MouseWheelDelta { [MethodImpl] get; }

    /// <summary>Gets a value that indicates whether the input is from a mouse tilt wheel.</summary>
    /// <returns>True if the input is from a mouse tilt wheel; otherwise false.</returns>
    public extern bool IsHorizontalMouseWheel { [MethodImpl] get; }

    /// <summary>Gets a value that indicates whether the input is from the primary pointer when multiple pointers are registered.</summary>
    /// <returns>True if the input is from the pointer designated as primary; otherwise false.</returns>
    public extern bool IsPrimary { [MethodImpl] get; }

    /// <summary>Gets a value that indicates whether the pointer device is within detection range of a sensor or digitizer (the pointer continues to exist).</summary>
    /// <returns>True if touch or pen is within detection range or mouse is over; otherwise false.</returns>
    public extern bool IsInRange { [MethodImpl] get; }

    /// <summary>Gets a value that indicates whether the input was canceled by the pointer device.</summary>
    /// <returns>True if the input was canceled; otherwise false.</returns>
    public extern bool IsCanceled { [MethodImpl] get; }

    /// <summary>Gets a value that indicates whether the barrel button of the pen/stylus device is pressed.</summary>
    /// <returns>True if the barrel button is pressed; otherwise false.</returns>
    public extern bool IsBarrelButtonPressed { [MethodImpl] get; }

    /// <summary>Gets a value that indicates whether the pointer input was triggered by the first extended mouse button (XButton1).</summary>
    /// <returns>True if the first extended mouse button is pressed; otherwise false.</returns>
    public extern bool IsXButton1Pressed { [MethodImpl] get; }

    /// <summary>Gets a value that indicates whether the pointer input was triggered by the second extended mouse button (XButton2).</summary>
    /// <returns>True if the second extended mouse button is pressed; otherwise false.</returns>
    public extern bool IsXButton2Pressed { [MethodImpl] get; }

    /// <summary>Gets the kind of pointer state change.</summary>
    /// <returns>One of the values from PointerUpdateKind.</returns>
    public extern PointerUpdateKind PointerUpdateKind { [MethodImpl] get; }

    /// <summary>Gets a value that indicates whether the input data from the pointer device contains the specified Human Interface Device (HID) usage information.</summary>
    /// <param name="usagePage">The Human Interface Device (HID) usage page of the pointer device. Usage pages specify the class of device. For example, touch digitizers (0x0D) and generic input (0x01).</param>
    /// <param name="usageId">Indicates a usage in a usage page.Usage ID specify a device or property in the **usagePage**. For example, for touch digitizers this includes tip switch (0x42) to indicate finger contact or tip pressure (0x30).</param>
    /// <returns>True if the input data includes usage information; otherwise false.</returns>
    [MethodImpl]
    public extern bool HasUsage(uint usagePage, uint usageId);

    /// <summary>Gets the Human Interface Device (HID) usage value of the raw input.</summary>
    /// <param name="usagePage">The Human Interface Device (HID) usage page of the pointer device. Usage pages specify the class of device. For example, touch digitizers (0x0D) and generic input (0x01).</param>
    /// <param name="usageId">Indicates a usage in a usage page.Usage ID specify a device or property in the **usagePage**. For example, for touch digitizers this includes tip switch (0x42) to indicate finger contact or tip pressure (0x30).</param>
    /// <returns>The extended usage of the raw input pointer.</returns>
    [MethodImpl]
    public extern int GetUsageValue(uint usagePage, uint usageId);

    /// <summary>Gets the z-coordinate (or distance) of the pointer from the screen surface, in device-independent pixels.</summary>
    /// <returns>The value is null when the pointer is not within detection range or when MaxPointersWithZDistance is zero. The default value is null.</returns>
    public extern IReference<float> ZDistance { [MethodImpl] get; }
  }
}
