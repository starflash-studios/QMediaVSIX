// Decompiled with JetBrains decompiler
// Type: Windows.Networking.NetworkOperators.IMobileBroadbandDeviceInformation4
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.NetworkOperators
{
  [ContractVersion(typeof (UniversalApiContract), 786432)]
  [ExclusiveTo(typeof (MobileBroadbandDeviceInformation))]
  [Guid(641675602, 31645, 22572, 177, 124, 248, 10, 96, 181, 0, 49)]
  internal interface IMobileBroadbandDeviceInformation4
  {
    MobileBroadbandSlotManager SlotManager { get; }
  }
}
