// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.KeySpline
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Animation
{
  /// <summary>Represents a spline key frame to define animation progress.</summary>
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class KeySpline : DependencyObject, IKeySpline
  {
    /// <summary>Initializes a new instance of the KeySpline class.</summary>
    [MethodImpl]
    public extern KeySpline();

    /// <summary>Gets or sets the first control point used to define a Bezier curve that describes a KeySpline.</summary>
    /// <returns>The first control point used to define a Bezier curve that describes a KeySpline.</returns>
    public extern Point ControlPoint1 { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the second control point used to define a Bezier curve that describes a KeySpline.</summary>
    /// <returns>The second control point used to define a Bezier curve that describes a KeySpline.</returns>
    public extern Point ControlPoint2 { [MethodImpl] get; [MethodImpl] set; }
  }
}
