// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.PasswordBox
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Represents a control for entering passwords.</summary>
  [Static(typeof (IPasswordBoxStatics5), 458752, "Windows.Foundation.UniversalApiContract")]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [Static(typeof (IPasswordBoxStatics2), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Static(typeof (IPasswordBoxStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IPasswordBoxStatics3), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class PasswordBox : 
    Control,
    IPasswordBox,
    IPasswordBox2,
    IPasswordBox3,
    IPasswordBox4,
    IPasswordBox5
  {
    /// <summary>Initializes a new instance of the PasswordBox class</summary>
    [MethodImpl]
    public extern PasswordBox();

    /// <summary>Gets or sets the password currently held by the PasswordBox.</summary>
    /// <returns>A string that represents the password currently held by the PasswordBox. The default is an empty string.</returns>
    public extern string Password { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the masking character for the PasswordBox.</summary>
    /// <returns>A masking character to echo when the user enters text into the PasswordBox. The default value is a bullet character (●).</returns>
    public extern string PasswordChar { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that specifies whether the visual UI of the PasswordBox includes a button element that toggles showing or hiding the typed characters. In Windows 10 and later, use PasswordRevealMode instead.</summary>
    /// <returns>**True** to show a password reveal button; **false** to not show a password reveal button. The default is **false**.</returns>
    public extern bool IsPasswordRevealButtonEnabled { [Deprecated("IsPasswordRevealButtonEnabledProperty may be altered or unavailable for releases after Windows 10.0. Instead, use PasswordRevealModeProperty.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; [Deprecated("IsPasswordRevealButtonEnabledProperty may be altered or unavailable for releases after Windows 10.0. Instead, use PasswordRevealModeProperty.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract"), MethodImpl] set; }

    /// <summary>Gets or sets the maximum length for passwords to be handled by this PasswordBox.</summary>
    /// <returns>An integer that specifies the maximum number of characters for passwords to be handled by this PasswordBox. A value of zero (0) means no limit. The default is 0 (no length limit).</returns>
    public extern int MaxLength { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Occurs when the value of the Password property changes.</summary>
    public extern event RoutedEventHandler PasswordChanged;

    /// <summary>Occurs when the system processes an interaction that displays a context menu.</summary>
    public extern event ContextMenuOpeningEventHandler ContextMenuOpening;

    /// <summary>Selects all the characters in the PasswordBox.</summary>
    [MethodImpl]
    public extern void SelectAll();

    /// <summary>Gets or sets the content for the control's header.</summary>
    /// <returns>The content of the control's header. The default is **null**.</returns>
    public extern object Header { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the DataTemplate used to display the content of the control's header.</summary>
    /// <returns>The template that specifies the visualization of the header object. The default is **null**.</returns>
    public extern DataTemplate HeaderTemplate { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the text that is displayed in the control until the value is changed by a user action or some other operation.</summary>
    /// <returns>The text that is displayed in the control when no value is entered. The default is an empty string ("").</returns>
    public extern string PlaceholderText { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the brush used to highlight the selected text.</summary>
    /// <returns>The brush used to highlight the selected text. The default is a null brush from a pure code perspective, but the default control template for PasswordBox applies a theme resource brush for this in a runtime instance of a PasswordBox control.</returns>
    public extern SolidColorBrush SelectionHighlightColor { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates whether the on-screen keyboard is shown when the control receives focus programmatically.</summary>
    /// <returns>**true** if the on-screen keyboard is not shown when the control receives focus programmatically; otherwise, **false**. The default is **false**.</returns>
    public extern bool PreventKeyboardDisplayOnProgrammaticFocus { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Occurs when text is pasted into the control.</summary>
    public extern event TextControlPasteEventHandler Paste;

    /// <summary>Gets or sets a value that specifies whether the password is always, never, or optionally obscured.</summary>
    /// <returns>A value of the enumeration that specifies whether the password is always, never, or optionally obscured. The default is **Peek**.</returns>
    public extern PasswordRevealMode PasswordRevealMode { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates how the reading order is determined for the PasswordBox.</summary>
    /// <returns>A value that indicates how the reading order is determined for the PasswordBox. The default is **DetectFromContent**.</returns>
    public extern TextReadingOrder TextReadingOrder { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the context for input used by this PasswordBox.</summary>
    /// <returns>The input scope, which provides a hint at the type of text input expected by the control. The default is **null**.</returns>
    public extern InputScope InputScope { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Occurs synchronously when the text in the password box starts to change, but before it is rendered.</summary>
    public extern event TypedEventHandler<PasswordBox, PasswordBoxPasswordChangingEventArgs> PasswordChanging;

    /// <summary>Gets a value that indicates whether clipboard content can be pasted into the control.</summary>
    /// <returns>**true** if clipboard content can be pasted into the control; otherwise, **false**.</returns>
    public extern bool CanPasteClipboardContent { [MethodImpl] get; }

    /// <summary>Gets or sets the flyout that is shown when text is selected, or **null** if no flyout is shown.</summary>
    /// <returns>The flyout that is shown when text is selected, or **null** if no flyout is shown. The default is an instance of TextCommandBarFlyout.</returns>
    public extern FlyoutBase SelectionFlyout { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets content that is shown below the control. The content should provide guidance about the input expected by the control.</summary>
    /// <returns>The content to be displayed below the control. The default is **null**.</returns>
    public extern object Description { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Copies content from the Windows clipboard into the text control.</summary>
    [MethodImpl]
    public extern void PasteFromClipboard();

    /// <summary>Identifies the CanPasteClipboardContent dependency property.</summary>
    /// <returns>The identifier for the CanPasteClipboardContent dependency property.</returns>
    public static extern DependencyProperty CanPasteClipboardContentProperty { [MethodImpl] get; }

    /// <summary>Identifies the SelectionFlyout dependency property.</summary>
    /// <returns>The identifier for the SelectionFlyout dependency property.</returns>
    public static extern DependencyProperty SelectionFlyoutProperty { [MethodImpl] get; }

    /// <summary>Identifies the Description dependency property.</summary>
    /// <returns>The identifier for the Description dependency property.</returns>
    public static extern DependencyProperty DescriptionProperty { [MethodImpl] get; }

    /// <summary>Identifies the PasswordRevealMode dependency property.</summary>
    /// <returns>The identifier for the PasswordRevealMode dependency property.</returns>
    public static extern DependencyProperty PasswordRevealModeProperty { [MethodImpl] get; }

    /// <summary>Identifies the TextReadingOrder dependency property.</summary>
    /// <returns>The identifier for the TextReadingOrder dependency property.</returns>
    public static extern DependencyProperty TextReadingOrderProperty { [MethodImpl] get; }

    /// <summary>Identifies the InputScope dependency property.</summary>
    /// <returns>The identifier for the InputScope dependency property.</returns>
    public static extern DependencyProperty InputScopeProperty { [MethodImpl] get; }

    /// <summary>Identifies the Header dependency property.</summary>
    /// <returns>The identifier for the Header dependency property.</returns>
    public static extern DependencyProperty HeaderProperty { [MethodImpl] get; }

    /// <summary>Identifies the HeaderTemplate dependency property.</summary>
    /// <returns>The identifier for the HeaderTemplate dependency property.</returns>
    public static extern DependencyProperty HeaderTemplateProperty { [MethodImpl] get; }

    /// <summary>Identifies the PlaceholderText dependency property.</summary>
    /// <returns>The identifier for the PlaceholderText dependency property.</returns>
    public static extern DependencyProperty PlaceholderTextProperty { [MethodImpl] get; }

    /// <summary>Identifies the SelectionHighlightColor dependency property.</summary>
    /// <returns>The identifier for the SelectionHighlightColor dependency property.</returns>
    public static extern DependencyProperty SelectionHighlightColorProperty { [MethodImpl] get; }

    /// <summary>Identifies the PreventKeyboardDisplayOnProgrammaticFocus dependency property.</summary>
    /// <returns>The identifier for the PreventKeyboardDisplayOnProgrammaticFocus dependency property.</returns>
    public static extern DependencyProperty PreventKeyboardDisplayOnProgrammaticFocusProperty { [MethodImpl] get; }

    /// <summary>Identifies the Password dependency property.</summary>
    /// <returns>The identifier for the Password dependency property.</returns>
    public static extern DependencyProperty PasswordProperty { [MethodImpl] get; }

    /// <summary>Identifies the PasswordChar dependency property.</summary>
    /// <returns>The identifier for the PasswordChar dependency property.</returns>
    public static extern DependencyProperty PasswordCharProperty { [MethodImpl] get; }

    /// <summary>Identifies the IsPasswordRevealButtonEnabled dependency property.</summary>
    /// <returns>The identifier for the IsPasswordRevealButtonEnabled dependency property.</returns>
    public static extern DependencyProperty IsPasswordRevealButtonEnabledProperty { [Deprecated("IsPasswordRevealButtonEnabledProperty may be altered or unavailable for releases after Windows 10.0. Instead, use PasswordRevealModeProperty.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>Identifies the MaxLength dependency property.</summary>
    /// <returns>The identifier for the MaxLength dependency property.</returns>
    public static extern DependencyProperty MaxLengthProperty { [MethodImpl] get; }
  }
}
