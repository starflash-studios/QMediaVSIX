// Decompiled with JetBrains decompiler
// Type: Windows.Security.Cryptography.Core.EncryptedAndAuthenticatedData
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Security.Cryptography.Core
{
  /// <summary>Contains data that can be retrieved from encrypted and authenticated data. Authenticated encryption algorithms are opened by using the SymmetricKeyAlgorithmProvider class.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 100794368)]
  public sealed class EncryptedAndAuthenticatedData : IEncryptedAndAuthenticatedData
  {
    /// <summary>Gets the encrypted data.</summary>
    /// <returns>Buffer that contains the encrypted data.</returns>
    public extern IBuffer EncryptedData { [MethodImpl] get; }

    /// <summary>Gets the authentication tag.</summary>
    /// <returns>Buffer that contains the tag.</returns>
    public extern IBuffer AuthenticationTag { [MethodImpl] get; }
  }
}
