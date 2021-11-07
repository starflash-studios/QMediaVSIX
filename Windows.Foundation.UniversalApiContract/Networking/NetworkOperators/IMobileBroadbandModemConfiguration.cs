// Decompiled with JetBrains decompiler
// Type: Windows.Networking.NetworkOperators.IMobileBroadbandModemConfiguration
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.NetworkOperators
{
  [Guid(4242552227, 54989, 17184, 185, 130, 190, 157, 62, 199, 137, 15)]
  [ExclusiveTo(typeof (MobileBroadbandModemConfiguration))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IMobileBroadbandModemConfiguration
  {
    MobileBroadbandUicc Uicc { get; }

    string HomeProviderId { get; }

    string HomeProviderName { get; }
  }
}
