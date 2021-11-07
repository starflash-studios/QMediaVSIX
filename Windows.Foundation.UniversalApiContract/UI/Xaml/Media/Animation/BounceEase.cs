// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.BounceEase
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Animation
{
  /// <summary>Represents an easing function that creates an animated bouncing effect.</summary>
  [Static(typeof (IBounceEaseStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  public sealed class BounceEase : EasingFunctionBase, IBounceEase
  {
    /// <summary>Initializes a new instance of the BounceEase class.</summary>
    [MethodImpl]
    public extern BounceEase();

    /// <summary>Gets or sets the number of bounces.</summary>
    /// <returns>The number of bounces. The value must be greater or equal to zero. Negative values will resolve to zero. The default is 3.</returns>
    public extern int Bounces { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that specifies how bouncy the bounce animation is. Low values of this property result in bounces with little loss of height between bounces (more bouncy) while high values result in dampened bounces (less bouncy).</summary>
    /// <returns>The value that specifies how bouncy the bounce animation is. This value must be positive. The default value is 2.</returns>
    public extern double Bounciness { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Identifies the Bounces dependency property.</summary>
    /// <returns>The identifier for the Bounces dependency property.</returns>
    public static extern DependencyProperty BouncesProperty { [MethodImpl] get; }

    /// <summary>Identifies the Bounciness dependency property.</summary>
    /// <returns>The identifier for the Bounciness dependency property.</returns>
    public static extern DependencyProperty BouncinessProperty { [MethodImpl] get; }
  }
}
