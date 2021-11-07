// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Primitives.TickBar
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Media;

namespace Windows.UI.Xaml.Controls.Primitives
{
  /// <summary>Represents a tick mark on a Slider control. Not intended for general use.</summary>
  [Static(typeof (ITickBarStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class TickBar : FrameworkElement, ITickBar
  {
    /// <summary>Initializes a new instance of the TickBar class.</summary>
    [MethodImpl]
    public extern TickBar();

    /// <summary>Gets or sets the Brush that draws on the background area of the TickBar.</summary>
    /// <returns>The Brush that draws on the background area of the TickBar.</returns>
    public extern Brush Fill { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Identifies the Fill dependency property.</summary>
    /// <returns>The identifier for the Fill dependency property.</returns>
    public static extern DependencyProperty FillProperty { [MethodImpl] get; }
  }
}
