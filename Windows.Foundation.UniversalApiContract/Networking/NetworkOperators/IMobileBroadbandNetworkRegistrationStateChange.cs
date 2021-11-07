// Decompiled with JetBrains decompiler
// Type: Windows.Networking.NetworkOperators.IMobileBroadbandNetworkRegistrationStateChange
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.NetworkOperators
{
  [Guid(3199177953, 38415, 18868, 160, 141, 125, 133, 233, 104, 199, 236)]
  [ExclusiveTo(typeof (MobileBroadbandNetworkRegistrationStateChange))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IMobileBroadbandNetworkRegistrationStateChange
  {
    string DeviceId { get; }

    MobileBroadbandNetwork Network { get; }
  }
}
