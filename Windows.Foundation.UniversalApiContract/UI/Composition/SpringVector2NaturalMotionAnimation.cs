// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.SpringVector2NaturalMotionAnimation
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition
{
  /// <summary>A spring physics-based animation that targets any Vector2-based property.</summary>
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [Threading(ThreadingModel.Both)]
  [DualApiPartition(version = 167772164)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  public sealed class SpringVector2NaturalMotionAnimation : 
    Vector2NaturalMotionAnimation,
    ISpringVector2NaturalMotionAnimation
  {
    /// <summary>Gets or sets a value that indicates how much damping is applied to the spring.</summary>
    /// <returns>A value that indicates how much damping is applied to the spring.</returns>
    public extern float DampingRatio { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the time for the Spring to complete a single oscillation.</summary>
    /// <returns>The time for the Spring to complete a single oscillation.</returns>
    public extern TimeSpan Period { [MethodImpl] get; [MethodImpl] set; }
  }
}
