// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.RectangleGeometry
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media
{
  /// <summary>Describes a two-dimensional rectangular geometry.</summary>
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IRectangleGeometryStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  public sealed class RectangleGeometry : Geometry, IRectangleGeometry
  {
    /// <summary>Initializes a new instance of the RectangleGeometry class and creates a rectangle with zero area.</summary>
    [MethodImpl]
    public extern RectangleGeometry();

    /// <summary>Gets or sets the dimensions of the rectangle.</summary>
    /// <returns>The Rect structure that describes the position and size of the rectangle. The default is **null**.</returns>
    public extern Rect Rect { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Identifies the Rect  dependency property.</summary>
    /// <returns>The identifier for the Rect  dependency property.</returns>
    public static extern DependencyProperty RectProperty { [MethodImpl] get; }
  }
}
