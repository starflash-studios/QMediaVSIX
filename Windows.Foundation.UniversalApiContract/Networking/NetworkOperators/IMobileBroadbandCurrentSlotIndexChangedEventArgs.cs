// Decompiled with JetBrains decompiler
// Type: Windows.Networking.NetworkOperators.IMobileBroadbandCurrentSlotIndexChangedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.NetworkOperators
{
  [Guid(4145590660, 50032, 24532, 166, 112, 24, 70, 203, 155, 206, 71)]
  [ExclusiveTo(typeof (MobileBroadbandCurrentSlotIndexChangedEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 786432)]
  internal interface IMobileBroadbandCurrentSlotIndexChangedEventArgs
  {
    int CurrentSlotIndex { get; }
  }
}
