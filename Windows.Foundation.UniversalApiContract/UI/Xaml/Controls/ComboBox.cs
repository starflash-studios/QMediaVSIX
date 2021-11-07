// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ComboBox
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Media;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Represents a selection control that combines a non-editable text box and a drop-down list box that allows users to select an item from a list.</summary>
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IComboBoxStatics2), 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IComboBoxStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IComboBoxStatics6), 458752, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IComboBoxStatics3), 196608, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Composable(typeof (IComboBoxFactory), CompositionType.Public, 65536, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [Static(typeof (IComboBoxStatics5), 327680, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IComboBoxStatics4), 262144, "Windows.Foundation.UniversalApiContract")]
  public class ComboBox : 
    Selector,
    IComboBox,
    IComboBox2,
    IComboBox3,
    IComboBox4,
    IComboBox5,
    IComboBox6,
    IComboBoxOverrides
  {
    /// <summary>Initializes a new instance of the ComboBox class.</summary>
    [MethodImpl]
    public extern ComboBox();

    /// <summary>Gets or sets a value that indicates whether the drop-down portion of the ComboBox is currently open.</summary>
    /// <returns>**True** if the drop-down portion is open; otherwise, **false**. The default is **false**.</returns>
    public extern bool IsDropDownOpen { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates whether the user can edit text in the text box portion of the ComboBox. See remarks.</summary>
    /// <returns>**true** if the user can edit text in the ComboBox, otherwise **false**. The default is **false**. See remarks.</returns>
    public extern bool IsEditable { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets a value that indicates whether the SelectionBoxItem component is highlighted.</summary>
    /// <returns>**True** if the SelectionBoxItem is highlighted; otherwise, **false**. The default is **true**.</returns>
    public extern bool IsSelectionBoxHighlighted { [MethodImpl] get; }

    /// <summary>Gets or sets the maximum height for a combo box drop-down.</summary>
    /// <returns>The maximum height of the drop-down. The default is infinity.</returns>
    public extern double MaxDropDownHeight { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the item shown when the ComboBox is closed.</summary>
    /// <returns>The item shown when the ComboBox is closed.</returns>
    public extern object SelectionBoxItem { [MethodImpl] get; }

    /// <summary>Gets the template applied to the selection box content.</summary>
    /// <returns>The template applied to the selection box content.</returns>
    public extern DataTemplate SelectionBoxItemTemplate { [MethodImpl] get; }

    /// <summary>Gets an object that provides calculated values that can be referenced as **TemplateBinding** sources when defining templates for a ComboBox control.</summary>
    /// <returns>An object that provides calculated values for templates.</returns>
    public extern ComboBoxTemplateSettings TemplateSettings { [MethodImpl] get; }

    /// <summary>Occurs when the drop-down portion of the ComboBox closes.</summary>
    public extern event EventHandler<object> DropDownClosed;

    /// <summary>Occurs when the drop-down portion of the ComboBox opens.</summary>
    public extern event EventHandler<object> DropDownOpened;

    /// <summary>Gets or sets the content for the control's header.</summary>
    /// <returns>The content of the control's header. The default is **null**.</returns>
    public extern object Header { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the DataTemplate used to display the content of the control's header.</summary>
    /// <returns>The template that specifies the visualization of the header object. The default is **null**.</returns>
    public extern DataTemplate HeaderTemplate { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the text that is displayed in the control until the value is changed by a user action or some other operation.</summary>
    /// <returns>The text that is displayed in the control when no value is selected. The default is an empty string ("").</returns>
    public extern string PlaceholderText { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that specifies whether the area outside of a *light-dismiss* UI is darkened.</summary>
    /// <returns>A value of the enumeration that specifies whether the area outside of a light-dismiss UI is darkened. The default is **Auto**.</returns>
    public extern LightDismissOverlayMode LightDismissOverlayMode { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that specifies whether a user can jump to a value by typing.</summary>
    /// <returns>**true** if a user can jump to a value by typing; otherwise, **false**. The default is **true**.</returns>
    public extern bool IsTextSearchEnabled { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates what action causes a SelectionChanged event to occur.</summary>
    /// <returns>A value of the enumeration. The default is **Committed**.</returns>
    public extern ComboBoxSelectionChangedTrigger SelectionChangedTrigger { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a brush that describes the color of placeholder text.</summary>
    /// <returns>The brush that describes the color of placeholder text.</returns>
    public extern Brush PlaceholderForeground { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the text in the ComboBox.</summary>
    /// <returns>
    /// </returns>
    public extern string Text { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the style of the TextBox in the ComboBox when the ComboBox is editable.</summary>
    /// <returns>The style of the TextBox in the ComboBox when the ComboBox is editable.</returns>
    public extern Style TextBoxStyle { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets content that is shown below the control. The content should provide guidance about the input expected by the control.</summary>
    /// <returns>The content to be displayed below the control. The default is **null**.</returns>
    public extern object Description { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Occurs when the user submits some text that does not correspond to an item in the ComboBox dropdown list.</summary>
    public extern event TypedEventHandler<ComboBox, ComboBoxTextSubmittedEventArgs> TextSubmitted;

    [MethodImpl]
    extern void IComboBoxOverrides.OnDropDownClosed(object e);

    [MethodImpl]
    extern void IComboBoxOverrides.OnDropDownOpened(object e);

    /// <summary>Identifies the IsEditable dependency property.</summary>
    /// <returns>The identifier for the IsEditable dependency property.</returns>
    public static extern DependencyProperty IsEditableProperty { [MethodImpl] get; }

    /// <summary>Identifies the Text dependency property.</summary>
    /// <returns>The identifier for the Text dependency property.</returns>
    public static extern DependencyProperty TextProperty { [MethodImpl] get; }

    /// <summary>Identifies the TextBoxStyle dependency property.</summary>
    /// <returns>The identifier for the TextBoxStyle dependency property.</returns>
    public static extern DependencyProperty TextBoxStyleProperty { [MethodImpl] get; }

    /// <summary>Identifies the Description dependency property.</summary>
    /// <returns>The identifier for the Description dependency property.</returns>
    public static extern DependencyProperty DescriptionProperty { [MethodImpl] get; }

    /// <summary>Identifies the PlaceholderForeground dependency property.</summary>
    /// <returns>The identifier for the PlaceholderForeground dependency property.</returns>
    public static extern DependencyProperty PlaceholderForegroundProperty { [MethodImpl] get; }

    /// <summary>Identifies the SelectionChangedTrigger dependency property.</summary>
    /// <returns>The identifier for the **SelectionChangedTrigger** dependency property.</returns>
    public static extern DependencyProperty SelectionChangedTriggerProperty { [MethodImpl] get; }

    /// <summary>Identifies the LightDismissOverlayMode dependency property.</summary>
    /// <returns>The identifier for the LightDismissOverlayMode dependency property.</returns>
    public static extern DependencyProperty LightDismissOverlayModeProperty { [MethodImpl] get; }

    /// <summary>Identifies the IsTextSearchEnabled dependency property.</summary>
    /// <returns>The identifier for the IsTextSearchEnabled dependency property.</returns>
    public static extern DependencyProperty IsTextSearchEnabledProperty { [MethodImpl] get; }

    /// <summary>Identifies the Header dependency property.</summary>
    /// <returns>The identifier for the Header dependency property.</returns>
    public static extern DependencyProperty HeaderProperty { [MethodImpl] get; }

    /// <summary>Identifies the HeaderTemplate dependency property.</summary>
    /// <returns>The identifier for the HeaderTemplate dependency property.</returns>
    public static extern DependencyProperty HeaderTemplateProperty { [MethodImpl] get; }

    /// <summary>Identifies the PlaceholderText dependency property.</summary>
    /// <returns>The identifier for the PlaceholderText dependency property.</returns>
    public static extern DependencyProperty PlaceholderTextProperty { [MethodImpl] get; }

    /// <summary>Identifies the IsDropDownOpen dependency property.</summary>
    /// <returns>The identifier for the IsDropDownOpen dependency property.</returns>
    public static extern DependencyProperty IsDropDownOpenProperty { [MethodImpl] get; }

    /// <summary>Identifies the MaxDropDownHeight dependency property.</summary>
    /// <returns>The identifier for the MaxDropDownHeight dependency property.</returns>
    public static extern DependencyProperty MaxDropDownHeightProperty { [MethodImpl] get; }
  }
}
