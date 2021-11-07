// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Power.IBatteryStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Power
{
  [ExclusiveTo(typeof (Battery))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2043507382, 40542, 17490, 190, 166, 223, 205, 84, 30, 89, 127)]
  internal interface IBatteryStatics
  {
    Battery AggregateBattery { get; }

    [RemoteAsync]
    IAsyncOperation<Battery> FromIdAsync(string deviceId);

    string GetDeviceSelector();
  }
}
