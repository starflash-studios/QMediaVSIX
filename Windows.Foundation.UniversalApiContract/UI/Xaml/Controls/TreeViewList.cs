// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.TreeViewList
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Represents a flattened list of tree view items so that operations such as keyboard navigation and drag-and-drop can be inherited from ListView.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [Threading(ThreadingModel.Both)]
  [Composable(typeof (ITreeViewListFactory), CompositionType.Public, 393216, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  public class TreeViewList : ListView, ITreeViewList
  {
    /// <summary>Initializes a new instance of the TreeViewList control.</summary>
    [MethodImpl]
    public extern TreeViewList();
  }
}
