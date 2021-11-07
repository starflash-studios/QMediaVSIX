// Decompiled with JetBrains decompiler
// Type: Windows.Networking.NetworkOperators.IMobileBroadbandNetworkRegistrationStateChangeTriggerDetails
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Networking.NetworkOperators
{
  [ExclusiveTo(typeof (MobileBroadbandNetworkRegistrationStateChangeTriggerDetails))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2299747583, 10424, 18090, 177, 55, 28, 75, 15, 33, 237, 254)]
  internal interface IMobileBroadbandNetworkRegistrationStateChangeTriggerDetails
  {
    IVectorView<MobileBroadbandNetworkRegistrationStateChange> NetworkRegistrationStateChanges { get; }
  }
}
