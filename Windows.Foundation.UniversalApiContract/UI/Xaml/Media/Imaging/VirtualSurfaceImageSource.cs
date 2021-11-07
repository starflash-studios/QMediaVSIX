// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Imaging.VirtualSurfaceImageSource
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Imaging
{
  /// <summary>Extends SurfaceImageSource to support scenarios when the content is potentially larger than what can fit on screen and the content must be virtualized to render optimally.</summary>
  [Threading(ThreadingModel.Both)]
  [WebHostHidden]
  [Activatable(typeof (IVirtualSurfaceImageSourceFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class VirtualSurfaceImageSource : SurfaceImageSource, IVirtualSurfaceImageSource
  {
    /// <summary>Initializes a new instance of the VirtualSurfaceImageSource class, specifying the size of the drawing area.</summary>
    /// <param name="pixelWidth">Width of the drawing area in pixels.</param>
    /// <param name="pixelHeight">Height of the drawing area in pixels.</param>
    [MethodImpl]
    public extern VirtualSurfaceImageSource(int pixelWidth, int pixelHeight);

    /// <summary>Initializes a new instance of the VirtualSurfaceImageSource class, specifying the size of the drawing area and a preference for whether to render with an alpha transparency.</summary>
    /// <param name="pixelWidth">Width of the drawing area in pixels.</param>
    /// <param name="pixelHeight">Height of the drawing area in pixels.</param>
    /// <param name="isOpaque">**true** if the area should render opaque. **false** to render with possible alpha transparency.</param>
    [MethodImpl]
    public extern VirtualSurfaceImageSource(int pixelWidth, int pixelHeight, bool isOpaque);
  }
}
