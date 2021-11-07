// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.EllipseGeometry
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media
{
  /// <summary>Represents the geometry of a circle or ellipse.</summary>
  [Threading(ThreadingModel.Both)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [Static(typeof (IEllipseGeometryStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class EllipseGeometry : Geometry, IEllipseGeometry
  {
    /// <summary>Initializes a new instance of the EllipseGeometry class.</summary>
    [MethodImpl]
    public extern EllipseGeometry();

    /// <summary>Gets or sets the center point of the EllipseGeometry.</summary>
    /// <returns>The center point of the EllipseGeometry.</returns>
    public extern Point Center { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the x-radius value of the EllipseGeometry.</summary>
    /// <returns>The x-radius value of the EllipseGeometry.</returns>
    public extern double RadiusX { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the y-radius value of the EllipseGeometry.</summary>
    /// <returns>The y-radius value of the EllipseGeometry.</returns>
    public extern double RadiusY { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Identifies the Center dependency property.</summary>
    /// <returns>The Center dependency property identifier.</returns>
    public static extern DependencyProperty CenterProperty { [MethodImpl] get; }

    /// <summary>Identifies the RadiusX dependency property.</summary>
    /// <returns>The RadiusX dependency property identifier.</returns>
    public static extern DependencyProperty RadiusXProperty { [MethodImpl] get; }

    /// <summary>Identifies the RadiusY dependency property.</summary>
    /// <returns>The RadiusY dependency property identifier.</returns>
    public static extern DependencyProperty RadiusYProperty { [MethodImpl] get; }
  }
}
