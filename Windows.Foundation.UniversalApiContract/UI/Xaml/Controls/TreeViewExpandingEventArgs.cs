// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.TreeViewExpandingEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Provides event data for the TreeView.Expanding event.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [WebHostHidden]
  public sealed class TreeViewExpandingEventArgs : 
    ITreeViewExpandingEventArgs,
    ITreeViewExpandingEventArgs2
  {
    /// <summary>Gets the tree view node that is expanding.</summary>
    /// <returns>The tree view node that is expanding.</returns>
    public extern TreeViewNode Node { [MethodImpl] get; }

    /// <summary>Gets the data item for the tree view node that is expanding.</summary>
    /// <returns>The data item for the tree view node that is expanding.</returns>
    public extern object Item { [MethodImpl] get; }
  }
}
