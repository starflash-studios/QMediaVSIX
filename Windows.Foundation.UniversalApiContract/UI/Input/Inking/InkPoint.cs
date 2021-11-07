// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Inking.InkPoint
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input.Inking
{
  /// <summary>Provides raw input data for a single point used in the construction of an InkStroke.</summary>
  [Activatable(typeof (IInkPointFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [Activatable(typeof (IInkPointFactory2), 262144, "Windows.Foundation.UniversalApiContract")]
  [DualApiPartition(version = 167772160)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class InkPoint : IInkPoint, IInkPoint2
  {
    /// <summary>Creates a complex InkPoint object used in the construction of an InkStroke.</summary>
    /// <param name="position">The screen coordinates for the InkPoint object.</param>
    /// <param name="pressure">The pressure of the contact on the digitizer surface. The default is 0.5.</param>
    /// <param name="tiltX">The plane angle between the Y-Z plane and the plane containing the Y axis and the axis of the input device. The default is 0.</param>
    /// <param name="tiltY">The plane angle between the X-Z plane and the plane containing the X axis and the axis of the input device. The default is 0.</param>
    /// <param name="timestamp">The timestamp for the first InkPoint of an InkStroke, or when an entire InkStroke is pasted or loaded.</param>
    [MethodImpl]
    public extern InkPoint(
      Point position,
      float pressure,
      float tiltX,
      float tiltY,
      ulong timestamp);

    /// <summary>Creates a basic InkPoint object used in the construction of an InkStroke.</summary>
    /// <param name="position">The screen coordinates for the InkPoint object.</param>
    /// <param name="pressure">The pressure of the contact on the digitizer surface. The default is 0.5.</param>
    [MethodImpl]
    public extern InkPoint(Point position, float pressure);

    /// <summary>The X, Y coordinates of the InkPoint, in device-independent pixel (DIP) relative to the upper left-hand corner of the inking area.</summary>
    /// <returns>The X, Y coordinates relative to the upper left-hand corner of the inking area.</returns>
    public extern Point Position { [MethodImpl] get; }

    /// <summary>The pressure of the contact on the digitizer surface for the InkPoint.</summary>
    /// <returns>The pressure of the contact.</returns>
    public extern float Pressure { [MethodImpl] get; }

    /// <summary>Gets the plane angle between the Y-Z plane and the plane containing the Y axis and the axis of the input device.</summary>
    /// <returns>A value in the range of -90 to +90 degrees. A positive X tilt is to the right.</returns>
    public extern float TiltX { [MethodImpl] get; }

    /// <summary>Gets the plane angle between the X-Z plane and the plane containing the X axis and the axis of the input device.</summary>
    /// <returns>A value in the range of -90 to +90 degrees. A positive Y tilt is toward the user.</returns>
    public extern float TiltY { [MethodImpl] get; }

    /// <summary>Gets the timestamp for the first InkPoint of an InkStroke, or when an entire InkStroke is pasted or loaded.</summary>
    /// <returns>The time, relative to the system boot time, in microseconds.</returns>
    public extern ulong Timestamp { [MethodImpl] get; }
  }
}
