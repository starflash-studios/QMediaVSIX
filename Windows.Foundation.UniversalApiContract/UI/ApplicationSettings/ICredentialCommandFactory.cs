// Decompiled with JetBrains decompiler
// Type: Windows.UI.ApplicationSettings.ICredentialCommandFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Security.Credentials;

namespace Windows.UI.ApplicationSettings
{
  [Guid(669551639, 48190, 19328, 148, 149, 78, 215, 32, 228, 138, 145)]
  [ExclusiveTo(typeof (CredentialCommand))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ICredentialCommandFactory
  {
    CredentialCommand CreateCredentialCommand(PasswordCredential passwordCredential);

    CredentialCommand CreateCredentialCommandWithHandler(
      PasswordCredential passwordCredential,
      CredentialCommandCredentialDeletedHandler deleted);
  }
}
