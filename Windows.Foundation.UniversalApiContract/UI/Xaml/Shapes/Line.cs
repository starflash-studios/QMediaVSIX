// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Shapes.Line
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Shapes
{
  /// <summary>Draws a straight line between two points.</summary>
  [Static(typeof (ILineStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class Line : Shape, ILine
  {
    /// <summary>Initializes a new instance of the Line class.</summary>
    [MethodImpl]
    public extern Line();

    /// <summary>Gets or sets the x-coordinate of the Line start point.</summary>
    /// <returns>The x-coordinate for the start point of the line, in pixels. The default is 0.</returns>
    public extern double X1 { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the y-coordinate of the Line start point.</summary>
    /// <returns>The y-coordinate for the start point of the line, in pixels. The default is 0.</returns>
    public extern double Y1 { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the x-coordinate of the Line end point.</summary>
    /// <returns>The x-coordinate for the end point of the line, in pixels. The default is 0.</returns>
    public extern double X2 { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the y-coordinate of the Line end point.</summary>
    /// <returns>The y-coordinate for the end point of the line, in pixels. The default is 0.</returns>
    public extern double Y2 { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Identifies the X1 dependency property.</summary>
    /// <returns>The identifier for the X1 dependency property.</returns>
    public static extern DependencyProperty X1Property { [MethodImpl] get; }

    /// <summary>Identifies the Y1 dependency property.</summary>
    /// <returns>The identifier for the Y1 dependency property.</returns>
    public static extern DependencyProperty Y1Property { [MethodImpl] get; }

    /// <summary>Identifies the X2 dependency property.</summary>
    /// <returns>The identifier for the X2 dependency property.</returns>
    public static extern DependencyProperty X2Property { [MethodImpl] get; }

    /// <summary>Identifies the Y2 dependency property.</summary>
    /// <returns>The identifier for the Y2 dependency property.</returns>
    public static extern DependencyProperty Y2Property { [MethodImpl] get; }
  }
}
