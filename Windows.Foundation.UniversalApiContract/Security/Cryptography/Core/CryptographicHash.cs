// Decompiled with JetBrains decompiler
// Type: Windows.Security.Cryptography.Core.CryptographicHash
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Security.Cryptography.Core
{
  /// <summary>Represents a reusable hashing object and contains the result of a hashing operation.</summary>
  [DualApiPartition(version = 100794368)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class CryptographicHash : IHashComputation
  {
    /// <summary>Appends a binary encoded string to the data stored in the CryptographicHash object.</summary>
    /// <param name="data">Data to append.</param>
    [MethodImpl]
    public extern void Append(IBuffer data);

    /// <summary>Gets hashed data from the CryptographicHash object and resets the object.</summary>
    /// <returns>Hashed data.</returns>
    [MethodImpl]
    public extern IBuffer GetValueAndReset();
  }
}
