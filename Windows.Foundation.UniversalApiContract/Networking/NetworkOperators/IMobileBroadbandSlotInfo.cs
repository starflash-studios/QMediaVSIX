// Decompiled with JetBrains decompiler
// Type: Windows.Networking.NetworkOperators.IMobileBroadbandSlotInfo
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.NetworkOperators
{
  [ExclusiveTo(typeof (MobileBroadbandSlotInfo))]
  [Guid(3174370098, 34862, 21546, 177, 125, 11, 177, 180, 155, 174, 158)]
  [ContractVersion(typeof (UniversalApiContract), 786432)]
  internal interface IMobileBroadbandSlotInfo
  {
    int Index { get; }

    MobileBroadbandSlotState State { get; }
  }
}
