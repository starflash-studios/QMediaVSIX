// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.MediaPlayerElement
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Media.Playback;
using Windows.UI.Xaml.Media;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Represents an object that uses a MediaPlayer to render audio and video to the display.</summary>
  [Composable(typeof (IMediaPlayerElementFactory), CompositionType.Public, 196608, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  [Threading(ThreadingModel.Both)]
  [Static(typeof (IMediaPlayerElementStatics), 196608, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  public class MediaPlayerElement : Control, IMediaPlayerElement
  {
    /// <summary>Initializes a new instance of the MediaPlayerElement class.</summary>
    [MethodImpl]
    public extern MediaPlayerElement();

    /// <summary>Gets or sets a media source on the MediaPlayerElement.</summary>
    /// <returns>The source of the media. The default is **null**.</returns>
    public extern IMediaPlaybackSource Source { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the transport controls for the media.</summary>
    /// <returns>The transport controls for the media.</returns>
    public extern MediaTransportControls TransportControls { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that determines whether the standard transport controls are enabled.</summary>
    /// <returns>**true** if the standard transport controls are enabled; otherwise, **false**. The default is **false**.</returns>
    public extern bool AreTransportControlsEnabled { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the image source that is used for a placeholder image during MediaPlayerElement loading transition states.</summary>
    /// <returns>An image source for a transition ImageBrush that is applied to the MediaPlayerElement content area.</returns>
    public extern ImageSource PosterSource { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that describes how an MediaPlayerElement should be stretched to fill the destination rectangle.</summary>
    /// <returns>A value of the Stretch enumeration that specifies how the source visual media is rendered. The default value is **Uniform**.</returns>
    public extern Stretch Stretch { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates whether media will begin playback automatically when the Source property is set.</summary>
    /// <returns>**true** if playback is automatic; otherwise, **false**. The default is **true**.</returns>
    public extern bool AutoPlay { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that specifies if the MediaPlayerElement is rendering in full window mode.</summary>
    /// <returns>**true** if the MediaPlayerElement is in full window mode; otherwise, **false**. The default is **false**.</returns>
    public extern bool IsFullWindow { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the MediaPlayer instance used to render media.</summary>
    /// <returns>The MediaPlayer instance used to render media.</returns>
    public extern MediaPlayer MediaPlayer { [MethodImpl] get; }

    /// <summary>Sets the MediaPlayer instance used to render media.</summary>
    /// <param name="mediaPlayer">The new MediaPlayer instance used to render media.</param>
    [MethodImpl]
    public extern void SetMediaPlayer(MediaPlayer mediaPlayer);

    /// <summary>Identifies the Source dependency property.</summary>
    /// <returns>The identifier for the Source dependency property.</returns>
    public static extern DependencyProperty SourceProperty { [MethodImpl] get; }

    /// <summary>Identifies the AreTransportControlsEnabled dependency property.</summary>
    /// <returns>The identifier for the AreTransportControlsEnabled dependency property.</returns>
    public static extern DependencyProperty AreTransportControlsEnabledProperty { [MethodImpl] get; }

    /// <summary>Identifies the PosterSource dependency property.</summary>
    /// <returns>The identifier for the PosterSource dependency property.</returns>
    public static extern DependencyProperty PosterSourceProperty { [MethodImpl] get; }

    /// <summary>Identifies the Stretch dependency property.</summary>
    /// <returns>The identifier for the Stretch dependency property.</returns>
    public static extern DependencyProperty StretchProperty { [MethodImpl] get; }

    /// <summary>Identifies the AutoPlay dependency property.</summary>
    /// <returns>The identifier for the AutoPlay dependency property.</returns>
    public static extern DependencyProperty AutoPlayProperty { [MethodImpl] get; }

    /// <summary>Identifies the IsFullWindow dependency property.</summary>
    /// <returns>The identifier for the IsFullWindow dependency property.</returns>
    public static extern DependencyProperty IsFullWindowProperty { [MethodImpl] get; }

    /// <summary>Identifies the MediaPlayer dependency property.</summary>
    /// <returns>The identifier for the MediaPlayer dependency property.</returns>
    public static extern DependencyProperty MediaPlayerProperty { [MethodImpl] get; }
  }
}
