// Decompiled with JetBrains decompiler
// Type: Windows.Security.Credentials.KeyCredentialOperationResult
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Security.Credentials
{
  /// <summary>Represents the result of a key credential operation.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 167772160)]
  public sealed class KeyCredentialOperationResult : IKeyCredentialOperationResult
  {
    /// <summary>Gets the result of the key credential operation.</summary>
    /// <returns>The result of the key credential operation.</returns>
    public extern IBuffer Result { [MethodImpl] get; }

    /// <summary>Gets the status of the key credential.</summary>
    /// <returns>Gets the status of the key credential.</returns>
    public extern KeyCredentialStatus Status { [MethodImpl] get; }
  }
}
