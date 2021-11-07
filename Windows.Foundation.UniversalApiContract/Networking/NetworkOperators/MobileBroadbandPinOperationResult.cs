// Decompiled with JetBrains decompiler
// Type: Windows.Networking.NetworkOperators.MobileBroadbandPinOperationResult
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.NetworkOperators
{
  /// <summary>Represents the result of a mobile broadband PIN operation.</summary>
  [DualApiPartition(version = 167772160)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class MobileBroadbandPinOperationResult : IMobileBroadbandPinOperationResult
  {
    /// <summary>Gets a value indicating whether the PIN operation was successful.</summary>
    /// <returns>Successful when true.</returns>
    public extern bool IsSuccessful { [MethodImpl] get; }

    /// <summary>Gets the number of PIN entry attempts remaining until the mobile broadband PIN is blocked.</summary>
    /// <returns>the number of PIN entry attempts remaining until the mobile broadband PIN is blocked.</returns>
    public extern uint AttemptsRemaining { [MethodImpl] get; }
  }
}
