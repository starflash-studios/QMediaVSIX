// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Lights.Effects.LampArrayColorRampEffect
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI;

namespace Windows.Devices.Lights.Effects
{
  /// <summary>Transitions lamp/s from their existing color (whatever last set to), to the prescribed color.</summary>
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(typeof (ILampArrayColorRampEffectFactory), 458752, "Windows.Foundation.UniversalApiContract")]
  public sealed class LampArrayColorRampEffect : ILampArrayColorRampEffect, ILampArrayEffect
  {
    /// <summary>Creates and initializes a new instance of the effect.</summary>
    /// <param name="lampArray">The LampArray the effect is played on.</param>
    /// <param name="lampIndexes">Subset of lamp indexes that effect will apply to.</param>
    [MethodImpl]
    public extern LampArrayColorRampEffect(LampArray lampArray, int[] lampIndexes);

    /// <summary>Gets or sets the color of peak intensity for the effect.</summary>
    /// <returns>Color value of the peak intensity for the effect.</returns>
    public extern Color Color { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the time spent ramping-up to peak intensity from the previously set color.</summary>
    /// <returns>Time value of time spent ramping-up to peak intensity.</returns>
    public extern TimeSpan RampDuration { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the duration to delay before starting the effect.</summary>
    /// <returns>Time value of duration before an effect starts.</returns>
    public extern TimeSpan StartDelay { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the behavior when effect completes.</summary>
    /// <returns>Default is ClearState</returns>
    public extern LampArrayEffectCompletionBehavior CompletionBehavior { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>The global precedence for two effects that modify the same lamp.</summary>
    /// <returns>Default value is 0.</returns>
    public extern int ZIndex { [MethodImpl] get; [MethodImpl] set; }
  }
}
