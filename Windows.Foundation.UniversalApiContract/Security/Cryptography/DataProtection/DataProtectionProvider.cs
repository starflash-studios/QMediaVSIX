// Decompiled with JetBrains decompiler
// Type: Windows.Security.Cryptography.DataProtection.DataProtectionProvider
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Security.Cryptography.DataProtection
{
  /// <summary>Represents a cryptographic provider that can be used to asynchronously encrypt and decrypt static data or a data stream.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(typeof (IDataProtectionProviderFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 100794368)]
  public sealed class DataProtectionProvider : IDataProtectionProvider
  {
    /// <summary>Constructor used for encryption operations. Use this constructor before calling the ProtectAsync or ProtectStreamAsync methods.</summary>
    /// <param name="protectionDescriptor">Contains the protection descriptor that determines the entity to which the data will be encrypted. For more information, see Remarks.</param>
    [MethodImpl]
    public extern DataProtectionProvider(string protectionDescriptor);

    /// <summary>Constructor used for decryption operations. Use this constructor before calling the UnprotectAsync or UnprotectStreamAsync methods.</summary>
    [MethodImpl]
    public extern DataProtectionProvider();

    /// <summary>Asynchronously protects static data.</summary>
    /// <param name="data">Data to protect.</param>
    /// <returns>Represents an asynchronous operation.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IBuffer> ProtectAsync(IBuffer data);

    /// <summary>Asynchronously decrypts static data.</summary>
    /// <param name="data">Data to decrypt.</param>
    /// <returns>Represents an asynchronous operation.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IBuffer> UnprotectAsync(IBuffer data);

    /// <summary>Asynchronously protects a data stream.</summary>
    /// <param name="src">Stream to be protected.</param>
    /// <param name="dest">Protected stream.</param>
    /// <returns>Represents an asynchronous action.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction ProtectStreamAsync(IInputStream src, IOutputStream dest);

    /// <summary>Asynchronously decrypts a data stream.</summary>
    /// <param name="src">Stream to decrypt.</param>
    /// <param name="dest">Decrypted stream.</param>
    /// <returns>Represents an asynchronous action.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction UnprotectStreamAsync(
      IInputStream src,
      IOutputStream dest);
  }
}
