// Decompiled with JetBrains decompiler
// Type: Windows.Networking.NetworkOperators.ESimOperationResult
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.NetworkOperators
{
  /// <summary>A class that represents the result of certain asynchronous operations on an eSIM (for example, deleting a profile from the eSIM), or on an eSIM profile (for example, enabling the profile).</summary>
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class ESimOperationResult : IESimOperationResult
  {
    /// <summary>Gets the status of the eSIM operation result.</summary>
    /// <returns>The status of the eSIM operation result.</returns>
    public extern ESimOperationStatus Status { [MethodImpl] get; }
  }
}
