// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.EasingColorKeyFrame
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Animation
{
  /// <summary>Associates easing functions with a ColorAnimationUsingKeyFrames key-frame animation.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  [Threading(ThreadingModel.Both)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IEasingColorKeyFrameStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class EasingColorKeyFrame : ColorKeyFrame, IEasingColorKeyFrame
  {
    /// <summary>Initializes a new instance of the EasingColorKeyFrame class.</summary>
    [MethodImpl]
    public extern EasingColorKeyFrame();

    /// <summary>Gets or sets the easing function that is applied to the key frame.</summary>
    /// <returns>The easing function that is applied to the key frame.</returns>
    public extern EasingFunctionBase EasingFunction { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Identifies the EasingFunction dependency property.</summary>
    /// <returns>The identifier for the EasingFunction dependency property.</returns>
    public static extern DependencyProperty EasingFunctionProperty { [MethodImpl] get; }
  }
}
