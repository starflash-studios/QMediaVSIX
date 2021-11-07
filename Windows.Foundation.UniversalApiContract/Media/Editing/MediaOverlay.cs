// Decompiled with JetBrains decompiler
// Type: Windows.Media.Editing.MediaOverlay
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Editing
{
  /// <summary>Represents an overlay that can be used in a media composition.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 167772160)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [GCPressure(amount = GCPressureAmount.High)]
  [Threading(ThreadingModel.Both)]
  [Activatable(typeof (IMediaOverlayFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class MediaOverlay : IMediaOverlay
  {
    /// <summary>Initializes a new instance of the MediaOverlay class.</summary>
    /// <param name="clip">The media clip to be used for the overlay.</param>
    [MethodImpl]
    public extern MediaOverlay(MediaClip clip);

    /// <summary>Initializes a new instance of the MediaOverlay class.</summary>
    /// <param name="clip">The media clip to be used for the overlay.</param>
    /// <param name="position">The position of the overlay.</param>
    /// <param name="opacity">The opacity of the overlay, in the range of 0.0 to 1.0, where 0.0 is completely transparent and 1.0 is completely opaque.</param>
    [MethodImpl]
    public extern MediaOverlay(MediaClip clip, Rect position, double opacity);

    /// <summary>Gets the position of the overlay.</summary>
    /// <returns>The position of the overlay.</returns>
    public extern Rect Position { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the time span from the start of the clip after which the media overlay should be rendered.</summary>
    /// <returns>The time span from the start of the clip after which the media overlay should be rendered.</returns>
    public extern TimeSpan Delay { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets the opacity of the overlay.</summary>
    /// <returns>The opacity of the overlay, in the range of 0.0 to 1.0, where 0.0 is completely transparent and 1.0 is completely opaque.</returns>
    public extern double Opacity { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Creates a MediaOverlay object that is identical to this instance.</summary>
    /// <returns>A MediaOverlay object that is a copy of this instance.</returns>
    [MethodImpl]
    public extern MediaOverlay Clone();

    /// <summary>Gets the media clip to be used for the overlay.</summary>
    /// <returns>The media clip to be used for the overlay.</returns>
    public extern MediaClip Clip { [MethodImpl] get; }

    /// <summary>Gets or sets a value indicating whether audio is enabled for the MediaOverlay.</summary>
    /// <returns>True if audio is enabled; otherwise, false.</returns>
    public extern bool AudioEnabled { [MethodImpl] get; [MethodImpl] set; }
  }
}
