// Decompiled with JetBrains decompiler
// Type: Windows.Security.Credentials.UI.CredentialPickerOptions
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Security.Credentials.UI
{
  /// <summary>Controls the appearance and behavior of a credential prompt.</summary>
  [MarshalingBehavior(MarshalingType.Standard)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class CredentialPickerOptions : ICredentialPickerOptions
  {
    /// <summary>Creates and initializes a new, empty instance of the CredentialPickerOptions object.</summary>
    [MethodImpl]
    public extern CredentialPickerOptions();

    /// <summary>Gets or sets the caption text that is displayed to the user.</summary>
    /// <returns>Text that appears in the message header of the dialog box. The default value is the caller's app name.</returns>
    public extern string Caption { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets or sets the body of text that displays to the user.</summary>
    /// <returns>Text that appears in the message body of the dialog box. The default value is "Enter credentials" or localized equivalent.</returns>
    public extern string Message { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets or sets the error code.</summary>
    /// <returns>If nonzero, represents a Win32 ERROR_* status value that identifies the error information to be formatted and displayed in the dialog box. The default value is ERROR_SUCCESS if no error occurred.</returns>
    public extern uint ErrorCode { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets or sets the name of the target computer.</summary>
    /// <returns>Name of the target computer. The default value is the caller's computer.</returns>
    public extern string TargetName { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets or sets the authentication protocol.</summary>
    /// <returns>Name of the authentication protocol to use for credential authentication. The default value is Negotiate.</returns>
    public extern AuthenticationProtocol AuthenticationProtocol { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets or sets whether the authentication protocol is custom rather than a standard authentication protocol.</summary>
    /// <returns>The authentication protocol is custom rather than a standard authentication protocol. The default value is none.</returns>
    public extern string CustomAuthenticationProtocol { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets or sets whether to fill dialog box fields with previous credentials.</summary>
    /// <returns>Determines whether dialog box fields are filled with previous credentials. The default value is not to prepopulate the fields.</returns>
    public extern IBuffer PreviousCredential { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets or sets the option of whether the dialog box is displayed.</summary>
    /// <returns>Gets or sets the option of always displaying the dialog box. The default value is False.</returns>
    public extern bool AlwaysDisplayDialog { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets or sets whether the caller wants to save the credentials.</summary>
    /// <returns>Gets or sets whether the caller wants to save the credentials. The default value is False.</returns>
    public extern bool CallerSavesCredential { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets or sets the option on saving credentials.</summary>
    /// <returns>The option specifies the initial state of the dialog's "Save Credential" check box. The default value is clear (unchecked). This property is ignored if the caller specifies **Hidden** in the CredentialSaveOption enumeration.</returns>
    public extern CredentialSaveOption CredentialSaveOption { [MethodImpl] set; [MethodImpl] get; }
  }
}
