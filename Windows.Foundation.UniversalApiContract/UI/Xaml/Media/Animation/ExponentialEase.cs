// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.ExponentialEase
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Animation
{
  /// <summary>Represents an easing function that creates an animation that accelerates and/or decelerates using an exponential formula.</summary>
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IExponentialEaseStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class ExponentialEase : EasingFunctionBase, IExponentialEase
  {
    /// <summary>Initializes a new instance of the ExponentialEase class.</summary>
    [MethodImpl]
    public extern ExponentialEase();

    /// <summary>Gets or sets the exponent used to determine the interpolation of the animation.</summary>
    /// <returns>The exponent used to determine the interpolation of the animation. The default is 2.</returns>
    public extern double Exponent { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Identifies the Exponent  dependency property.</summary>
    /// <returns>The identifier for the Exponent  dependency property.</returns>
    public static extern DependencyProperty ExponentProperty { [MethodImpl] get; }
  }
}
