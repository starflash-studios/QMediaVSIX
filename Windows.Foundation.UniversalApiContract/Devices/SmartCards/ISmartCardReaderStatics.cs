// Decompiled with JetBrains decompiler
// Type: Windows.Devices.SmartCards.ISmartCardReaderStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.SmartCards
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(272368865, 41418, 18674, 162, 129, 91, 111, 102, 154, 241, 7)]
  [ExclusiveTo(typeof (SmartCardReader))]
  internal interface ISmartCardReaderStatics
  {
    [Overload("GetDeviceSelector")]
    string GetDeviceSelector();

    [Overload("GetDeviceSelectorWithKind")]
    string GetDeviceSelector(SmartCardReaderKind kind);

    [RemoteAsync]
    IAsyncOperation<SmartCardReader> FromIdAsync(string deviceId);
  }
}
