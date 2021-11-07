// Decompiled with JetBrains decompiler
// Type: Windows.Networking.NetworkOperators.IMobileBroadbandDeviceServiceInformation
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.NetworkOperators
{
  [ExclusiveTo(typeof (MobileBroadbandDeviceServiceInformation))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1406573403, 50413, 17904, 128, 58, 217, 65, 122, 109, 152, 70)]
  internal interface IMobileBroadbandDeviceServiceInformation
  {
    Guid DeviceServiceId { get; }

    bool IsDataReadSupported { get; }

    bool IsDataWriteSupported { get; }
  }
}
