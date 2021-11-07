// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.CompositionShape
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Windows.UI.Composition
{
  /// <summary>Represents the base shape class.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [WebHostHidden]
  [Composable(typeof (ICompositionShapeFactory), CompositionType.Public, 393216, "Windows.Foundation.UniversalApiContract")]
  [DualApiPartition(version = 167772165)]
  [Threading(ThreadingModel.Both)]
  public class CompositionShape : CompositionObject, ICompositionShape
  {
    /// <summary>The point about which the shape is rotated and scaled.</summary>
    /// <returns>The point about which the shape is rotated and scaled.</returns>
    public extern Vector2 CenterPoint { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the offset of the shape relative to its ShapeVisual.</summary>
    /// <returns>The offset of the shape relative to its ShapeVisual.</returns>
    public extern Vector2 Offset { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the rotation angle of the shape in radians.</summary>
    /// <returns>The rotation angle of the shape in radians.</returns>
    public extern float RotationAngle { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the rotation angle of the shape in degrees.</summary>
    /// <returns>The rotation angle of the shape in degrees.</returns>
    public extern float RotationAngleInDegrees { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the scale to apply to the shape.</summary>
    /// <returns>The scale to apply to the shape.</returns>
    public extern Vector2 Scale { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the transform matrix to apply to the shape.</summary>
    /// <returns>The transform matrix to apply to the shape.</returns>
    public extern Matrix3x2 TransformMatrix { [MethodImpl] get; [MethodImpl] set; }
  }
}
