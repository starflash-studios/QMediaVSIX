// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.LineGeometry
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media
{
  /// <summary>Represents the geometry of a line.</summary>
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [Static(typeof (ILineGeometryStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class LineGeometry : Geometry, ILineGeometry
  {
    /// <summary>Initializes a new instance of the LineGeometry class that has no length.</summary>
    [MethodImpl]
    public extern LineGeometry();

    /// <summary>Gets or sets the start point of the line.</summary>
    /// <returns>The start point of the line. The default is a Point with value 0,0.</returns>
    public extern Point StartPoint { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the end point of a line.</summary>
    /// <returns>The end point of the line. The default is a Point with value 0,0.</returns>
    public extern Point EndPoint { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Identifies the StartPoint dependency property.</summary>
    /// <returns>The identifier for the StartPoint dependency property.</returns>
    public static extern DependencyProperty StartPointProperty { [MethodImpl] get; }

    /// <summary>Identifies the EndPoint dependency property.</summary>
    /// <returns>The identifier for the EndPoint dependency property.</returns>
    public static extern DependencyProperty EndPointProperty { [MethodImpl] get; }
  }
}
