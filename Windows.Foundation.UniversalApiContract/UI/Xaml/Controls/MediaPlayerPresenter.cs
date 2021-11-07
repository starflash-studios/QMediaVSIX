// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.MediaPlayerPresenter
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
  /// <summary>Represents an object that displays a MediaPlayer.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [WebHostHidden]
  [Static(typeof (IMediaPlayerPresenterStatics), 196608, "Windows.Foundation.UniversalApiContract")]
  [Composable(typeof (IMediaPlayerPresenterFactory), CompositionType.Public, 196608, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  public class MediaPlayerPresenter : FrameworkElement, IMediaPlayerPresenter
  {
    /// <summary>Initializes a new instance of the MediaPlayerPresenter class.</summary>
    [MethodImpl]
    public extern MediaPlayerPresenter();

    /// <summary>Gets or sets the MediaPlayer instance used to render media.</summary>
    /// <returns>The MediaPlayer instance used to render media.</returns>
    public extern MediaPlayer MediaPlayer { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that describes how an MediaPlayerPresenter should be stretched to fill the destination rectangle.</summary>
    /// <returns>A value of the Stretch enumeration that specifies how the source visual media is rendered. The default value is **Uniform**.</returns>
    public extern Stretch Stretch { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that specifies if the MediaPlayerPresenter is rendering in full window mode.</summary>
    /// <returns>**true** if the MediaPlayerPresenter is in full window mode; otherwise, **false**. The default is **false**.</returns>
    public extern bool IsFullWindow { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Identifies the MediaPlayer dependency property.</summary>
    /// <returns>The identifier for the MediaPlayer dependency property.</returns>
    public static extern DependencyProperty MediaPlayerProperty { [MethodImpl] get; }

    /// <summary>Identifies the Stretch dependency property.</summary>
    /// <returns>The identifier for the Stretch dependency property.</returns>
    public static extern DependencyProperty StretchProperty { [MethodImpl] get; }

    /// <summary>Identifies the IsFullWindow dependency property.</summary>
    /// <returns>The identifier for the IsFullWindow dependency property.</returns>
    public static extern DependencyProperty IsFullWindowProperty { [MethodImpl] get; }
  }
}
