// Decompiled with JetBrains decompiler
// Type: Windows.Networking.NetworkOperators.IMobileBroadbandRadioStateChange
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.NetworkOperators
{
  [Guid(2958337377, 38963, 19181, 151, 23, 67, 72, 178, 26, 36, 179)]
  [ExclusiveTo(typeof (MobileBroadbandRadioStateChange))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IMobileBroadbandRadioStateChange
  {
    string DeviceId { get; }

    MobileBroadbandRadioState RadioState { get; }
  }
}
