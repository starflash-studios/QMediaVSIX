// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Lights.Effects.LampArrayCustomEffect
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Lights.Effects
{
  /// <summary>This effect provides an entry-point for developer-defined custom effects into the effect framework; allowing it to be included and scheduled within playlists.</summary>
  [Threading(ThreadingModel.Both)]
  [Activatable(typeof (ILampArrayCustomEffectFactory), 458752, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class LampArrayCustomEffect : ILampArrayCustomEffect, ILampArrayEffect
  {
    /// <summary>Creates and initializes a new instance of the effect.</summary>
    /// <param name="lampArray">The LampArray the effect is played on.</param>
    /// <param name="lampIndexes">Subset of lamp indexes that effect will apply to.</param>
    [MethodImpl]
    public extern LampArrayCustomEffect(LampArray lampArray, int[] lampIndexes);

    /// <summary>Gets or sets the duration of the effect.</summary>
    /// <returns>Time value of the duration. Default value is 0.</returns>
    public extern TimeSpan Duration { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the interval between the triggering of the UpdateRequested event.  The supplied image will be displayed until the event is next triggered.</summary>
    /// <returns>Time span value of the update interval. Default value is 0.</returns>
    public extern TimeSpan UpdateInterval { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Event triggered by the system to indicate that lamp state should be modified.</summary>
    public extern event TypedEventHandler<LampArrayCustomEffect, LampArrayUpdateRequestedEventArgs> UpdateRequested;

    /// <summary>The global precedence for two effects that modify the same lamp.</summary>
    /// <returns>Value of the global precedence. Default value is 0.</returns>
    public extern int ZIndex { [MethodImpl] get; [MethodImpl] set; }
  }
}
