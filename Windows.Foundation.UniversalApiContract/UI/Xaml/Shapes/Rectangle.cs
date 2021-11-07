// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Shapes.Rectangle
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Shapes
{
  /// <summary>Draws a rectangle with a given Height and Width specified in device-independent pixel (DIP).</summary>
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IRectangleStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class Rectangle : Shape, IRectangle
  {
    /// <summary>Initializes a new instance of the Rectangle class.</summary>
    [MethodImpl]
    public extern Rectangle();

    /// <summary>Gets or sets the x-axis radius of the ellipse that is used to round the corners of the rectangle.</summary>
    /// <returns>The x-axis radius of the ellipse that is used to round the corners of the rectangle.</returns>
    public extern double RadiusX { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the y-axis radius of the ellipse that is used to round the corners of the rectangle.</summary>
    /// <returns>The y-axis radius of the ellipse that is used to round the corners of the rectangle. The default is 0.</returns>
    public extern double RadiusY { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Identifies the RadiusX dependency property.</summary>
    /// <returns>The identifier for the RadiusX dependency property.</returns>
    public static extern DependencyProperty RadiusXProperty { [MethodImpl] get; }

    /// <summary>Identifies the RadiusY dependency property.</summary>
    /// <returns>The identifier for the RadiusY dependency property.</returns>
    public static extern DependencyProperty RadiusYProperty { [MethodImpl] get; }
  }
}
