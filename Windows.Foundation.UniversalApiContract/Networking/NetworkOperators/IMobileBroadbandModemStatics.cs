// Decompiled with JetBrains decompiler
// Type: Windows.Networking.NetworkOperators.IMobileBroadbandModemStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.NetworkOperators
{
  [ExclusiveTo(typeof (MobileBroadbandModem))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(4187936311, 55025, 19064, 140, 188, 100, 33, 166, 80, 99, 200)]
  internal interface IMobileBroadbandModemStatics
  {
    string GetDeviceSelector();

    MobileBroadbandModem FromId(string deviceId);

    MobileBroadbandModem GetDefault();
  }
}
