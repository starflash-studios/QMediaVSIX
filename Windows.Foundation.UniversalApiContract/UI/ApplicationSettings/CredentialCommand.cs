// Decompiled with JetBrains decompiler
// Type: Windows.UI.ApplicationSettings.CredentialCommand
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Security.Credentials;

namespace Windows.UI.ApplicationSettings
{
  /// <summary>Deprecated. Represents a command for changing web account credentials in the account settings pane.</summary>
  [MarshalingBehavior(MarshalingType.None)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(typeof (ICredentialCommandFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [Muse(Version = 100859904)]
  public sealed class CredentialCommand : ICredentialCommand
  {
    /// <summary>Initializes a new instance of the CredentialCommand class with a PasswordCredential object.</summary>
    /// <param name="passwordCredential">The password credential.</param>
    [MethodImpl]
    public extern CredentialCommand(PasswordCredential passwordCredential);

    /// <summary>Initializes a new instance of the CredentialCommand class with a PasswordCredential object and a CredentialCommandCredentialDeletedHandler delegate.</summary>
    /// <param name="passwordCredential">The password credential.</param>
    /// <param name="deleted">The delegate that handles credential deletion.</param>
    [MethodImpl]
    public extern CredentialCommand(
      PasswordCredential passwordCredential,
      CredentialCommandCredentialDeletedHandler deleted);

    /// <summary>Gets the password credential that the current command applies to.</summary>
    /// <returns>The password credential.</returns>
    public extern PasswordCredential PasswordCredential { [MethodImpl] get; }

    /// <summary>Gets the delegate that's invoked by the account settings pane when the user deletes a credential.</summary>
    /// <returns>The delegate that handles credential deletion.</returns>
    public extern CredentialCommandCredentialDeletedHandler CredentialDeleted { [MethodImpl] get; }
  }
}
