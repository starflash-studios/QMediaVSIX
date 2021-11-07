// Decompiled with JetBrains decompiler
// Type: Windows.Security.Credentials.KeyCredentialManager
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Credentials
{
  /// <summary>Contains methods for basic management of key credentials.</summary>
  [Threading(ThreadingModel.Both)]
  [DualApiPartition(version = 167772160)]
  [Static(typeof (IKeyCredentialManagerStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public static class KeyCredentialManager
  {
    /// <summary>Determines if the current device and user is capable of provisioning a key credential.</summary>
    /// <returns>When this method completes, it returns true if the current device and user is capable of provisioning a key credential. Otherwise, it returns false.</returns>
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<bool> IsSupportedAsync();

    /// <summary>Renews an attestation for a key credential.</summary>
    /// <returns>This method does not return a value.</returns>
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncAction RenewAttestationAsync();

    /// <summary>Creates a new key credential for the current user and application.</summary>
    /// <param name="name">The name of the key credential to create.</param>
    /// <param name="option">Options for the creation operation.</param>
    /// <returns>When this method completes, it returns the results of the key credential creation.</returns>
    [MethodImpl]
    public static extern IAsyncOperation<KeyCredentialRetrievalResult> RequestCreateAsync(
      string name,
      KeyCredentialCreationOption option);

    /// <summary>Retrieves a key credential for the current user and application.</summary>
    /// <param name="name">The name of the key credential to open.</param>
    /// <returns>When this method completes, it returns the results of the key credential retrieval.</returns>
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<KeyCredentialRetrievalResult> OpenAsync(
      string name);

    /// <summary>Deletes a previously provisioned user identity key for the current user and application.</summary>
    /// <param name="name">The name of the key to delete.</param>
    /// <returns>This method does not return a value.</returns>
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncAction DeleteAsync(string name);
  }
}
