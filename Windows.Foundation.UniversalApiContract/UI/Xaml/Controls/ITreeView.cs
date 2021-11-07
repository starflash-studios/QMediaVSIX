// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ITreeView
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [Guid(2471742556, 56686, 17724, 174, 221, 12, 58, 201, 147, 151, 139)]
  [ExclusiveTo(typeof (TreeView))]
  internal interface ITreeView
  {
    IVector<TreeViewNode> RootNodes { get; }

    TreeViewSelectionMode SelectionMode { get; set; }

    IVector<TreeViewNode> SelectedNodes { get; }

    void Expand(TreeViewNode value);

    void Collapse(TreeViewNode value);

    void SelectAll();

    event TypedEventHandler<TreeView, TreeViewItemInvokedEventArgs> ItemInvoked;

    event TypedEventHandler<TreeView, TreeViewExpandingEventArgs> Expanding;

    event TypedEventHandler<TreeView, TreeViewCollapsedEventArgs> Collapsed;
  }
}
