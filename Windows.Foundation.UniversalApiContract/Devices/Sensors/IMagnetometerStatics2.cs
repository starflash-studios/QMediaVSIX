// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.IMagnetometerStatics2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sensors
{
  [Guid(738728432, 65478, 20361, 160, 111, 24, 250, 16, 121, 41, 51)]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [ExclusiveTo(typeof (Magnetometer))]
  internal interface IMagnetometerStatics2
  {
    string GetDeviceSelector();

    [RemoteAsync]
    IAsyncOperation<Magnetometer> FromIdAsync(string deviceId);
  }
}
