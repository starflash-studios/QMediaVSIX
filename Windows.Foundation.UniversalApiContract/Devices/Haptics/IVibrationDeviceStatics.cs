// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Haptics.IVibrationDeviceStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Haptics
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (VibrationDevice))]
  [Guid(1407380973, 8848, 19145, 142, 179, 26, 132, 18, 46, 183, 28)]
  internal interface IVibrationDeviceStatics
  {
    [RemoteAsync]
    IAsyncOperation<VibrationAccessStatus> RequestAccessAsync();

    string GetDeviceSelector();

    [RemoteAsync]
    IAsyncOperation<VibrationDevice> FromIdAsync(string deviceId);

    [RemoteAsync]
    IAsyncOperation<VibrationDevice> GetDefaultAsync();

    [RemoteAsync]
    IAsyncOperation<IVectorView<VibrationDevice>> FindAllAsync();
  }
}
