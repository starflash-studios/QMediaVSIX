// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.PathIcon
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Media;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Represents an icon that uses a vector path as its content.</summary>
  [Composable(typeof (IPathIconFactory), CompositionType.Public, 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  [Static(typeof (IPathIconStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public class PathIcon : IconElement, IPathIcon
  {
    /// <summary>Initializes a new instance of the PathIcon class.</summary>
    [MethodImpl]
    public extern PathIcon();

    /// <summary>Gets or sets a Geometry that specifies the shape to be drawn. In XAML. this can also be set using a string that describes Move and draw commands syntax.</summary>
    /// <returns>A description of the shape to be drawn.</returns>
    public extern Geometry Data { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Identifies the Data dependency property.</summary>
    /// <returns>The identifier for the Data dependency property.</returns>
    public static extern DependencyProperty DataProperty { [MethodImpl] get; }
  }
}
