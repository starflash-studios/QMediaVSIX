// Decompiled with JetBrains decompiler
// Type: Windows.Media.Casting.ICastingDeviceStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Devices.Enumeration;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Casting
{
  [ExclusiveTo(typeof (CastingDevice))]
  [Guid(3889780951, 19731, 16951, 163, 101, 76, 79, 106, 76, 253, 47)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ICastingDeviceStatics
  {
    string GetDeviceSelector(CastingPlaybackTypes type);

    [RemoteAsync]
    IAsyncOperation<string> GetDeviceSelectorFromCastingSourceAsync(
      CastingSource castingSource);

    [RemoteAsync]
    IAsyncOperation<CastingDevice> FromIdAsync(string value);

    [RemoteAsync]
    IAsyncOperation<bool> DeviceInfoSupportsCastingAsync(DeviceInformation device);
  }
}
