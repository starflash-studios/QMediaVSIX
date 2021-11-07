// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.GradientStop
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Markup;

namespace Windows.UI.Xaml.Media
{
  /// <summary>Describes the location and color of a transition point in a gradient.</summary>
  [Threading(ThreadingModel.Both)]
  [ContentProperty(Name = "Color")]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IGradientStopStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class GradientStop : DependencyObject, IGradientStop
  {
    /// <summary>Initializes a new instance of the GradientStop class.</summary>
    [MethodImpl]
    public extern GradientStop();

    /// <summary>Gets or sets the color of the gradient stop.</summary>
    /// <returns>The color of the gradient stop. The default is Transparent.</returns>
    public extern Color Color { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the location of the gradient stop within the gradient vector.</summary>
    /// <returns>The relative location of this gradient stop along the gradient vector. The default is 0.</returns>
    public extern double Offset { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Identifies the Color dependency property.</summary>
    /// <returns>The identifier for the Color dependency property.</returns>
    public static extern DependencyProperty ColorProperty { [MethodImpl] get; }

    /// <summary>Identifies the Offset dependency property.</summary>
    /// <returns>The identifier for the Offset dependency property.</returns>
    public static extern DependencyProperty OffsetProperty { [MethodImpl] get; }
  }
}
