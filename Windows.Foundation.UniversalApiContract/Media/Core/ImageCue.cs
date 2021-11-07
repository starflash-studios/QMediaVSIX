// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.ImageCue
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics.Imaging;

namespace Windows.Media.Core
{
  /// <summary>Represents a image cue that can be included in a TimedMetadataTrack.</summary>
  [Activatable(262144, "Windows.Foundation.UniversalApiContract")]
  [DualApiPartition(version = 167772160)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  public sealed class ImageCue : IImageCue, IMediaCue
  {
    /// <summary>Initializes a new instance of the **ImageCue** class.</summary>
    [MethodImpl]
    public extern ImageCue();

    /// <summary>Gets or sets the position of the image associated with the **ImageCue**, relative to the top left corner of the video frame.</summary>
    /// <returns>The position of the image associated with the **ImageCue**</returns>
    public extern TimedTextPoint Position { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the extent of the **ImageCue**, which is the rendered size of the assoociated image either in pixels or in percentage of available space.</summary>
    /// <returns>The extent of the **ImageCue**</returns>
    public extern TimedTextSize Extent { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the image associated with the image cue.</summary>
    /// <returns>The image associated with the image cue.</returns>
    public extern SoftwareBitmap SoftwareBitmap { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets the start time of the cue.</summary>
    /// <returns>The start time of the cue.</returns>
    public extern TimeSpan StartTime { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets or sets the duration of the cue.</summary>
    /// <returns>The duration of the cue.</returns>
    public extern TimeSpan Duration { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets the identifier for the timed metadata track.</summary>
    /// <returns>The identifier for the timed metadata track.</returns>
    public extern string Id { [MethodImpl] set; [MethodImpl] get; }
  }
}
