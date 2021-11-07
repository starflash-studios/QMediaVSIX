// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Lights.Effects.LampArrayBitmapEffect
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Lights.Effects
{
  /// <summary>Renders a series of images to selected lamp indexes on the device.</summary>
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(typeof (ILampArrayBitmapEffectFactory), 458752, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  public sealed class LampArrayBitmapEffect : ILampArrayBitmapEffect, ILampArrayEffect
  {
    /// <summary>Creates and initializes a new instance of the effect.</summary>
    /// <param name="lampArray">The LampArray the effect is played on.</param>
    /// <param name="lampIndexes">Subset of lamp indexes that effect will apply to.</param>
    [MethodImpl]
    public extern LampArrayBitmapEffect(LampArray lampArray, int[] lampIndexes);

    /// <summary>Gets or sets the duration of the effect.</summary>
    /// <returns>Default value is 0.</returns>
    public extern TimeSpan Duration { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the duration to delay before starting the effect.</summary>
    /// <returns>Default value is 0.</returns>
    public extern TimeSpan StartDelay { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the interval between the triggering of the BitmapRequested event. The supplied image will be displayed until the event is next triggered.</summary>
    /// <returns>Time interval between updates. Default value is 0.</returns>
    public extern TimeSpan UpdateInterval { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the most suitable image size for the caller selected lamp indexes that results in minimal scaling/distortion.</summary>
    /// <returns>The image size.</returns>
    public extern Size SuggestedBitmapSize { [MethodImpl] get; }

    /// <summary>Event triggered by the system to indicate a new image should be supplied to the effect.</summary>
    public extern event TypedEventHandler<LampArrayBitmapEffect, LampArrayBitmapRequestedEventArgs> BitmapRequested;

    /// <summary>Gets or sets the global precedence (across all playlists) for two effects that modify the same lamp (on the same LampArray ).</summary>
    /// <returns>Default value is 0.</returns>
    public extern int ZIndex { [MethodImpl] get; [MethodImpl] set; }
  }
}
