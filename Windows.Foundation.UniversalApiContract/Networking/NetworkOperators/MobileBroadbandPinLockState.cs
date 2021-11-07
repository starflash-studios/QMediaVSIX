// Decompiled with JetBrains decompiler
// Type: Windows.Networking.NetworkOperators.MobileBroadbandPinLockState
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.NetworkOperators
{
  /// <summary>Describes the possible PIN lock states of a mobile broadband PIN.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum MobileBroadbandPinLockState
  {
    /// <summary>The PIN lock state is unknown.</summary>
    Unknown,
    /// <summary>The PIN lock state is unlocked.</summary>
    Unlocked,
    /// <summary>A PIN input is required. The MobileBroadbandPinType will contain more information on which PIN is needed.</summary>
    PinRequired,
    /// <summary>An invalid PIN has been entered too often and a PIN Unblock Key (PUK) is needed to proceed.</summary>
    PinUnblockKeyRequired,
  }
}
