// Decompiled with JetBrains decompiler
// Type: Windows.Networking.NetworkOperators.IMobileBroadbandModem3
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.NetworkOperators
{
  [ExclusiveTo(typeof (MobileBroadbandModem))]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [Guid(3925788394, 12084, 17794, 145, 2, 195, 20, 210, 168, 126, 236)]
  internal interface IMobileBroadbandModem3
  {
    [RemoteAsync]
    IAsyncOperation<MobileBroadbandPco> TryGetPcoAsync();

    bool IsInEmergencyCallMode { get; }

    event TypedEventHandler<MobileBroadbandModem, object> IsInEmergencyCallModeChanged;
  }
}
