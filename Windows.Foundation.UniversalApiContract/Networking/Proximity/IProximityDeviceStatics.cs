// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Proximity.IProximityDeviceStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Proximity
{
  [Guid(2437652509, 63201, 18372, 161, 76, 20, 138, 25, 3, 208, 198)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (ProximityDevice))]
  internal interface IProximityDeviceStatics
  {
    string GetDeviceSelector();

    ProximityDevice GetDefault();

    ProximityDevice FromId(string deviceId);
  }
}
