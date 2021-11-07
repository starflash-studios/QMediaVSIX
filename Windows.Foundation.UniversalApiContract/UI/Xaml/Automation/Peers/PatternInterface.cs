// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Peers.PatternInterface
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Automation.Peers
{
  /// <summary>Specifies the control pattern that the GetPattern method returns.</summary>
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum PatternInterface
  {
    /// <summary>The IInvokeProvider control pattern interface.</summary>
    Invoke,
    /// <summary>The ISelectionProvider control pattern interface.</summary>
    Selection,
    /// <summary>The IValueProvider control pattern interface.</summary>
    Value,
    /// <summary>The IRangeValueProvider control pattern interface.</summary>
    RangeValue,
    /// <summary>The IScrollProvider control pattern interface.</summary>
    Scroll,
    /// <summary>The IScrollItemProvider control pattern interface.</summary>
    ScrollItem,
    /// <summary>The IExpandCollapseProvider control pattern interface.</summary>
    ExpandCollapse,
    /// <summary>The IGridProvider control pattern interface.</summary>
    Grid,
    /// <summary>The IGridItemProvider control pattern interface.</summary>
    GridItem,
    /// <summary>The IMultipleViewProvider control pattern interface.</summary>
    MultipleView,
    /// <summary>The IWindowProvider control pattern interface.</summary>
    Window,
    /// <summary>The ISelectionItemProvider control pattern interface.</summary>
    SelectionItem,
    /// <summary>The IDockProvider control pattern interface.</summary>
    Dock,
    /// <summary>The ITableProvider control pattern interface.</summary>
    Table,
    /// <summary>The ITableItemProvider control pattern interface.</summary>
    TableItem,
    /// <summary>The IToggleProvider control pattern interface.</summary>
    Toggle,
    /// <summary>The ITransformProvider control pattern interface.</summary>
    Transform,
    /// <summary>The ITextProvider control pattern interface.</summary>
    Text,
    /// <summary>The IItemContainerProvider control pattern interface.</summary>
    ItemContainer,
    /// <summary>The IVirtualizedItemProvider control pattern interface.</summary>
    VirtualizedItem,
    /// <summary>The ITextProvider2 interface.</summary>
    Text2,
    /// <summary>The ITextChildProvider interface.</summary>
    TextChild,
    /// <summary>The ITextRangeProvider interface.</summary>
    TextRange,
    /// <summary>The IAnnotationProvider interface.</summary>
    Annotation,
    /// <summary>The IDragProvider interface.</summary>
    Drag,
    /// <summary>The IDropTargetProvider interface.</summary>
    DropTarget,
    /// <summary>**Introduced in .** The IObjectModelProvider interface.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] ObjectModel,
    /// <summary>**Introduced in .** The ISpreadsheetProvider  interface.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] Spreadsheet,
    /// <summary>**Introduced in .** The ISpreadsheetItemProvider interface.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] SpreadsheetItem,
    /// <summary>**Introduced in .** The IStylesProvider interface.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] Styles,
    /// <summary>**Introduced in .** The ITransformProvider2 interface.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] Transform2,
    /// <summary>**Introduced in .** The ISynchronizedInputProvider interface.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] SynchronizedInput,
    /// <summary>The TextEdit control pattern interface.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] TextEdit,
    /// <summary>The CustomNavigation control pattern interface.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] CustomNavigation,
  }
}
