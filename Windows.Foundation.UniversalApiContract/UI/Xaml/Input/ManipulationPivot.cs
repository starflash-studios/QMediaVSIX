// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Input.ManipulationPivot
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Input
{
  /// <summary>Specifies how a rotation occurs with one point of user input.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [WebHostHidden]
  [Activatable(typeof (IManipulationPivotFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class ManipulationPivot : IManipulationPivot
  {
    /// <summary>Initializes a new instance of the ManipulationPivot class with the specified center and radius values.</summary>
    /// <param name="center">The center point of the pivot.</param>
    /// <param name="radius">The pivot radius.</param>
    [MethodImpl]
    public extern ManipulationPivot(Point center, double radius);

    /// <summary>Initializes a new instance of the ManipulationPivot class with no initial values.</summary>
    [MethodImpl]
    public extern ManipulationPivot();

    /// <summary>Gets or sets the center point for rotation manipulations.</summary>
    /// <returns>The center point for rotation manipulations.</returns>
    public extern Point Center { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the effective radius of rotation for rotation manipulations.</summary>
    /// <returns>A value in pixels.</returns>
    public extern double Radius { [MethodImpl] get; [MethodImpl] set; }
  }
}
