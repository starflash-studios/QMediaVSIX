// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Peers.AutomationControlType
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Automation.Peers
{
  /// <summary>Specifies the control type that is exposed to the Microsoft UI Automation client. Used by GetAutomationControlType.</summary>
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum AutomationControlType
  {
    /// <summary>A button control.</summary>
    Button,
    /// <summary>A calendar control, such as a date picker.</summary>
    Calendar,
    /// <summary>A check box control.</summary>
    CheckBox,
    /// <summary>A combo box control.</summary>
    ComboBox,
    /// <summary>An edit control, such as a text box.</summary>
    Edit,
    /// <summary>A hyperlink control.</summary>
    Hyperlink,
    /// <summary>An image control.</summary>
    Image,
    /// <summary>A list item control, which is a child item of a list control.</summary>
    ListItem,
    /// <summary>A list control, such as a list box.</summary>
    List,
    /// <summary>A menu control, such as a top-level menu in an application window.</summary>
    Menu,
    /// <summary>A menu bar control, which generally contains a set of top-level menus.</summary>
    MenuBar,
    /// <summary>A menu item control.</summary>
    MenuItem,
    /// <summary>A progress bar control, which visually indicates the progress of a lengthy operation.</summary>
    ProgressBar,
    /// <summary>A radio button control, which is a selection mechanism allowing exactly one selected item in a group.</summary>
    RadioButton,
    /// <summary>A scroll bar control, such as a scroll bar in an application window.</summary>
    ScrollBar,
    /// <summary>A slider control.</summary>
    Slider,
    /// <summary>A spinner control.</summary>
    Spinner,
    /// <summary>A status bar control.</summary>
    StatusBar,
    /// <summary>A tab control.</summary>
    Tab,
    /// <summary>A tab item control, which represents a page of a tab control.</summary>
    TabItem,
    /// <summary>An edit control, such as a text box or rich text box.</summary>
    Text,
    /// <summary>A toolbar, such as the control that contains a set of command buttons in an application window.</summary>
    ToolBar,
    /// <summary>A tooltip control, an informational window that appears as a result of moving the pointer over a control or sometimes when tabbing to a control using the keyboard.</summary>
    ToolTip,
    /// <summary>A tree control.</summary>
    Tree,
    /// <summary>A node in a tree control.</summary>
    TreeItem,
    /// <summary>A control that is not one of the defined control types.</summary>
    Custom,
    /// <summary>A group control, which acts as a container for other controls.</summary>
    Group,
    /// <summary>The control in a scrollbar that can be dragged to a different position.</summary>
    Thumb,
    /// <summary>A data grid control.</summary>
    DataGrid,
    /// <summary>A data item control.</summary>
    DataItem,
    /// <summary>A document control.</summary>
    Document,
    /// <summary>A split button, which is a button that performs a default action and can also expand to a list of other possible actions.</summary>
    SplitButton,
    /// <summary>A window frame, which contains child objects.</summary>
    Window,
    /// <summary>A pane control.</summary>
    Pane,
    /// <summary>A header control, which is a container for the labels of rows and columns of information.</summary>
    Header,
    /// <summary>A header item, which is the label for a row or column of information.</summary>
    HeaderItem,
    /// <summary>A table.</summary>
    Table,
    /// <summary>The caption bar on a window.</summary>
    TitleBar,
    /// <summary>A separator, which creates a visual division in controls such as menus and toolbars.</summary>
    Separator,
    /// <summary>A semantic zoom control.</summary>
    SemanticZoom,
    /// <summary>**Introduced in .** An app bar control (AppBar ).</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] AppBar,
  }
}
