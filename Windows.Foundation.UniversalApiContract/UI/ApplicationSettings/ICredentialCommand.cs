// Decompiled with JetBrains decompiler
// Type: Windows.UI.ApplicationSettings.ICredentialCommand
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Security.Credentials;

namespace Windows.UI.ApplicationSettings
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (CredentialCommand))]
  [Guid(2784388582, 24899, 19066, 169, 113, 176, 23, 186, 151, 140, 226)]
  internal interface ICredentialCommand
  {
    PasswordCredential PasswordCredential { get; }

    CredentialCommandCredentialDeletedHandler CredentialDeleted { get; }
  }
}
