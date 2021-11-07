// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Shapes.Path
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Media;

namespace Windows.UI.Xaml.Shapes
{
  /// <summary>Draws a series of connected lines and curves. The line and curve dimensions are declared through the Data property, and can be specified either with Move and draw commands syntax, or with an object model.</summary>
  [Static(typeof (IPathStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Threading(ThreadingModel.Both)]
  [Composable(typeof (IPathFactory), CompositionType.Public, 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  public class Path : Shape, IPath
  {
    /// <summary>Initializes a new instance of the Path class.</summary>
    [MethodImpl]
    public extern Path();

    /// <summary>Gets or sets a Geometry that specifies the shape to be drawn.</summary>
    /// <returns>A description of the shape to be drawn.</returns>
    public extern Geometry Data { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Identifies the Data dependency property.</summary>
    /// <returns>The identifier for the Data dependency property.</returns>
    public static extern DependencyProperty DataProperty { [MethodImpl] get; }
  }
}
