// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.CubicBezierEasingFunction
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Windows.UI.Composition
{
  /// <summary>Represents a cubic-bezier function for interpolating between animation key frames.</summary>
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [WebHostHidden]
  [Threading(ThreadingModel.Both)]
  [DualApiPartition(version = 167772164)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class CubicBezierEasingFunction : 
    CompositionEasingFunction,
    ICubicBezierEasingFunction
  {
    /// <summary>The first control point for the cubic-bezier interpolation function.</summary>
    /// <returns>The first control point for the cubic-bezier interpolation function.</returns>
    public extern Vector2 ControlPoint1 { [MethodImpl] get; }

    /// <summary>The second control point for the cubic-bezier interpolation function.</summary>
    /// <returns>The second control point for the cubic-bezier interpolation function.</returns>
    public extern Vector2 ControlPoint2 { [MethodImpl] get; }
  }
}
