// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Inking.InkStrokeRenderingSegment
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input.Inking
{
  /// <summary>A single segment of a complete ink stroke.</summary>
  [DualApiPartition(version = 100794368)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class InkStrokeRenderingSegment : IInkStrokeRenderingSegment
  {
    /// <summary>Gets the end point of the segment.</summary>
    /// <returns>The end point.</returns>
    public extern Point Position { [MethodImpl] get; }

    /// <summary>Gets the first control point for the Bézier curve.</summary>
    /// <returns>The control point.</returns>
    public extern Point BezierControlPoint1 { [MethodImpl] get; }

    /// <summary>Gets the second control point for the Bézier curve.</summary>
    /// <returns>The control point.</returns>
    public extern Point BezierControlPoint2 { [MethodImpl] get; }

    /// <summary>Gets the pressure of the contact on the digitizer surface.</summary>
    /// <returns>The pressure of the contact.</returns>
    public extern float Pressure { [MethodImpl] get; }

    /// <summary>Gets the tilt of the contact along the x axis.</summary>
    /// <returns>The tilt along the x axis.</returns>
    public extern float TiltX { [MethodImpl] get; }

    /// <summary>Gets the tilt of the contact along the y axis.</summary>
    /// <returns>The tilt along the y axis.</returns>
    public extern float TiltY { [MethodImpl] get; }

    /// <summary>Gets the twist of the contact along the rotational axis.</summary>
    /// <returns>The twist of the contact along the rotational axis.</returns>
    public extern float Twist { [MethodImpl] get; }
  }
}
