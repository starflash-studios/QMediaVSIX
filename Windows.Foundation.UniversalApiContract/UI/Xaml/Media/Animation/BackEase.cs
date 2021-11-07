// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.BackEase
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Animation
{
  /// <summary>Represents an easing function that changes a value in the opposite direction of the main function during part of a duration, then reverses and finishes the function-over-time behavior in a conventional way.</summary>
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IBackEaseStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class BackEase : EasingFunctionBase, IBackEase
  {
    /// <summary>Initializes a new instance of the BackEase class.</summary>
    [MethodImpl]
    public extern BackEase();

    /// <summary>Gets or sets the amplitude of retraction associated with a BackEase animation.</summary>
    /// <returns>The amplitude of retraction associated with a BackEase animation. This value must be greater than or equal to 0. The default is 1.</returns>
    public extern double Amplitude { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Identifies the Amplitude dependency property.</summary>
    /// <returns>The identifier for the Amplitude dependency property.</returns>
    public static extern DependencyProperty AmplitudeProperty { [MethodImpl] get; }
  }
}
