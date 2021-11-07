// Decompiled with JetBrains decompiler
// Type: Windows.Security.DataProtection.UserDataBufferUnprotectResult
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Security.DataProtection
{
  /// <summary>Contains result status of unprotecting a buffer and if succeeded, the unprotected buffer.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  [Threading(ThreadingModel.Both)]
  public sealed class UserDataBufferUnprotectResult : IUserDataBufferUnprotectResult
  {
    /// <summary>Result status of unprotecting a buffer.</summary>
    /// <returns>A value of the UserDataBufferUnprotectStatus enumeration.</returns>
    public extern UserDataBufferUnprotectStatus Status { [MethodImpl] get; }

    /// <summary>Copy of the unprotected buffer, if the unprotect call succeeded.</summary>
    /// <returns>The unprotected buffer.</returns>
    public extern IBuffer UnprotectedBuffer { [MethodImpl] get; }
  }
}
