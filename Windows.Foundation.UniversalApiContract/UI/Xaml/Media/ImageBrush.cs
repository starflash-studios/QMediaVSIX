// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.ImageBrush
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media
{
  /// <summary>Paints an area with an image. The image source is typically obtained from file formats such as Joint Photographic Experts Group (JPEG).</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IImageBrushStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [Threading(ThreadingModel.Both)]
  public sealed class ImageBrush : TileBrush, IImageBrush
  {
    /// <summary>Initializes a new instance of the ImageBrush class.</summary>
    [MethodImpl]
    public extern ImageBrush();

    /// <summary>Gets or sets the image source displayed by this ImageBrush. In code you set this with an ImageSource subclass instance, in XAML you set this with a URI to an image source file.</summary>
    /// <returns>An object representing the image source, to be displayed by this ImageBrush when it's applied to content.</returns>
    public extern ImageSource ImageSource { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Occurs when there is an error associated with image retrieval or format.</summary>
    public extern event ExceptionRoutedEventHandler ImageFailed;

    /// <summary>Occurs when the image source is downloaded and decoded with no failure. You can use this event to determine the size of an image before rendering it.</summary>
    public extern event RoutedEventHandler ImageOpened;

    /// <summary>Identifies the ImageSource dependency property.</summary>
    /// <returns>The identifier for the ImageSource dependency property.</returns>
    public static extern DependencyProperty ImageSourceProperty { [MethodImpl] get; }
  }
}
