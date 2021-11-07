// Decompiled with JetBrains decompiler
// Type: Windows.Networking.NetworkOperators.IMobileBroadbandDeviceInformation2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.NetworkOperators
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(776370929, 63794, 18231, 167, 34, 3, 186, 114, 55, 12, 184)]
  [ExclusiveTo(typeof (MobileBroadbandDeviceInformation))]
  internal interface IMobileBroadbandDeviceInformation2
  {
    MobileBroadbandPinManager PinManager { get; }

    string Revision { get; }

    string SerialNumber { get; }
  }
}
