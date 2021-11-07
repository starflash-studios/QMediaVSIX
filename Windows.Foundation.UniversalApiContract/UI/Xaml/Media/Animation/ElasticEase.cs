// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.ElasticEase
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Animation
{
  /// <summary>Represents an easing function that creates an animation that resembles a spring oscillating back and forth until it comes to rest.</summary>
  [WebHostHidden]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [Static(typeof (IElasticEaseStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class ElasticEase : EasingFunctionBase, IElasticEase
  {
    /// <summary>Initializes a new instance of the ElasticEase class.</summary>
    [MethodImpl]
    public extern ElasticEase();

    /// <summary>Gets or sets the number of times the target slides back and forth over the animation destination.</summary>
    /// <returns>The number of times the target slides back and forth over the animation destination. This value must be greater than or equal to 0. The default is 3.</returns>
    public extern int Oscillations { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the stiffness of the spring. The smaller the Springiness value is, the stiffer the spring and the faster the elasticity decreases in intensity over each oscillation.</summary>
    /// <returns>A positive number that specifies the stiffness of the spring. The default value is 3.</returns>
    public extern double Springiness { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Identifies the Oscillations dependency property.</summary>
    /// <returns>The identifier for the Oscillations dependency property.</returns>
    public static extern DependencyProperty OscillationsProperty { [MethodImpl] get; }

    /// <summary>Identifies the Springiness dependency property.</summary>
    /// <returns>The identifier for the Springiness dependency property.</returns>
    public static extern DependencyProperty SpringinessProperty { [MethodImpl] get; }
  }
}
