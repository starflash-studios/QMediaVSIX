// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Imaging.SurfaceImageSource
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Imaging
{
  /// <summary>Provides Microsoft DirectX shared surfaces to draw into and then composes the bits into app content.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [WebHostHidden]
  [Composable(typeof (ISurfaceImageSourceFactory), CompositionType.Public, 65536, "Windows.Foundation.UniversalApiContract")]
  public class SurfaceImageSource : ImageSource, ISurfaceImageSource
  {
    /// <summary>Initializes a new instance of the SurfaceImageSource class, specifying the size of the drawing area.</summary>
    /// <param name="pixelWidth">Width of the drawing area in pixels.</param>
    /// <param name="pixelHeight">Height of the drawing area in pixels.</param>
    [MethodImpl]
    public extern SurfaceImageSource(int pixelWidth, int pixelHeight);

    /// <summary>Initializes a new instance of the SurfaceImageSource class, specifying the size of the drawing area, and whether opacity is expected to be always full opacity. Use this with `isOpaque=true` if SurfaceImageSource should not support transparency; this can increase performance.</summary>
    /// <param name="pixelWidth">Width of the drawing area in pixels.</param>
    /// <param name="pixelHeight">Height of the drawing area in pixels.</param>
    /// <param name="isOpaque">**true** if the area should render opaque. **false** to render with possible alpha transparency. A value of **true** can provide a performance benefit if the content is not transparent.</param>
    [MethodImpl]
    public extern SurfaceImageSource(int pixelWidth, int pixelHeight, bool isOpaque);
  }
}
