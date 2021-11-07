// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ITreeViewNode
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [Guid(3226242771, 39666, 20085, 163, 41, 116, 151, 161, 16, 231, 168)]
  [ExclusiveTo(typeof (TreeViewNode))]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  internal interface ITreeViewNode
  {
    object Content { get; set; }

    TreeViewNode Parent { get; }

    bool IsExpanded { get; set; }

    bool HasChildren { get; }

    int Depth { get; }

    bool HasUnrealizedChildren { get; set; }

    IVector<TreeViewNode> Children { get; }
  }
}
