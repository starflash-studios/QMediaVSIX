// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.SplineDoubleKeyFrame
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Animation
{
  /// <summary>Animates from the Double value of the previous key frame to its own Value using splined interpolation.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (ISplineDoubleKeyFrameStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class SplineDoubleKeyFrame : DoubleKeyFrame, ISplineDoubleKeyFrame
  {
    /// <summary>Initializes a new instance of the SplineDoubleKeyFrame class.</summary>
    [MethodImpl]
    public extern SplineDoubleKeyFrame();

    /// <summary>Gets or sets the two control points that define animation progress for this key frame.</summary>
    /// <returns>The two control points that specify the cubic Bezier curve that defines the progress of the key frame.</returns>
    public extern KeySpline KeySpline { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Identifies the KeySpline dependency property.</summary>
    /// <returns>The identifier for the KeySpline dependency property.</returns>
    public static extern DependencyProperty KeySplineProperty { [MethodImpl] get; }
  }
}
