// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.RefreshVisualizer
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Represents a control that provides animated state indicators for content refresh.</summary>
  [Static(typeof (IRefreshVisualizerStatics), 393216, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [WebHostHidden]
  [Threading(ThreadingModel.Both)]
  [Composable(typeof (IRefreshVisualizerFactory), CompositionType.Public, 393216, "Windows.Foundation.UniversalApiContract")]
  public class RefreshVisualizer : Control, IRefreshVisualizer
  {
    /// <summary>Initializes a new instance of the RefreshVisualizer class.</summary>
    [MethodImpl]
    public extern RefreshVisualizer();

    /// <summary>Initiates an update of the content.</summary>
    [MethodImpl]
    public extern void RequestRefresh();

    /// <summary>Gets or sets a value that indicates the orientation of the visualizer.</summary>
    /// <returns>A value of the enumeration that indicates the orientation of the visualizer. The default is **Top**.</returns>
    public extern RefreshVisualizerOrientation Orientation { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the content of the visualizer.</summary>
    /// <returns>The content of the visualizer.</returns>
    public extern UIElement Content { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets a value that indicates the state of the visualizer.</summary>
    /// <returns>A value of the enumeration that indicates the state of the visualizer.</returns>
    public extern RefreshVisualizerState State { [MethodImpl] get; }

    /// <summary>Occurs when an update of the content has been initiated.</summary>
    public extern event TypedEventHandler<RefreshVisualizer, RefreshRequestedEventArgs> RefreshRequested;

    /// <summary>Occurs when the state of the visualizer changes.</summary>
    public extern event TypedEventHandler<RefreshVisualizer, RefreshStateChangedEventArgs> RefreshStateChanged;

    /// <summary>Identifies the InfoProvider dependency property.</summary>
    /// <returns>The identifier for the InfoProvider dependency property.</returns>
    public static extern DependencyProperty InfoProviderProperty { [MethodImpl] get; }

    /// <summary>Identifies the Orientation dependency property.</summary>
    /// <returns>The identifier for the Orientation dependency property.</returns>
    public static extern DependencyProperty OrientationProperty { [MethodImpl] get; }

    /// <summary>Identifies the Content dependency property.</summary>
    /// <returns>The identifier for the Content dependency property.</returns>
    public static extern DependencyProperty ContentProperty { [MethodImpl] get; }

    /// <summary>Identifies the State dependency property.</summary>
    /// <returns>The identifier for the State dependency property.</returns>
    public static extern DependencyProperty StateProperty { [MethodImpl] get; }
  }
}
