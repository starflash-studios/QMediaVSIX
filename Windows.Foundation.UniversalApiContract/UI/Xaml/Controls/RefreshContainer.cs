// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.RefreshContainer
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Represents a container control that provides a RefreshVisualizer and pull-to-refresh functionality for scrollable content.</summary>
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [Threading(ThreadingModel.Both)]
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IRefreshContainerStatics), 393216, "Windows.Foundation.UniversalApiContract")]
  [Composable(typeof (IRefreshContainerFactory), CompositionType.Public, 393216, "Windows.Foundation.UniversalApiContract")]
  public class RefreshContainer : ContentControl, IRefreshContainer
  {
    /// <summary>Initializes a new instance of the RefreshContainer control.</summary>
    [MethodImpl]
    public extern RefreshContainer();

    /// <summary>Gets or sets the RefreshVisualizer for this container.</summary>
    /// <returns>The RefreshVisualizer for this container.</returns>
    public extern RefreshVisualizer Visualizer { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that specifies the direction to pull to initiate a refresh.</summary>
    /// <returns>An enumeration value that specifies the direction to pull to initiate a refresh.</returns>
    public extern RefreshPullDirection PullDirection { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Occurs when an update of the content has been initiated.</summary>
    public extern event TypedEventHandler<RefreshContainer, RefreshRequestedEventArgs> RefreshRequested;

    /// <summary>Initiates an update of the content.</summary>
    [MethodImpl]
    public extern void RequestRefresh();

    /// <summary>Identifies the Visualizer dependency property.</summary>
    /// <returns>The identifier for the Visualizer dependency property.</returns>
    public static extern DependencyProperty VisualizerProperty { [MethodImpl] get; }

    /// <summary>Identifies the PullDirection dependency property.</summary>
    /// <returns>The identifier for the PullDirection dependency property.</returns>
    public static extern DependencyProperty PullDirectionProperty { [MethodImpl] get; }
  }
}
