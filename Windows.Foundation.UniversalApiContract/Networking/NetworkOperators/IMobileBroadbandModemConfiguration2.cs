// Decompiled with JetBrains decompiler
// Type: Windows.Networking.NetworkOperators.IMobileBroadbandModemConfiguration2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.NetworkOperators
{
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [Guid(839906757, 58464, 17070, 170, 81, 105, 98, 30, 122, 68, 119)]
  [ExclusiveTo(typeof (MobileBroadbandModemConfiguration))]
  internal interface IMobileBroadbandModemConfiguration2
  {
    MobileBroadbandSarManager SarManager { get; }
  }
}
