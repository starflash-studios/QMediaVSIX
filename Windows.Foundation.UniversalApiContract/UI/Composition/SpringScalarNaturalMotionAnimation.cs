﻿// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.SpringScalarNaturalMotionAnimation
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition
{
  /// <summary>A spring physics-based animation that targets any Scalar-based property.</summary>
  [DualApiPartition(version = 167772164)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  public sealed class SpringScalarNaturalMotionAnimation : 
    ScalarNaturalMotionAnimation,
    ISpringScalarNaturalMotionAnimation
  {
    /// <summary>Gets or sets a value that indicates how much damping is applied to the spring.</summary>
    /// <returns>A value that indicates how much damping is applied to the spring.</returns>
    public extern float DampingRatio { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the time for the Spring to complete a single oscillation.</summary>
    /// <returns>The time for the Spring to complete a single oscillation.</returns>
    public extern TimeSpan Period { [MethodImpl] get; [MethodImpl] set; }
  }
}