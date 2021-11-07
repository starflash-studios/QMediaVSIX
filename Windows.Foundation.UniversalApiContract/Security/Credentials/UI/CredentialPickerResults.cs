// Decompiled with JetBrains decompiler
// Type: Windows.Security.Credentials.UI.CredentialPickerResults
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Security.Credentials.UI
{
  /// <summary>Describes the results of the dialog box operation.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class CredentialPickerResults : ICredentialPickerResults
  {
    /// <summary>Gets the value of the error code.</summary>
    /// <returns>The value of the error code. If the operation status indicates a failure, this property contains the extended error information. If the operation status is anything except failure, the value is zero.</returns>
    public extern uint ErrorCode { [MethodImpl] get; }

    /// <summary>Gets the state of the "Save Credentials" check box.</summary>
    /// <returns>Indicates the state of the dialog box "Save" check box. If no check box was displayed, the value is "None."</returns>
    public extern CredentialSaveOption CredentialSaveOption { [MethodImpl] get; }

    /// <summary>Gets the status of the credential save operation.</summary>
    /// <returns>Indicates whether the credential was successfully saved by the credential manager. This value is always False if the caller specified the CallerSavesCredential property.</returns>
    public extern bool CredentialSaved { [MethodImpl] get; }

    /// <summary>Gets the opaque credential.</summary>
    /// <returns>A byte buffer that contains the opaque credential. If the credential is not available, a valid, but empty IBuffer object is returned.</returns>
    public extern IBuffer Credential { [MethodImpl] get; }

    /// <summary>Gets the domain name portion of the unpacked credential.</summary>
    /// <returns>The domain name of the credential. If the domain name is not available, an empty string is returned.</returns>
    public extern string CredentialDomainName { [MethodImpl] get; }

    /// <summary>Gets the user name of the unpacked credential.</summary>
    /// <returns>The user name of the credential used. If the user name is not available, an empty string is returned.</returns>
    public extern string CredentialUserName { [MethodImpl] get; }

    /// <summary>Gets the password portion of the unpacked credential.</summary>
    /// <returns>The password of the credential. If the password is not available, an empty string is returned.</returns>
    public extern string CredentialPassword { [MethodImpl] get; }
  }
}
