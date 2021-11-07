// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.CompositionClip
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Windows.UI.Composition
{
  /// <summary>Base class for clipping objects such as InsetClip.</summary>
  [Composable(typeof (ICompositionClipFactory), CompositionType.Public, 131072, "Windows.Foundation.UniversalApiContract")]
  [DualApiPartition(version = 167772164)]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [Threading(ThreadingModel.Both)]
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  public class CompositionClip : CompositionObject, ICompositionClip, ICompositionClip2
  {
    /// <summary>The point on the clip to be positioned at the clip's offset. Value is normalized with respect to the size of the clip.</summary>
    /// <returns>The point on the clip to be positioned at the clip's offset. Value is normalized with respect to the size of the clip. An AnchorPoint value of (0, 0) refers to the top-left corner of the untransformed clip and a value of (1, 1) refers to the bottom-right corner. Negative values and values greater than one are accepted but will result in an AnchorPoint that is outside the boundaries of the original, untransformed clip.</returns>
    public extern Vector2 AnchorPoint { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>The point about which rotation or scaling occurs.</summary>
    /// <returns>The point about which rotation or scaling occurs. Value is in pixels within the local coordinate space of the visual on which the clip is applied.</returns>
    public extern Vector2 CenterPoint { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>The offset of the clip relative to the visual on which the clip is applied.</summary>
    /// <returns>The offset of the clip relative to the visual on which the clip is applied. By default, the Offset value on a clip is (0, 0).</returns>
    public extern Vector2 Offset { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>The angle of rotation applied to the clip, in radians.</summary>
    /// <returns>The angle of rotation applied to the clip, in radians. For a CompositionClip, the axis of rotation is always about the z-axis, with positive RotationAngle values resulting in a clockwise rotation and negative values resulting in a counter-clockwise rotation. For specifying RotationAngle in degrees, use CompositionClip.RotationAngleInDegrees.</returns>
    public extern float RotationAngle { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>The angle of rotation applied to the clip, in degrees.</summary>
    /// <returns>The angle of rotation applied to the clip, in degrees. For a CompositionClip, the axis of rotation is always about the z-axis, with positive RotationAngleInDegrees values resulting in a clockwise rotation and negative values resulting in a counter-clockwise rotation. For specifying RotationAngle in radians, use CompositionClip.RotationAngle.</returns>
    public extern float RotationAngleInDegrees { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>The scale to apply to the clip.</summary>
    /// <returns>The scale to apply to the clip. The scale value is a multiplier of the clip's size. By default, the Scale value on a clip is (1, 1).</returns>
    public extern Vector2 Scale { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>The 3x2 transformation matrix to apply to the clip.</summary>
    /// <returns>The transformation matrix to apply to the clip. By default, the TransformMatrix is set to:</returns>
    public extern Matrix3x2 TransformMatrix { [MethodImpl] get; [MethodImpl] set; }
  }
}
