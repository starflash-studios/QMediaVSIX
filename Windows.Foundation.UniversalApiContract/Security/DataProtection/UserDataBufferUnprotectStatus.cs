// Decompiled with JetBrains decompiler
// Type: Windows.Security.DataProtection.UserDataBufferUnprotectStatus
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.DataProtection
{
  /// <summary>Describes the unprotect state of the provided buffer.</summary>
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  public enum UserDataBufferUnprotectStatus
  {
    /// <summary>Unprotecting the provided buffer succeeded and the result buffer is available in 'UnprotectedBuffer' member.</summary>
    Succeeded,
    /// <summary>Unprotecting the provided buffer is not possible as the protected data is currently unavailable.</summary>
    Unavailable,
  }
}
