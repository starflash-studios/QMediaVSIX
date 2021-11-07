// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.TreeViewNode
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Data;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Represents a node in a TreeView control.</summary>
  [WebHostHidden]
  [Composable(typeof (ITreeViewNodeFactory), CompositionType.Public, 393216, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [Bindable]
  [Threading(ThreadingModel.Both)]
  [Static(typeof (ITreeViewNodeStatics), 393216, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  public class TreeViewNode : DependencyObject, ITreeViewNode
  {
    /// <summary>Initializes a new instance of the TreeViewNode class.</summary>
    [MethodImpl]
    public extern TreeViewNode();

    /// <summary>Gets or sets the data content for the current node.</summary>
    /// <returns>The data content for the current node.</returns>
    public extern object Content { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the node that is the parent of the current node.</summary>
    /// <returns>The node that is the parent of the current node.</returns>
    public extern TreeViewNode Parent { [MethodImpl] get; }

    /// <summary>Gets or sets a value that indicates whether the cuurent tree view node is expanded.</summary>
    /// <returns>**true** if the node is expanded; otherwise, **false**.</returns>
    public extern bool IsExpanded { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets a value that indicates whether the current node has child items.</summary>
    /// <returns>**true** if the current node has child items; otherwise, **false**.</returns>
    public extern bool HasChildren { [MethodImpl] get; }

    /// <summary>Gets a value that indicates how far the current node is from the root node of the tree.</summary>
    /// <returns>The depth of the current node from the root node of the tree.</returns>
    public extern int Depth { [MethodImpl] get; }

    /// <summary>Gets or sets a value that indicates whether the current node has child items that haven't been shown.</summary>
    /// <returns>**true** of the current node has child items that haven't been shown; otherwise, **false**.</returns>
    public extern bool HasUnrealizedChildren { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the collection of nodes that are children of the current node.</summary>
    /// <returns>The collection of nodes that are children of the current node. The default is an empty collection.</returns>
    public extern IVector<TreeViewNode> Children { [MethodImpl] get; }

    /// <summary>Identifies the Content dependency property.</summary>
    /// <returns>The identifier for the Content dependency property.</returns>
    public static extern DependencyProperty ContentProperty { [MethodImpl] get; }

    /// <summary>Identifies the Depth dependency property.</summary>
    /// <returns>The identifier for the Depth dependency property.</returns>
    public static extern DependencyProperty DepthProperty { [MethodImpl] get; }

    /// <summary>Identifies the IsExpanded dependency property.</summary>
    /// <returns>The identifier for the IsExpanded dependency property.</returns>
    public static extern DependencyProperty IsExpandedProperty { [MethodImpl] get; }

    /// <summary>Identifies the HasChildren dependency property.</summary>
    /// <returns>The identifier for the HasChildren dependency property.</returns>
    public static extern DependencyProperty HasChildrenProperty { [MethodImpl] get; }
  }
}
