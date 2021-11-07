// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.ColorKeyFrame
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Animation
{
  /// <summary>Provides a base class for specific animation key-frame techniques that define an animation segment with a Color target value. Derived classes each provide a different key-frame interpolation method for a Color value that is provided for a ColorAnimationUsingKeyFrames animation.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Threading(ThreadingModel.Both)]
  [Composable(typeof (IColorKeyFrameFactory), CompositionType.Protected, 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IColorKeyFrameStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  public class ColorKeyFrame : DependencyObject, IColorKeyFrame
  {
    /// <summary>Provides base class initialization behavior for ColorKeyFrame -derived classes.</summary>
    [MethodImpl]
    protected extern ColorKeyFrame();

    /// <summary>Gets or sets the key frame's target value.</summary>
    /// <returns>The key frame's target value, which is the value at its specified KeyTime. The default is a Color with an ARGB value of #00000000.</returns>
    public extern Color Value { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the time at which the key frame's target Value should be reached.</summary>
    /// <returns>The time at which the key frame's current value should be equal to its Value property. The default is null.</returns>
    public extern KeyTime KeyTime { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Identifies the Value dependency property.</summary>
    /// <returns>The identifier for the Value  dependency property.</returns>
    public static extern DependencyProperty ValueProperty { [MethodImpl] get; }

    /// <summary>Identifies the KeyTime dependency property.</summary>
    /// <returns>The identifier for the KeyTime  dependency property.</returns>
    public static extern DependencyProperty KeyTimeProperty { [MethodImpl] get; }
  }
}
