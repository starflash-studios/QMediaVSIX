// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.RatingItemImageInfo
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Media;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Represents information about the visual states of image elements that represent a rating.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [Composable(typeof (IRatingItemImageInfoFactory), CompositionType.Public, 327680, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IRatingItemImageInfoStatics), 327680, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  public class RatingItemImageInfo : RatingItemInfo, IRatingItemImageInfo
  {
    /// <summary>Initializes a new instance of the RatingItemImageInfo class.</summary>
    [MethodImpl]
    public extern RatingItemImageInfo();

    /// <summary>Gets or sets an image that represents a rating element that is disabled.</summary>
    /// <returns>An object that represents the image source file for the drawn image. Typically you set this with a BitmapImage object, constructed with the Uniform Resource Identifier (URI) that describes the path to a valid image source file. Or, you can initialize a BitmapSource with a stream, perhaps a stream from a storage file.</returns>
    public extern ImageSource DisabledImage { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets an image that represents a rating element that has been set by the user.</summary>
    /// <returns>An object that represents the image source file for the drawn image. Typically you set this with a BitmapImage object, constructed with the Uniform Resource Identifier (URI) that describes the path to a valid image source file. Or, you can initialize a BitmapSource with a stream, perhaps a stream from a storage file.</returns>
    public extern ImageSource Image { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets an image that represents a rating element that is showing a placeholder value.</summary>
    /// <returns>An object that represents the image source file for the drawn image. Typically you set this with a BitmapImage object, constructed with the Uniform Resource Identifier (URI) that describes the path to a valid image source file. Or, you can initialize a BitmapSource with a stream, perhaps a stream from a storage file.</returns>
    public extern ImageSource PlaceholderImage { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets an image that represents a rating element that has the pointer over it.</summary>
    /// <returns>An object that represents the image source file for the drawn image. Typically you set this with a BitmapImage object, constructed with the Uniform Resource Identifier (URI) that describes the path to a valid image source file. Or, you can initialize a BitmapSource with a stream, perhaps a stream from a storage file.</returns>
    public extern ImageSource PointerOverImage { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets an image that represents a rating element showing a placeholder value with the pointer over it.</summary>
    /// <returns>An object that represents the image source file for the drawn image. Typically you set this with a BitmapImage object, constructed with the Uniform Resource Identifier (URI) that describes the path to a valid image source file. Or, you can initialize a BitmapSource with a stream, perhaps a stream from a storage file.</returns>
    public extern ImageSource PointerOverPlaceholderImage { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets an image that represents a rating element that has not been set.</summary>
    /// <returns>An object that represents the image source file for the drawn image. Typically you set this with a BitmapImage object, constructed with the Uniform Resource Identifier (URI) that describes the path to a valid image source file. Or, you can initialize a BitmapSource with a stream, perhaps a stream from a storage file.</returns>
    public extern ImageSource UnsetImage { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Identifies the DisabledImage dependency property.</summary>
    /// <returns>The identifier for DisabledImage dependency property.</returns>
    public static extern DependencyProperty DisabledImageProperty { [MethodImpl] get; }

    /// <summary>Identifies the Image dependency property.</summary>
    /// <returns>The identifier for Image dependency property.</returns>
    public static extern DependencyProperty ImageProperty { [MethodImpl] get; }

    /// <summary>Identifies the PlaceholderImage dependency property.</summary>
    /// <returns>The identifier for PlaceholderImage dependency property.</returns>
    public static extern DependencyProperty PlaceholderImageProperty { [MethodImpl] get; }

    /// <summary>Identifies the PointerOverImage dependency property.</summary>
    /// <returns>The identifier for PointerOverImage dependency property.</returns>
    public static extern DependencyProperty PointerOverImageProperty { [MethodImpl] get; }

    /// <summary>Identifies the PointerOverPlaceholderImage dependency property.</summary>
    /// <returns>The identifier for PointerOverPlaceholderImage dependency property.</returns>
    public static extern DependencyProperty PointerOverPlaceholderImageProperty { [MethodImpl] get; }

    /// <summary>Identifies the UnsetImage dependency property.</summary>
    /// <returns>The identifier for UnsetImage dependency property.</returns>
    public static extern DependencyProperty UnsetImageProperty { [MethodImpl] get; }
  }
}
