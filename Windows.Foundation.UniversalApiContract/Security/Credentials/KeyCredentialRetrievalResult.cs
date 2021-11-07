// Decompiled with JetBrains decompiler
// Type: Windows.Security.Credentials.KeyCredentialRetrievalResult
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Credentials
{
  /// <summary>Represents the result of a key credential retrieval.</summary>
  [DualApiPartition(version = 167772160)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class KeyCredentialRetrievalResult : IKeyCredentialRetrievalResult
  {
    /// <summary>Gets the key credential.</summary>
    /// <returns>The key credential.</returns>
    public extern KeyCredential Credential { [MethodImpl] get; }

    /// <summary>Gets the status of the key credential.</summary>
    /// <returns>The status of the key credential.</returns>
    public extern KeyCredentialStatus Status { [MethodImpl] get; }
  }
}
