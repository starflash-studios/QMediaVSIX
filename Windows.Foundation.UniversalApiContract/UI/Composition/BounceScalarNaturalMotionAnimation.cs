// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.BounceScalarNaturalMotionAnimation
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition
{
  /// <summary>A bounce physics-based animation that targets any Scalar-based property.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [DualApiPartition(version = 167772165)]
  public sealed class BounceScalarNaturalMotionAnimation : 
    ScalarNaturalMotionAnimation,
    IBounceScalarNaturalMotionAnimation
  {
    /// <summary>Gets or sets the rate at which the velocity increases.</summary>
    /// <returns>The rate at which the velocity increases.</returns>
    public extern float Acceleration { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the amount that an object rebounds after collision.</summary>
    /// <returns>The amount that an object rebounds after collision.</returns>
    public extern float Restitution { [MethodImpl] get; [MethodImpl] set; }
  }
}
