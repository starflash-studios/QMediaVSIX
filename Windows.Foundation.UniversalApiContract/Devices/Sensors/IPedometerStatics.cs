// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.IPedometerStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sensors
{
  [Guid(2191002159, 16515, 19963, 180, 17, 147, 142, 160, 244, 185, 70)]
  [ExclusiveTo(typeof (Pedometer))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IPedometerStatics
  {
    [RemoteAsync]
    IAsyncOperation<Pedometer> FromIdAsync(string deviceId);

    [RemoteAsync]
    IAsyncOperation<Pedometer> GetDefaultAsync();

    string GetDeviceSelector();

    [Overload("GetSystemHistoryAsync")]
    [RemoteAsync]
    IAsyncOperation<IVectorView<PedometerReading>> GetSystemHistoryAsync(
      DateTime fromTime);

    [Overload("GetSystemHistoryWithDurationAsync")]
    [RemoteAsync]
    IAsyncOperation<IVectorView<PedometerReading>> GetSystemHistoryAsync(
      DateTime fromTime,
      TimeSpan duration);
  }
}
