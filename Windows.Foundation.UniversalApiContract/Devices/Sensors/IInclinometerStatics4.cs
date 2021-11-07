// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.IInclinometerStatics4
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sensors
{
  [ExclusiveTo(typeof (Inclinometer))]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [Guid(3904542457, 28293, 19075, 174, 208, 215, 205, 204, 152, 86, 200)]
  internal interface IInclinometerStatics4
  {
    string GetDeviceSelector(SensorReadingType readingType);

    [RemoteAsync]
    IAsyncOperation<Inclinometer> FromIdAsync(string deviceId);
  }
}
