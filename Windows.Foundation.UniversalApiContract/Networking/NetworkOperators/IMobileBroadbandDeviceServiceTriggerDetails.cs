// Decompiled with JetBrains decompiler
// Type: Windows.Networking.NetworkOperators.IMobileBroadbandDeviceServiceTriggerDetails
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Networking.NetworkOperators
{
  [Guid(1241865072, 47534, 17496, 146, 65, 166, 165, 251, 241, 138, 12)]
  [ExclusiveTo(typeof (MobileBroadbandDeviceServiceTriggerDetails))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IMobileBroadbandDeviceServiceTriggerDetails
  {
    string DeviceId { get; }

    Guid DeviceServiceId { get; }

    IBuffer ReceivedData { get; }
  }
}
