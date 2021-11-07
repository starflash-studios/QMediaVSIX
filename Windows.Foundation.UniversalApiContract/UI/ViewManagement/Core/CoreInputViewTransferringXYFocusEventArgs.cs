// Decompiled with JetBrains decompiler
// Type: Windows.UI.ViewManagement.Core.CoreInputViewTransferringXYFocusEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.ViewManagement.Core
{
  /// <summary>Contains event data for the XYFocusTransferringFromPrimaryView event.</summary>
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [DualApiPartition(version = 1)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class CoreInputViewTransferringXYFocusEventArgs : 
    ICoreInputViewTransferringXYFocusEventArgs
  {
    /// <summary>Gets the bounding rect of the originally focused element.</summary>
    /// <returns>The bounding rect of the focused input pane element for the TryTransferXYFocusToPrimaryView method, or the bounding rect of the focused UI element in the application for the XYFocusTransferringFromPrimaryView event.</returns>
    public extern Rect Origin { [MethodImpl] get; }

    /// <summary>Gets the direction of focus navigation relative to the input pane.</summary>
    /// <returns>One of the values from CoreInputViewXYFocusTransferDirection.</returns>
    public extern CoreInputViewXYFocusTransferDirection Direction { [MethodImpl] get; }

    /// <summary>Gets or sets a value that marks the XYFocusTransferringFromPrimaryView event as handled.</summary>
    /// <returns>Set the value to true on successful focus navigation. The default is false.</returns>
    public extern bool TransferHandled { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets or sets whether the input pane remains visible when the UI element loses focus.</summary>
    /// <returns>True, if the input pane remains visible; otherwise, false. The default is true.</returns>
    public extern bool KeepPrimaryViewVisible { [MethodImpl] set; [MethodImpl] get; }
  }
}
