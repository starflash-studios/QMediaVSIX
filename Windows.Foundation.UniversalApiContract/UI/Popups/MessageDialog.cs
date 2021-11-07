// Decompiled with JetBrains decompiler
// Type: Windows.UI.Popups.MessageDialog
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Popups
{
  /// <summary>Represents a dialog for showing messages to the user.</summary>
  [Muse(Version = 100794368)]
  [Activatable(typeof (IMessageDialogFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Standard)]
  public sealed class MessageDialog : IMessageDialog
  {
    /// <summary>Initializes a new instance of the MessageDialog class to display an untitled message dialog that can be used to ask your user simple questions.</summary>
    /// <param name="content">The message displayed to the user.</param>
    [MethodImpl]
    public extern MessageDialog(string content);

    /// <summary>Initializes a new instance of the MessageDialog class to display a titled message dialog that can be used to ask your user simple questions.</summary>
    /// <param name="content">The message displayed to the user.</param>
    /// <param name="title">The title you want displayed on the dialog.</param>
    [MethodImpl]
    public extern MessageDialog(string content, string title);

    /// <summary>Gets or sets the title to display on the dialog, if any.</summary>
    /// <returns>The title to display on the dialog; or, an empty string if no title is set.</returns>
    public extern string Title { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets an array of commands that appear in the command bar of the message dialog. These commands makes the dialog actionable.</summary>
    /// <returns>The commands.</returns>
    public extern IVector<IUICommand> Commands { [MethodImpl] get; }

    /// <summary>Gets or sets the index of the command you want to use as the default. This is the command that fires by default when users press the ENTER key.</summary>
    /// <returns>The index of the default command.</returns>
    public extern uint DefaultCommandIndex { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the index of the command you want to use as the cancel command. This is the command that fires when users press the ESC key.</summary>
    /// <returns>The index of the cancel command.</returns>
    public extern uint CancelCommandIndex { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the message to be displayed to the user.</summary>
    /// <returns>The message to be displayed to the user.</returns>
    public extern string Content { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Begins an asynchronous operation showing a dialog.</summary>
    /// <returns>An object that represents the asynchronous operation. For more on the async pattern, see Asynchronous programming.</returns>
    [MethodImpl]
    public extern IAsyncOperation<IUICommand> ShowAsync();

    /// <summary>Gets or sets the options for a MessageDialog.</summary>
    /// <returns>The options for the dialog.</returns>
    public extern MessageDialogOptions Options { [MethodImpl] get; [MethodImpl] set; }
  }
}
