// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.TreeViewCollapsedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Provides event data for the TreeView.Collapsed event.</summary>
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  public sealed class TreeViewCollapsedEventArgs : 
    ITreeViewCollapsedEventArgs,
    ITreeViewCollapsedEventArgs2
  {
    /// <summary>Gets the TreeView node that is collapsed.</summary>
    /// <returns>The TreeView node that is collapsed.</returns>
    public extern TreeViewNode Node { [MethodImpl] get; }

    /// <summary>Gets the TreeView item that is collapsed.</summary>
    /// <returns>The TreeView item that is collapsed.</returns>
    public extern object Item { [MethodImpl] get; }
  }
}
