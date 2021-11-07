// Decompiled with JetBrains decompiler
// Type: Windows.Networking.NetworkOperators.IMobileBroadbandDeviceServiceCommandResult
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Networking.NetworkOperators
{
  [ExclusiveTo(typeof (MobileBroadbandDeviceServiceCommandResult))]
  [Guid(2968808123, 38102, 17593, 165, 56, 240, 129, 11, 100, 83, 137)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IMobileBroadbandDeviceServiceCommandResult
  {
    uint StatusCode { get; }

    IBuffer ResponseData { get; }
  }
}
