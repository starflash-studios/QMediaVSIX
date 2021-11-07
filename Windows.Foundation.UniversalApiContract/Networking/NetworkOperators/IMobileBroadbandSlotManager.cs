// Decompiled with JetBrains decompiler
// Type: Windows.Networking.NetworkOperators.IMobileBroadbandSlotManager
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Networking.NetworkOperators
{
  [Guid(3953163478, 8217, 24449, 162, 148, 204, 54, 74, 17, 208, 178)]
  [ContractVersion(typeof (UniversalApiContract), 786432)]
  [ExclusiveTo(typeof (MobileBroadbandSlotManager))]
  internal interface IMobileBroadbandSlotManager
  {
    IVectorView<MobileBroadbandSlotInfo> SlotInfos { get; }

    int CurrentSlotIndex { get; }

    MobileBroadbandModemStatus SetCurrentSlot(int slotIndex);

    [RemoteAsync]
    IAsyncOperation<MobileBroadbandModemStatus> SetCurrentSlotAsync(
      int slotIndex);

    event TypedEventHandler<MobileBroadbandSlotManager, MobileBroadbandSlotInfoChangedEventArgs> SlotInfoChanged;

    event TypedEventHandler<MobileBroadbandSlotManager, MobileBroadbandCurrentSlotIndexChangedEventArgs> CurrentSlotIndexChanged;
  }
}
