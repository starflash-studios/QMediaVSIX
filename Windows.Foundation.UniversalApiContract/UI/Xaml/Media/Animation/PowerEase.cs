// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.PowerEase
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Animation
{
  /// <summary>Represents an easing function that creates an animation that accelerates and/or decelerates using the formula *f* (*t*) = *t**&lt;sup&gt;p&lt;/sup&gt;* where *p* is equal to the Power property.</summary>
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IPowerEaseStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class PowerEase : EasingFunctionBase, IPowerEase
  {
    /// <summary>Initializes a new instance of the PowerEase class.</summary>
    [MethodImpl]
    public extern PowerEase();

    /// <summary>Gets or sets the exponential power of the animation interpolation. For example, a value of 7 creates an animation interpolation curve that follows the formula *f* (*t*) = *t*&lt;sup&gt;7&lt;/sup&gt;.</summary>
    /// <returns>The exponential power of the animation interpolation. This value must be greater or equal to 0. The default is 2.</returns>
    public extern double Power { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Identifies the Power dependency property.</summary>
    /// <returns>The identifier for the Power dependency property.</returns>
    public static extern DependencyProperty PowerProperty { [MethodImpl] get; }
  }
}
