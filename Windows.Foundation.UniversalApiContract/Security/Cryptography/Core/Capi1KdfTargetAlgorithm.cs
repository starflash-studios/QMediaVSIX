// Decompiled with JetBrains decompiler
// Type: Windows.Security.Cryptography.Core.Capi1KdfTargetAlgorithm
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Cryptography.Core
{
  /// <summary>Represents information about a target algorithm.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum Capi1KdfTargetAlgorithm
  {
    /// <summary>The target algorithm is not AES.</summary>
    NotAes,
    /// <summary>The target algorithm is AES.</summary>
    Aes,
  }
}
