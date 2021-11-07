// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.BitmapIconSource
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Represents an icon source that uses a bitmap as its content.</summary>
  [Threading(ThreadingModel.Both)]
  [Static(typeof (IBitmapIconSourceStatics), 327680, "Windows.Foundation.UniversalApiContract")]
  [Composable(typeof (IBitmapIconSourceFactory), CompositionType.Public, 327680, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  public class BitmapIconSource : IconSource, IBitmapIconSource
  {
    /// <summary>Initializes a new instance of the BitmapIconSource class.</summary>
    [MethodImpl]
    public extern BitmapIconSource();

    /// <summary>Gets or sets the Uniform Resource Identifier (URI) of the bitmap to use as the icon content.</summary>
    /// <returns>The Uri of the bitmap to use as the icon content. The default is **null**.</returns>
    public extern Uri UriSource { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates whether the bitmap is shown in a single color.</summary>
    /// <returns>**true** to show the bitmap in a single color; **false** to show the bitmap in full color. The default is **true.**</returns>
    public extern bool ShowAsMonochrome { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Identifies the UriSource dependency property.</summary>
    /// <returns>The identifier for the UriSource dependency property.</returns>
    public static extern DependencyProperty UriSourceProperty { [MethodImpl] get; }

    /// <summary>Identifies the ShowAsMonochrome dependency property.</summary>
    /// <returns>The identifier for the ShowAsMonochrome dependency property.</returns>
    public static extern DependencyProperty ShowAsMonochromeProperty { [MethodImpl] get; }
  }
}
