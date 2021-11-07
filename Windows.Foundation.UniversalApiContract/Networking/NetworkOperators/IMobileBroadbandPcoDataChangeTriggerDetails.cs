// Decompiled with JetBrains decompiler
// Type: Windows.Networking.NetworkOperators.IMobileBroadbandPcoDataChangeTriggerDetails
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.NetworkOperators
{
  [ExclusiveTo(typeof (MobileBroadbandPcoDataChangeTriggerDetails))]
  [Guid(641683732, 25824, 17555, 144, 155, 45, 20, 160, 25, 98, 177)]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  internal interface IMobileBroadbandPcoDataChangeTriggerDetails
  {
    MobileBroadbandPco UpdatedData { get; }
  }
}
