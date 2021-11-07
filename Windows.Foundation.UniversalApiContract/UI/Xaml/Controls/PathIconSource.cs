// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.PathIconSource
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Media;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Represents an icon source that uses a vector path as its content.</summary>
  [Threading(ThreadingModel.Both)]
  [Static(typeof (IPathIconSourceStatics), 327680, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Composable(typeof (IPathIconSourceFactory), CompositionType.Public, 327680, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  public class PathIconSource : IconSource, IPathIconSource
  {
    /// <summary>Initializes a new instance of the PathIconSource class.</summary>
    [MethodImpl]
    public extern PathIconSource();

    /// <summary>Gets or sets a Geometry that specifies the shape to be drawn. In XAML. this can also be set using a string that describes Move and draw commands syntax.</summary>
    /// <returns>A description of the shape to be drawn.</returns>
    public extern Geometry Data { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Identifies the Data dependency property.</summary>
    /// <returns>The identifier for the Data dependency property.</returns>
    public static extern DependencyProperty DataProperty { [MethodImpl] get; }
  }
}
