// Decompiled with JetBrains decompiler
// Type: Windows.UI.ApplicationSettings.CredentialCommandCredentialDeletedHandler
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.ApplicationSettings
{
  /// <summary>Represents the method that's invoked by the account settings pane when the user deletes a credential.</summary>
  /// <param name="command">The credential command that corresponds with the delegate.</param>
  [Guid(1640030597, 2423, 18040, 180, 226, 152, 114, 122, 251, 238, 217)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public delegate void CredentialCommandCredentialDeletedHandler(CredentialCommand command);
}
