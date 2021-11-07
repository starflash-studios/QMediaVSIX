// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Lights.Effects.LampArrayBlinkEffect
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI;

namespace Windows.Devices.Lights.Effects
{
  /// <summary>Blinks lamp/s a color for a specific duration.  Timing of attack/sustain/decay phases can be defined.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [Threading(ThreadingModel.Both)]
  [Activatable(typeof (ILampArrayBlinkEffectFactory), 458752, "Windows.Foundation.UniversalApiContract")]
  public sealed class LampArrayBlinkEffect : ILampArrayBlinkEffect, ILampArrayEffect
  {
    /// <summary>Creates and initializes a new instance of the effect.</summary>
    /// <param name="lampArray">The LampArray the effect is played on.</param>
    /// <param name="lampIndexes">Subset of lamp indexes that effect will apply to.</param>
    [MethodImpl]
    public extern LampArrayBlinkEffect(LampArray lampArray, int[] lampIndexes);

    /// <summary>Gets or sets the color of peak intensity for the effect. Duration color is visible defined by SustainDuration.</summary>
    /// <returns>Default is Black</returns>
    public extern Color Color { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the time spent attacking/ramping-up from off/Black to peak intensity.</summary>
    /// <returns>Default value is 0.</returns>
    public extern TimeSpan AttackDuration { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the time spent displaying peak intensity for the effect.</summary>
    /// <returns>Time value of time spent displaying peak intensity of an effect. Default value is 0.</returns>
    public extern TimeSpan SustainDuration { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the time spent decaying/ramping-down from peak intensity to off/Black.</summary>
    /// <returns>Default value is 0.</returns>
    public extern TimeSpan DecayDuration { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the delay between effect repetitions.</summary>
    /// <returns>Default value is 0.</returns>
    public extern TimeSpan RepetitionDelay { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the duration to delay before starting the effect.</summary>
    /// <returns>The time value to delay the start of an effect. Default value is 0.</returns>
    public extern TimeSpan StartDelay { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Number of occurrences this effect will play.</summary>
    /// <returns>Default value is 0.</returns>
    public extern int Occurrences { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the repetition behavior of the effect.</summary>
    /// <returns>Default is Occurrences</returns>
    public extern LampArrayRepetitionMode RepetitionMode { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the global precedence (across all playlists) for two effects that modify the same lamp (on the same LampArray ).</summary>
    /// <returns>Global precedence value. Default value is 0.</returns>
    public extern int ZIndex { [MethodImpl] get; [MethodImpl] set; }
  }
}
