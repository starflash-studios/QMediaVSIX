// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.EasingFunctionBase
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Animation
{
  /// <summary>Provides the base class for all the easing functions.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [Composable(typeof (IEasingFunctionBaseFactory), CompositionType.Public, 65536, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IEasingFunctionBaseStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  public class EasingFunctionBase : DependencyObject, IEasingFunctionBase
  {
    /// <summary>Gets or sets a value that specifies how the animation interpolates.</summary>
    /// <returns>One of the enumeration values that specifies how the animation interpolates. The default is **EaseOut**.</returns>
    public extern EasingMode EasingMode { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Transforms normalized time to control the pace of an animation.</summary>
    /// <param name="normalizedTime">Normalized time (progress) of the animation.</param>
    /// <returns>A double that represents the transformed progress.</returns>
    [MethodImpl]
    public extern double Ease(double normalizedTime);

    /// <summary>Identifies the EasingMode dependency property.</summary>
    /// <returns>The identifier for the EasingMode dependency property.</returns>
    public static extern DependencyProperty EasingModeProperty { [MethodImpl] get; }
  }
}
