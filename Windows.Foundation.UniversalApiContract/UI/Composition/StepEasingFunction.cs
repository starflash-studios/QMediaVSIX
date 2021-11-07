// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.StepEasingFunction
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition
{
  /// <summary>A step function for interpolating between animation key frames.</summary>
  [DualApiPartition(version = 167772164)]
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  public sealed class StepEasingFunction : CompositionEasingFunction, IStepEasingFunction
  {
    /// <summary>The step to end at.</summary>
    /// <returns>The step to end at.</returns>
    public extern int FinalStep { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>The step to start at.</summary>
    /// <returns>The step to start at.</returns>
    public extern int InitialStep { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Indicates whether the final step should last the smallest possible duration.</summary>
    /// <returns>Boolean indicating whether the final step should last the smallest possible duration (1 frame).</returns>
    public extern bool IsFinalStepSingleFrame { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Indicates whether the initial step should last the smallest possible duration.</summary>
    /// <returns>Boolean indicating whether the initial step should last the smallest possible duration (1 frame).</returns>
    public extern bool IsInitialStepSingleFrame { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>The number of steps between the starting value and the end value.</summary>
    /// <returns>The number of steps between the starting value and the end value.</returns>
    public extern int StepCount { [MethodImpl] get; [MethodImpl] set; }
  }
}
