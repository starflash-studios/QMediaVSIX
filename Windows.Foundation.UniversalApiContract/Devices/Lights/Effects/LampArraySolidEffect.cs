// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Lights.Effects.LampArraySolidEffect
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI;

namespace Windows.Devices.Lights.Effects
{
  /// <summary>Displays a solid/static color for a specific duration.</summary>
  [Activatable(typeof (ILampArraySolidEffectFactory), 458752, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class LampArraySolidEffect : ILampArraySolidEffect, ILampArrayEffect
  {
    /// <summary>Creates and initializes a new instance of the effect.</summary>
    /// <param name="lampArray">The LampArray the effect is played on.</param>
    /// <param name="lampIndexes">Subset of lamp indexes that effect will apply to.</param>
    [MethodImpl]
    public extern LampArraySolidEffect(LampArray lampArray, int[] lampIndexes);

    /// <summary>Gets or sets the solid color of the effect.</summary>
    /// <returns>The Color value. Default is Black</returns>
    public extern Color Color { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the duration of the effect; StartDelay is not included.</summary>
    /// <returns>Time value of the duration of an effect. Default value is 0.</returns>
    public extern TimeSpan Duration { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the duration to delay before starting the effect.</summary>
    /// <returns>Time value of the start delay. Default value is 0.</returns>
    public extern TimeSpan StartDelay { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the behavior when effect completes.</summary>
    /// <returns>Default is ClearState</returns>
    public extern LampArrayEffectCompletionBehavior CompletionBehavior { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the global precedence (across all playlists) for two effects that modify the same lamp (on the same LampArray ).</summary>
    /// <returns>Default value is 0.</returns>
    public extern int ZIndex { [MethodImpl] get; [MethodImpl] set; }
  }
}
