// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.PointKeyFrame
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Animation
{
  /// <summary>Defines an animation segment with its own target value and interpolation method for a PointAnimationUsingKeyFrames.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [WebHostHidden]
  [Composable(typeof (IPointKeyFrameFactory), CompositionType.Protected, 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IPointKeyFrameStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  public class PointKeyFrame : DependencyObject, IPointKeyFrame
  {
    /// <summary>Provides base class initialization behavior for PointKeyFrame -derived classes.</summary>
    [MethodImpl]
    protected extern PointKeyFrame();

    /// <summary>Gets or sets the key frame's target value.</summary>
    /// <returns>The key frame's target value, which is the value of this key frame at its specified KeyTime. The default is 0.</returns>
    public extern Point Value { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the time at which the key frame's target Value should be reached.</summary>
    /// <returns>The time at which the key frame's current value should be equal to its Value property. The default is null.</returns>
    public extern KeyTime KeyTime { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Identifies the Value dependency property.</summary>
    /// <returns>The identifier for the Value dependency property.</returns>
    public static extern DependencyProperty ValueProperty { [MethodImpl] get; }

    /// <summary>Identifies the KeyTime dependency property.</summary>
    /// <returns>The identifier for the KeyTime dependency property.</returns>
    public static extern DependencyProperty KeyTimeProperty { [MethodImpl] get; }
  }
}
