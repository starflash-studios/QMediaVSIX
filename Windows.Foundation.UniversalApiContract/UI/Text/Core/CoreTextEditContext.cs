// Decompiled with JetBrains decompiler
// Type: Windows.UI.Text.Core.CoreTextEditContext
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Text.Core
{
  /// <summary>The primary object used by text input controls to communicate with the text input server.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class CoreTextEditContext : ICoreTextEditContext, ICoreTextEditContext2
  {
    /// <summary>Gets or sets a descriptive name for the text input control. An application framework usually uses properties such as "name" or "id" to identify a control, so it’s recommended that you set this property accordingly on the text input server so that input processors can better preserve the input context, and provide better suggestions.</summary>
    /// <returns>A string containing a descriptive name for the text input control.</returns>
    public extern string Name { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates the input scope of the text input control.</summary>
    /// <returns>One of the CoreTextInputScope enumeration values. The default is **Default**.</returns>
    public extern CoreTextInputScope InputScope { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates whether the edit control is editable.</summary>
    /// <returns>**true** if the text input control is read-only; otherwise, **false**. The default is **false**.</returns>
    public extern bool IsReadOnly { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates whether the input pane should be shown automatically when focus enters your text input control. The default value is **Automatic**, indicating that the input pane will be shown automatically. A value of **Manual** indicates that your app will be responsible for showing and hiding the input pane using InputPane.TryShow and TryHide.</summary>
    /// <returns>One of the CoreTextInputPaneDisplayPolicy enumeration values. The default is **Automatic**.</returns>
    public extern CoreTextInputPaneDisplayPolicy InputPaneDisplayPolicy { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Occurs when the text input server needs to get a range of text from the text input control. The application should handle this event and return the range requested.</summary>
    public extern event TypedEventHandler<CoreTextEditContext, CoreTextTextRequestedEventArgs> TextRequested;

    /// <summary>Occurs when the text input server needs to get the text range representing the currently selected text in the text input control. The application should handle this event and return the range requested.</summary>
    public extern event TypedEventHandler<CoreTextEditContext, CoreTextSelectionRequestedEventArgs> SelectionRequested;

    /// <summary>Occurs when the text input server needs to get the bounding box of a range of text and of the text input control itself. The application should handle this event and return the geometry information requested.</summary>
    public extern event TypedEventHandler<CoreTextEditContext, CoreTextLayoutRequestedEventArgs> LayoutRequested;

    /// <summary>Occurs when the text input server needs to modify text inside the text input control. This event could be the result of a key event— such as inserting a single character— or the result of processing done by an input processor, such as auto-correction and prediction.</summary>
    public extern event TypedEventHandler<CoreTextEditContext, CoreTextTextUpdatingEventArgs> TextUpdating;

    /// <summary>Occurs when the text input server needs to modify the range of text currently selected in the text input control. This event could be the result of an input processor needing to select some text, or to move the caret. The text input control should set its selection range accordingly.</summary>
    public extern event TypedEventHandler<CoreTextEditContext, CoreTextSelectionUpdatingEventArgs> SelectionUpdating;

    /// <summary>Occurs when the text input server needs to apply a different format to a particular range of text. This usually happens during composition.</summary>
    public extern event TypedEventHandler<CoreTextEditContext, CoreTextFormatUpdatingEventArgs> FormatUpdating;

    /// <summary>Occurs when composition has started.</summary>
    public extern event TypedEventHandler<CoreTextEditContext, CoreTextCompositionStartedEventArgs> CompositionStarted;

    /// <summary>Occurs when composition has completed.</summary>
    public extern event TypedEventHandler<CoreTextEditContext, CoreTextCompositionCompletedEventArgs> CompositionCompleted;

    /// <summary>Occurs when focus was forcibly removed from a text input control. The application should handle this event to remove focus for the text input control accordingly.</summary>
    public extern event TypedEventHandler<CoreTextEditContext, object> FocusRemoved;

    /// <summary>Notifies the text input server that focus has entered the text input control.</summary>
    [MethodImpl]
    public extern void NotifyFocusEnter();

    /// <summary>Notifies the text input server that focus has left the text input control.</summary>
    [MethodImpl]
    public extern void NotifyFocusLeave();

    /// <summary>Notifies the text input server about any change that the text input control needs to make to the text. This is important in order to keep the internal state of the control and the internal state of the server synchronized. Since a change to the text is also likely to affect the selection range, the method takes the selection range as a parameter.</summary>
    /// <param name="modifiedRange">The range of text to replace, in terms of the state the text buffer is in prior to this text change.</param>
    /// <param name="newLength">The length of the text that should replace *modifiedRange*.</param>
    /// <param name="newSelection">The range of selection in effect after the text change.</param>
    [MethodImpl]
    public extern void NotifyTextChanged(
      CoreTextRange modifiedRange,
      int newLength,
      CoreTextRange newSelection);

    /// <summary>Notifies the text input server about any change that the text input control needs to make to the selection range. This is important in order to keep the internal state of the control and the internal state of the server synchronized.</summary>
    /// <param name="selection">The range of selection currently in effect.</param>
    [MethodImpl]
    public extern void NotifySelectionChanged(CoreTextRange selection);

    /// <summary>Notifies the text input server that the layout of text inside the text input control has changed.</summary>
    [MethodImpl]
    public extern void NotifyLayoutChanged();

    /// <summary>Occurs after focus has left the text input control.</summary>
    public extern event TypedEventHandler<CoreTextEditContext, object> NotifyFocusLeaveCompleted;
  }
}
