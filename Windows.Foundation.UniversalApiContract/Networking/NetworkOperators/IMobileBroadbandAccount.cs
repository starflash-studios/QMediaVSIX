// Decompiled with JetBrains decompiler
// Type: Windows.Networking.NetworkOperators.IMobileBroadbandAccount
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.NetworkOperators
{
  [ExclusiveTo(typeof (MobileBroadbandAccount))]
  [Guid(918703309, 52962, 17376, 166, 3, 238, 134, 163, 109, 101, 112)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IMobileBroadbandAccount
  {
    string NetworkAccountId { get; }

    Guid ServiceProviderGuid { get; }

    string ServiceProviderName { get; }

    MobileBroadbandNetwork CurrentNetwork { get; }

    MobileBroadbandDeviceInformation CurrentDeviceInformation { get; }
  }
}
