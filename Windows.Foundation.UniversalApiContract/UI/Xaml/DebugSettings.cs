// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.DebugSettings
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  /// <summary>Declares how certain aspects of the app behave when it is run in a debug environment</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class DebugSettings : 
    IDebugSettings,
    IDebugSettings2,
    IDebugSettings3,
    IDebugSettings4
  {
    /// <summary>Gets or sets a value that indicates whether to display frame-rate and per-frame CPU usage info. These display as an overlay of counters in the window chrome while the app runs.</summary>
    /// <returns>**true** to display the overlay debug counters; otherwise, **false**.</returns>
    public extern bool EnableFrameRateCounter { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates whether to engage the binding tracing feature of Microsoft Visual Studio when the app runs.</summary>
    /// <returns>**true** to engage the binding tracing feature of Microsoft Visual Studio; otherwise, **false**.</returns>
    public extern bool IsBindingTracingEnabled { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that enables a debug setting that visualizes overdraw operations. This visualization is useful during application development for detecting layout, animation, and other operations that are graphics processing intensive.</summary>
    /// <returns>**true** to enable the visualization, otherwise, **false**.</returns>
    public extern bool IsOverdrawHeatMapEnabled { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Occurs when a Binding cannot be resolved.</summary>
    public extern event BindingFailedEventHandler BindingFailed;

    /// <summary>Gets or sets a value that indicates whether to highlight areas of the app UI surface that are being redrawn each frame.</summary>
    /// <returns>**true** to highlight redraw regions. **false** to not highlight redraw regions. The default is **false**.</returns>
    public extern bool EnableRedrawRegions { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates whether to engage the text performance visualization feature of Microsoft Visual Studio when the app runs.</summary>
    /// <returns>**true** to engage the text performance visualization feature of Microsoft Visual Studio; otherwise, **false**.</returns>
    public extern bool IsTextPerformanceVisualizationEnabled { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates whether XAML errors cause an immediate FailFast rather than returning an error.</summary>
    /// <returns>**true** if XAML errors cause an immediate FailFast rather than returning an error; otherwise, **false**. The default is **false**.</returns>
    public extern bool FailFastOnErrors { [MethodImpl] get; [MethodImpl] set; }
  }
}
