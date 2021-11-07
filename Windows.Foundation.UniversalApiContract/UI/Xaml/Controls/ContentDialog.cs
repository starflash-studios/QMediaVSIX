// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ContentDialog
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Input;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Represents a dialog box that can be customized to contain checkboxes, hyperlinks, buttons and any other XAML content.</summary>
  [Composable(typeof (IContentDialogFactory), CompositionType.Public, 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Threading(ThreadingModel.Both)]
  [Static(typeof (IContentDialogStatics2), 262144, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IContentDialogStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  public class ContentDialog : ContentControl, IContentDialog, IContentDialog2, IContentDialog3
  {
    /// <summary>Initializes a new instance of the ContentDialog class.</summary>
    [MethodImpl]
    public extern ContentDialog();

    /// <summary>Gets or sets the title of the dialog.</summary>
    /// <returns>The title of the dialog.</returns>
    public extern object Title { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the title template.</summary>
    /// <returns>The title template.</returns>
    public extern DataTemplate TitleTemplate { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates whether a request is being made to display the dialog full screen.</summary>
    /// <returns>**true** to request that the dialog is displayed full screen; otherwise, **false**. The default is **false**.</returns>
    public extern bool FullSizeDesired { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the text to display on the primary button.</summary>
    /// <returns>The text to display on the primary button. To hide this button, set the text to **null** or string.empty. The default is empty.</returns>
    public extern string PrimaryButtonText { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the text to be displayed on the secondary button.</summary>
    /// <returns>The text to be displayed on the secondary button. To hide this button, set the value to **null** or **string.empty**.</returns>
    public extern string SecondaryButtonText { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the command to invoke when the primary button is tapped.</summary>
    /// <returns>The command to invoke when the primary button is tapped.</returns>
    public extern ICommand PrimaryButtonCommand { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the command to invoke when the secondary button is tapped.</summary>
    /// <returns>The command to invoke when the secondary button is tapped.</returns>
    public extern ICommand SecondaryButtonCommand { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the parameter to pass to the command for the primary button.</summary>
    /// <returns>The parameter to pass to the command for the primary button. The default is null.</returns>
    public extern object PrimaryButtonCommandParameter { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the parameter to pass to the command for the secondary button.</summary>
    /// <returns>The command parameter for the secondary button. The default is null.</returns>
    public extern object SecondaryButtonCommandParameter { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets whether the dialog's primary button is enabled.</summary>
    /// <returns>True if the primary button of the dialog is enabled; Otherwise, false.</returns>
    public extern bool IsPrimaryButtonEnabled { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets whether the dialog's secondary button is enabled.</summary>
    /// <returns>True if the secondary button of the dialog is enabled; Otherwise, false.</returns>
    public extern bool IsSecondaryButtonEnabled { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Occurs after the dialog starts to close, but before it is closed and before the Closed event occurs.</summary>
    public extern event TypedEventHandler<ContentDialog, ContentDialogClosingEventArgs> Closing;

    /// <summary>Occurs after the dialog is closed.</summary>
    public extern event TypedEventHandler<ContentDialog, ContentDialogClosedEventArgs> Closed;

    /// <summary>Occurs after the dialog is opened.</summary>
    public extern event TypedEventHandler<ContentDialog, ContentDialogOpenedEventArgs> Opened;

    /// <summary>Occurs after the primary button has been tapped.</summary>
    public extern event TypedEventHandler<ContentDialog, ContentDialogButtonClickEventArgs> PrimaryButtonClick;

    /// <summary>Occurs after the secondary button has been tapped.</summary>
    public extern event TypedEventHandler<ContentDialog, ContentDialogButtonClickEventArgs> SecondaryButtonClick;

    /// <summary>Hides the dialog.</summary>
    [MethodImpl]
    public extern void Hide();

    /// <summary>Begins an asynchronous operation to show the dialog.</summary>
    /// <returns>An asynchronous operation showing the dialog. When complete, returns a ContentDialogResult.</returns>
    [Overload("ShowAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<ContentDialogResult> ShowAsync();

    /// <summary>Gets or sets the text to display on the close button.</summary>
    /// <returns>The text to display on the close button.</returns>
    public extern string CloseButtonText { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the command to invoke when the close button is tapped.</summary>
    /// <returns>The command to invoke when the primary button is tapped.</returns>
    public extern ICommand CloseButtonCommand { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the parameter to pass to the command for the close button.</summary>
    /// <returns>The parameter to pass to the command for the close button. The default is **null.**</returns>
    public extern object CloseButtonCommandParameter { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the Style to apply to the dialog's primary button.</summary>
    /// <returns>The applied style for the button, if present; otherwise, **null**.</returns>
    public extern Style PrimaryButtonStyle { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the Style to apply to the dialog's secondary button.</summary>
    /// <returns>The applied style for the button, if present; otherwise, **null**.</returns>
    public extern Style SecondaryButtonStyle { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the Style to apply to the dialog's close button.</summary>
    /// <returns>The applied style for the button, if present; otherwise, **null**.</returns>
    public extern Style CloseButtonStyle { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates which button on the dialog is the default action.</summary>
    /// <returns>A value of the enumeration. The default is **None.**</returns>
    public extern ContentDialogButton DefaultButton { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Occurs after the close button has been tapped.</summary>
    public extern event TypedEventHandler<ContentDialog, ContentDialogButtonClickEventArgs> CloseButtonClick;

    /// <summary>Begins an asynchronous operation to show the dialog with the specified placement.</summary>
    /// <param name="placement">A value that specifies whether the dialog is placed in the PopupRoot or in its parent's visual tree.</param>
    /// <returns>An asynchronous operation showing the dialog. When complete, returns a ContentDialogResult.</returns>
    [RemoteAsync]
    [Overload("ShowAsyncWithPlacement")]
    [MethodImpl]
    public extern IAsyncOperation<ContentDialogResult> ShowAsync(
      ContentDialogPlacement placement);

    /// <summary>Gets the identifier of the CloseButtonText dependency property.</summary>
    /// <returns>The identifier of the CloseButtonText dependency property.</returns>
    public static extern DependencyProperty CloseButtonTextProperty { [MethodImpl] get; }

    /// <summary>Gets the identifier of the CloseButtonCommand dependency property.</summary>
    /// <returns>The identifier of the CloseButtonCommand dependency property.</returns>
    public static extern DependencyProperty CloseButtonCommandProperty { [MethodImpl] get; }

    /// <summary>Gets the identifier of the CloseButtonCommandParameter dependency property.</summary>
    /// <returns>The identifier of the CloseButtonCommandParameter dependency property.</returns>
    public static extern DependencyProperty CloseButtonCommandParameterProperty { [MethodImpl] get; }

    /// <summary>Gets the identifier of the PrimaryButtonStyle dependency property.</summary>
    /// <returns>The identifier of the PrimaryButtonStyle dependency property.</returns>
    public static extern DependencyProperty PrimaryButtonStyleProperty { [MethodImpl] get; }

    /// <summary>Gets the identifier of the SecondaryButtonStyle dependency property.</summary>
    /// <returns>The identifier of the SecondaryButtonStyle dependency property.</returns>
    public static extern DependencyProperty SecondaryButtonStyleProperty { [MethodImpl] get; }

    /// <summary>Gets the identifier of the CloseButtonStyle dependency property.</summary>
    /// <returns>The identifier of the CloseButtonStyle dependency property.</returns>
    public static extern DependencyProperty CloseButtonStyleProperty { [MethodImpl] get; }

    /// <summary>Gets the identifier of the DefaultButton dependency property.</summary>
    /// <returns>The identifier of the DefaultButton dependency property.</returns>
    public static extern DependencyProperty DefaultButtonProperty { [MethodImpl] get; }

    /// <summary>Gets the identifier of the Title dependency property.</summary>
    /// <returns>The identifier of the Title dependency property.</returns>
    public static extern DependencyProperty TitleProperty { [MethodImpl] get; }

    /// <summary>Gets the identifier of the TitleTemplate dependency property.</summary>
    /// <returns>The identifier of the TitleTemplate dependency property.</returns>
    public static extern DependencyProperty TitleTemplateProperty { [MethodImpl] get; }

    /// <summary>Gets the identifier of the FullSizeDesired dependency property.</summary>
    /// <returns>The identifier of the FullSizeDesired dependency property.</returns>
    public static extern DependencyProperty FullSizeDesiredProperty { [MethodImpl] get; }

    /// <summary>Gets the identifier of the PrimaryButtonText dependency property.</summary>
    /// <returns>The identifier of the PrimaryButtonText dependency property.</returns>
    public static extern DependencyProperty PrimaryButtonTextProperty { [MethodImpl] get; }

    /// <summary>Gets the identifier of the SecondaryButtonText dependency property.</summary>
    /// <returns>The identifier of the SecondaryButtonText dependency property.</returns>
    public static extern DependencyProperty SecondaryButtonTextProperty { [MethodImpl] get; }

    /// <summary>Gets the identifier of the PrimaryButtonCommand dependency property.</summary>
    /// <returns>The identifier of the PrimaryButtonCommand dependency property.</returns>
    public static extern DependencyProperty PrimaryButtonCommandProperty { [MethodImpl] get; }

    /// <summary>Gets the identifier of the SecondaryButtonCommand dependency property.</summary>
    /// <returns>The identifier of the SecondaryButtonCommand dependency property.</returns>
    public static extern DependencyProperty SecondaryButtonCommandProperty { [MethodImpl] get; }

    /// <summary>Gets the identifier of the PrimaryButtonCommandParameter dependency property.</summary>
    /// <returns>The identifier of the PrimaryButtonCommandParameter dependency property</returns>
    public static extern DependencyProperty PrimaryButtonCommandParameterProperty { [MethodImpl] get; }

    /// <summary>Gets the identifier of the SecondaryButtonCommandParameter dependency property.</summary>
    /// <returns>The identifier of the SecondaryButtonCommandParameter dependency property.</returns>
    public static extern DependencyProperty SecondaryButtonCommandParameterProperty { [MethodImpl] get; }

    /// <summary>Gets the identifier of the IsPrimaryButtonEnabled dependency property.</summary>
    /// <returns>The identifier of the IsPrimaryButtonEnabled dependency property.</returns>
    public static extern DependencyProperty IsPrimaryButtonEnabledProperty { [MethodImpl] get; }

    /// <summary>Gets the identifier of the IsSecondaryButtonEnabled dependency property.</summary>
    /// <returns>The identifier of the IsSecondaryButtonEnabled dependency property.</returns>
    public static extern DependencyProperty IsSecondaryButtonEnabledProperty { [MethodImpl] get; }
  }
}
