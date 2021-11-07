// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.SplineColorKeyFrame
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Animation
{
  /// <summary>Animates from the Color value of the previous key frame to its own Value using splined interpolation.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (ISplineColorKeyFrameStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class SplineColorKeyFrame : ColorKeyFrame, ISplineColorKeyFrame
  {
    /// <summary>Initializes a new instance of the SplineColorKeyFrame class.</summary>
    [MethodImpl]
    public extern SplineColorKeyFrame();

    /// <summary>Gets or sets the two control points that define animation progress for this key frame.</summary>
    /// <returns>The two control points that specify the cubic Bezier curve that defines the progress of the key frame.</returns>
    public extern KeySpline KeySpline { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Identifies the KeySpline dependency property.</summary>
    /// <returns>The identifier for the KeySpline dependency property.</returns>
    public static extern DependencyProperty KeySplineProperty { [MethodImpl] get; }
  }
}
