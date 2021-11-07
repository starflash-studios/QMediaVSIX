// Decompiled with JetBrains decompiler
// Type: Windows.Networking.NetworkOperators.IMobileBroadbandModem2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.NetworkOperators
{
  [ExclusiveTo(typeof (MobileBroadbandModem))]
  [Guid(310782760, 47595, 20194, 187, 227, 113, 31, 83, 238, 163, 115)]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  internal interface IMobileBroadbandModem2
  {
    [RemoteAsync]
    IAsyncOperation<bool> GetIsPassthroughEnabledAsync();

    [RemoteAsync]
    IAsyncOperation<MobileBroadbandModemStatus> SetIsPassthroughEnabledAsync(
      bool value);
  }
}
