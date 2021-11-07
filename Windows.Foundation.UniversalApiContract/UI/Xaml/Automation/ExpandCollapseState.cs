// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.ExpandCollapseState
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Automation
{
  /// <summary>Contains values that specify the ExpandCollapseState automation property value of a UI Automation element.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  public enum ExpandCollapseState
  {
    /// <summary>No child nodes, controls, or content of the UI Automation element are displayed.</summary>
    Collapsed,
    /// <summary>All child nodes, controls, and content of the UI Automation element are displayed.</summary>
    Expanded,
    /// <summary>Some, but not all, child nodes, controls, or content of the UI Automation element are displayed.</summary>
    PartiallyExpanded,
    /// <summary>The UI Automation element has no child nodes, controls, or content to display.</summary>
    LeafNode,
  }
}
