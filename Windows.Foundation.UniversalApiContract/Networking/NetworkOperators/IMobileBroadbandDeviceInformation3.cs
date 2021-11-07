// Decompiled with JetBrains decompiler
// Type: Windows.Networking.NetworkOperators.IMobileBroadbandDeviceInformation3
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.NetworkOperators
{
  [ExclusiveTo(typeof (MobileBroadbandDeviceInformation))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(3767252157, 23856, 19290, 146, 204, 213, 77, 248, 129, 212, 158)]
  internal interface IMobileBroadbandDeviceInformation3
  {
    string SimSpn { get; }

    string SimPnn { get; }

    string SimGid1 { get; }
  }
}
