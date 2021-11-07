// Decompiled with JetBrains decompiler
// Type: Windows.Networking.NetworkOperators.IMobileBroadbandPinLockStateChange
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.NetworkOperators
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (MobileBroadbandPinLockStateChange))]
  [Guid(3189139262, 7940, 20373, 139, 144, 231, 245, 89, 221, 231, 229)]
  internal interface IMobileBroadbandPinLockStateChange
  {
    string DeviceId { get; }

    MobileBroadbandPinType PinType { get; }

    MobileBroadbandPinLockState PinLockState { get; }
  }
}
