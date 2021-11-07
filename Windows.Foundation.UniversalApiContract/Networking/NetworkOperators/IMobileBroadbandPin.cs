// Decompiled with JetBrains decompiler
// Type: Windows.Networking.NetworkOperators.IMobileBroadbandPin
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.NetworkOperators
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3865171721, 59257, 17855, 130, 129, 117, 50, 61, 249, 227, 33)]
  [ExclusiveTo(typeof (MobileBroadbandPin))]
  internal interface IMobileBroadbandPin
  {
    MobileBroadbandPinType Type { get; }

    MobileBroadbandPinLockState LockState { get; }

    MobileBroadbandPinFormat Format { get; }

    bool Enabled { get; }

    uint MaxLength { get; }

    uint MinLength { get; }

    uint AttemptsRemaining { get; }

    [RemoteAsync]
    IAsyncOperation<MobileBroadbandPinOperationResult> EnableAsync(
      string currentPin);

    [RemoteAsync]
    IAsyncOperation<MobileBroadbandPinOperationResult> DisableAsync(
      string currentPin);

    [RemoteAsync]
    IAsyncOperation<MobileBroadbandPinOperationResult> EnterAsync(
      string currentPin);

    [RemoteAsync]
    IAsyncOperation<MobileBroadbandPinOperationResult> ChangeAsync(
      string currentPin,
      string newPin);

    [RemoteAsync]
    IAsyncOperation<MobileBroadbandPinOperationResult> UnblockAsync(
      string pinUnblockKey,
      string newPin);
  }
}
