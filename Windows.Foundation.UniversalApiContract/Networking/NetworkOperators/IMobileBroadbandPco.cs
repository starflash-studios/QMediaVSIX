// Decompiled with JetBrains decompiler
// Type: Windows.Networking.NetworkOperators.IMobileBroadbandPco
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Networking.NetworkOperators
{
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [Guid(3571776702, 58275, 17349, 168, 123, 108, 134, 210, 41, 215, 250)]
  [ExclusiveTo(typeof (MobileBroadbandPco))]
  internal interface IMobileBroadbandPco
  {
    IBuffer Data { get; }

    bool IsComplete { get; }

    string DeviceId { get; }
  }
}
