// Decompiled with JetBrains decompiler
// Type: Windows.Security.Credentials.PasswordVault
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Security.Credentials
{
  /// <summary>Represents a Credential Locker of credentials. The contents of the locker are specific to the app or service. Apps and services don't have access to credentials associated with other apps or services.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 100794368)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class PasswordVault : IPasswordVault
  {
    /// <summary>Creates and initializes a new instance of the PasswordVault object.</summary>
    [MethodImpl]
    public extern PasswordVault();

    /// <summary>Adds a credential to the Credential Locker.</summary>
    /// <param name="credential">The credential to be added.</param>
    [MethodImpl]
    public extern void Add(PasswordCredential credential);

    /// <summary>Removes a credential from the Credential Locker.</summary>
    /// <param name="credential">The credential to be removed.</param>
    [MethodImpl]
    public extern void Remove(PasswordCredential credential);

    /// <summary>Reads a credential from the Credential Locker.</summary>
    /// <param name="resource">The resource for which the credential is used.</param>
    /// <param name="userName">The user name that must be present in the credential.</param>
    /// <returns>The returned credential that contains all the data.</returns>
    [MethodImpl]
    public extern PasswordCredential Retrieve(string resource, string userName);

    /// <summary>Searches the Credential Locker for credentials matching the resource specified.</summary>
    /// <param name="resource">The resource to be searched for. If a match does not exist, an exception will throw.</param>
    /// <returns>When this method returns, contains an [IVectorView](https://docs.microsoft.com/previous-versions/br224594(v=vs.85)) of credential objects that match the search criteria.</returns>
    [MethodImpl]
    public extern IVectorView<PasswordCredential> FindAllByResource(
      string resource);

    /// <summary>Searches the Credential Locker for credentials that match the user name specified.</summary>
    /// <param name="userName">The user name to be searched for. If a match does not exist, an exception will throw.</param>
    /// <returns>When this method returns, contains an [IVectorView](https://docs.microsoft.com/previous-versions/br224594(v=vs.85)) of credential objects that match the search criteria.</returns>
    [MethodImpl]
    public extern IVectorView<PasswordCredential> FindAllByUserName(
      string userName);

    /// <summary>Retrieves all of the credentials stored in the Credential Locker.</summary>
    /// <returns>When this method returns, contains an [IVectorView](https://docs.microsoft.com/previous-versions/br224594(v=vs.85)) output of credential objects that match the search criteria. This output is a snapshot and not dynamic. If the results are used for updating or deleting credentials, those changes won't be reflected in the previous output.</returns>
    [MethodImpl]
    public extern IVectorView<PasswordCredential> RetrieveAll();
  }
}
