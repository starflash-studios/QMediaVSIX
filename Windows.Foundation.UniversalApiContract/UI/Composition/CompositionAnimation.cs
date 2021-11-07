// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.CompositionAnimation
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Windows.UI.Composition
{
  /// <summary>Represents the base animation class.</summary>
  [Composable(typeof (ICompositionAnimationFactory), CompositionType.Public, 131072, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [DualApiPartition(version = 167772164)]
  [Threading(ThreadingModel.Both)]
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  public class CompositionAnimation : 
    CompositionObject,
    ICompositionAnimation,
    ICompositionAnimation2,
    ICompositionAnimation3,
    ICompositionAnimation4,
    ICompositionAnimationBase
  {
    /// <summary>Clears all of the parameters of the animation.</summary>
    [MethodImpl]
    public extern void ClearAllParameters();

    /// <summary>Clears a parameter from the animation.</summary>
    /// <param name="key">The parameter to clear.</param>
    [MethodImpl]
    public extern void ClearParameter(string key);

    /// <summary>Sets a Color value parameter for use with an ExpressionAnimation or an expression keyframe.</summary>
    /// <param name="key">The name of the parameter to set.</param>
    /// <param name="value">The Color value.</param>
    [MethodImpl]
    public extern void SetColorParameter(string key, Color value);

    [MethodImpl]
    public extern void SetMatrix3x2Parameter(string key, Matrix3x2 value);

    [MethodImpl]
    public extern void SetMatrix4x4Parameter(string key, Matrix4x4 value);

    [MethodImpl]
    public extern void SetQuaternionParameter(string key, Quaternion value);

    /// <summary>Sets a reference to a Composition object for use with an ExpressionAnimation or an expression keyframe.</summary>
    /// <param name="key">The name of the parameter to set. The name can be used to reference the parameter in the ExpressionAnimation.</param>
    /// <param name="compositionObject">The CompositionObject value.</param>
    [MethodImpl]
    public extern void SetReferenceParameter(string key, CompositionObject compositionObject);

    /// <summary>Sets a Scalar value parameter for use with an ExpressionAnimation or an expression keyframe.</summary>
    /// <param name="key">The name of the parameter to set.</param>
    /// <param name="value">The Single value.</param>
    [MethodImpl]
    public extern void SetScalarParameter(string key, float value);

    [MethodImpl]
    public extern void SetVector2Parameter(string key, Vector2 value);

    [MethodImpl]
    public extern void SetVector3Parameter(string key, Vector3 value);

    [MethodImpl]
    public extern void SetVector4Parameter(string key, Vector4 value);

    /// <summary>Sets a boolean value parameter for use with an ExpressionAnimation or an expression keyframe.</summary>
    /// <param name="key">The name of the parameter to set.</param>
    /// <param name="value">The boolean value.</param>
    [MethodImpl]
    public extern void SetBooleanParameter(string key, bool value);

    /// <summary>The target of the animation.</summary>
    /// <returns>The target of the animation.</returns>
    public extern string Target { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the initial values for the animation.</summary>
    /// <returns>The initial values for the animation.</returns>
    public extern InitialValueExpressionCollection InitialValueExpressions { [MethodImpl] get; }

    /// <summary>Sets an IAnimationObject value parameter for use with an ExpressionAnimation or an expression keyframe.</summary>
    /// <param name="parameterName">The name of the parameter to set.</param>
    /// <param name="source">The source object.</param>
    [MethodImpl]
    public extern void SetExpressionReferenceParameter(
      string parameterName,
      IAnimationObject source);
  }
}
