// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Radios.IRadioStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Radios
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1605804334, 26571, 18094, 170, 233, 101, 145, 159, 134, 239, 244)]
  [ExclusiveTo(typeof (Radio))]
  internal interface IRadioStatics
  {
    [RemoteAsync]
    IAsyncOperation<IVectorView<Radio>> GetRadiosAsync();

    string GetDeviceSelector();

    [Overload("FromIdAsync")]
    [RemoteAsync]
    IAsyncOperation<Radio> FromIdAsync(string deviceId);

    [RemoteAsync]
    IAsyncOperation<RadioAccessStatus> RequestAccessAsync();
  }
}
