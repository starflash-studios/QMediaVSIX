// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Media3D.PerspectiveTransform3D
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Media3D
{
  /// <summary>Represents a 3-D perspective effect.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IPerspectiveTransform3DStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [Threading(ThreadingModel.Both)]
  public sealed class PerspectiveTransform3D : Transform3D, IPerspectiveTransform3D
  {
    /// <summary>Initializes a new instance of the PerspectiveTransform3D class.</summary>
    [MethodImpl]
    public extern PerspectiveTransform3D();

    /// <summary>Gets or sets the distance in pixels to the plane where z=0.</summary>
    /// <returns>The distance to the z=0 plane. This value must be greater than zero. The default value is 1000.</returns>
    public extern double Depth { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the x-offset in pixels for the perspective's origin from the center of the element.</summary>
    /// <returns>The x-offset of the perspective's origin from the center of the element. This distance is measured in pixels and the default value is 0.</returns>
    public extern double OffsetX { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the y-offset in pixels for the perspective's origin from the center of the element.</summary>
    /// <returns>The y-offset of the perspective's origin from the center of the element. This distance is measured in pixels and the default value is 0.</returns>
    public extern double OffsetY { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Identifies the Depth dependency property.</summary>
    /// <returns>The Depth dependency property identifier.</returns>
    public static extern DependencyProperty DepthProperty { [MethodImpl] get; }

    /// <summary>Identifies the OffsetX dependency property.</summary>
    /// <returns>The OffsetX dependency property identifier.</returns>
    public static extern DependencyProperty OffsetXProperty { [MethodImpl] get; }

    /// <summary>Identifies the OffsetY dependency property.</summary>
    /// <returns>The OffsetY dependency property identifier.</returns>
    public static extern DependencyProperty OffsetYProperty { [MethodImpl] get; }
  }
}
