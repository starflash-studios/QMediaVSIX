// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.RefreshVisualizerState
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Defines constants that specify the state of a RefreshVisualizer</summary>
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  public enum RefreshVisualizerState
  {
    /// <summary>The visualizer is idle.</summary>
    Idle,
    /// <summary>The visualizer was pulled in the refresh direction from a position where a refresh is not allowed. Typically, the ScrollViewer was not at position 0 at the start of the pull.</summary>
    Peeking,
    /// <summary>The user is interacting with the visualizer.</summary>
    Interacting,
    /// <summary>The visualizer is pending.</summary>
    Pending,
    /// <summary>The visualizer is being refreshed.</summary>
    Refreshing,
  }
}
