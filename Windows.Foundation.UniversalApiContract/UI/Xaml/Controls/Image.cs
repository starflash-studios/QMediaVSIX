// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Image
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Media.Casting;
using Windows.Media.PlayTo;
using Windows.UI.Composition;
using Windows.UI.Xaml.Media;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Represents a control that displays an image. The image source is specified by referring to an image file, using several supported formats. The image source can also be set with a stream. See Remarks for the list of supported image source formats.</summary>
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IImageStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  public sealed class Image : FrameworkElement, IImage, IImage2, IImage3
  {
    /// <summary>Initializes a new instance of the Image class.</summary>
    [MethodImpl]
    public extern Image();

    /// <summary>Gets or sets the source for the image.</summary>
    /// <returns>An object that represents the image source file for the drawn image. Typically you set this with a BitmapImage object, constructed with the Uniform Resource Identifier (URI) that describes the path to a valid image source file. Or, you can initialize a BitmapSource with a stream, perhaps a stream from a storage file.</returns>
    public extern ImageSource Source { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that describes how an Image should be stretched to fill the destination rectangle.</summary>
    /// <returns>A value of the Stretch enumeration that specifies how the source image is rendered, if the Height and/or Width of the Image are not explicitly specified. The default value is **Uniform**.</returns>
    public extern Stretch Stretch { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value for a nine-grid metaphor that controls how the image can be resized. The nine-grid metaphor enables you to stretch edges and corners of an image differently than its center. See Remarks for more info and an illustration.</summary>
    /// <returns>A Thickness value that sets the **Left**, **Top**, **Right**, **Bottom** measurements for the nine-grid resizing metaphor.</returns>
    public extern Thickness NineGrid { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the information that is transmitted if the Image is used for a Play To scenario.</summary>
    /// <returns>A reference object that carries the Play To source information.</returns>
    public extern PlayToSource PlayToSource { [Deprecated("PlayToSource may be altered or unavailable for releases after Windows 10.0. Instead, use GetAsCastingSource.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>Occurs when there is an error associated with image retrieval or format.</summary>
    public extern event ExceptionRoutedEventHandler ImageFailed;

    /// <summary>Occurs when the image source is downloaded and decoded with no failure. You can use this event to determine the natural size of the image source.</summary>
    public extern event RoutedEventHandler ImageOpened;

    /// <summary>Returns the image as a CastingSource.</summary>
    /// <returns>The image as a CastingSource.</returns>
    [MethodImpl]
    public extern CastingSource GetAsCastingSource();

    /// <summary>Returns a mask that represents the alpha channel of an image as a CompositionBrush.</summary>
    /// <returns>A mask that represents the alpha channel of an image.</returns>
    [MethodImpl]
    public extern CompositionBrush GetAlphaMask();

    /// <summary>Identifies the Source  dependency property.</summary>
    /// <returns>The identifier for the Source  dependency property.</returns>
    public static extern DependencyProperty SourceProperty { [MethodImpl] get; }

    /// <summary>Identifies the Stretch  dependency property.</summary>
    /// <returns>The identifier for the Stretch  dependency property.</returns>
    public static extern DependencyProperty StretchProperty { [MethodImpl] get; }

    /// <summary>Identifies the NineGrid dependency property.</summary>
    /// <returns>The identifier for the NineGrid dependency property.</returns>
    public static extern DependencyProperty NineGridProperty { [MethodImpl] get; }

    /// <summary>Identifies the PlayToSource dependency property.</summary>
    /// <returns>The identifier for the PlayToSource dependency property.</returns>
    public static extern DependencyProperty PlayToSourceProperty { [Deprecated("PlayToSource may be altered or unavailable for releases after Windows 10.0. Instead, use GetAsCastingSource.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }
  }
}
