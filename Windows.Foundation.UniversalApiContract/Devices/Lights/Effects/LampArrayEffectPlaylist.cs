// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Lights.Effects.LampArrayEffectPlaylist
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Lights.Effects
{
  /// <summary>Used to either chain multiple effects together, or to start effects simultaneously.</summary>
  [Activatable(458752, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (ILampArrayEffectPlaylistStatics), 458752, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  public sealed class LampArrayEffectPlaylist : 
    ILampArrayEffectPlaylist,
    IVectorView<ILampArrayEffect>,
    IIterable<ILampArrayEffect>
  {
    /// <summary>Creates and initializes a new instance of a playlist.</summary>
    [MethodImpl]
    public extern LampArrayEffectPlaylist();

    /// <summary>Appends the effect to the end of the playlist.</summary>
    /// <param name="effect">Effect to append to the playlist.</param>
    [MethodImpl]
    public extern void Append(ILampArrayEffect effect);

    /// <summary>Overrides the zIndex for all contained effects.</summary>
    /// <param name="zIndex">The overriding zIndex.</param>
    [MethodImpl]
    public extern void OverrideZIndex(int zIndex);

    /// <summary>Starts this playlist from the beginning, unless it was previously paused, which will then resuming playing from the paused position.</summary>
    [MethodImpl]
    public extern void Start();

    /// <summary>Stops playing this playlist.</summary>
    [MethodImpl]
    public extern void Stop();

    /// <summary>Pauses the playlist, and persists the last state set by the internally playing effect.</summary>
    [MethodImpl]
    public extern void Pause();

    /// <summary>Gets or sets the starting behavior for the effects.</summary>
    /// <returns>A lamp array effect start mode specifying the starting behavior for the effects. The default is Sequential.</returns>
    public extern LampArrayEffectStartMode EffectStartMode { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the number of occurrences that this playlist will play.</summary>
    /// <returns>Number of occurrences. Default is 0.</returns>
    public extern int Occurrences { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the repetition behavior for playlist.</summary>
    /// <returns>A LampArrayRepetitionMode value. Default is **Occurrences**.</returns>
    public extern LampArrayRepetitionMode RepetitionMode { [MethodImpl] get; [MethodImpl] set; }

    [MethodImpl]
    public extern ILampArrayEffect GetAt(uint index);

    public extern uint Size { [MethodImpl] get; }

    [MethodImpl]
    public extern bool IndexOf(ILampArrayEffect value, out uint index);

    [MethodImpl]
    public extern uint GetMany(uint startIndex, [Out] ILampArrayEffect[] items);

    [MethodImpl]
    public extern IIterator<ILampArrayEffect> First();

    [MethodImpl]
    public static extern void StartAll(IIterable<LampArrayEffectPlaylist> value);

    [MethodImpl]
    public static extern void StopAll(IIterable<LampArrayEffectPlaylist> value);

    [MethodImpl]
    public static extern void PauseAll(IIterable<LampArrayEffectPlaylist> value);
  }
}
