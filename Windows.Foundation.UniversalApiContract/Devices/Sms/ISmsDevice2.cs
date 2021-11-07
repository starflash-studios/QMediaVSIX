// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sms.ISmsDevice2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sms
{
  [Guid(3179961363, 58658, 18123, 184, 213, 158, 173, 48, 251, 108, 71)]
  [ExclusiveTo(typeof (SmsDevice2))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ISmsDevice2
  {
    string SmscAddress { get; set; }

    string DeviceId { get; }

    string ParentDeviceId { get; }

    string AccountPhoneNumber { get; }

    CellularClass CellularClass { get; }

    SmsDeviceStatus DeviceStatus { get; }

    SmsEncodedLength CalculateLength(ISmsMessageBase message);

    [RemoteAsync]
    IAsyncOperation<SmsSendMessageResult> SendMessageAndGetResultAsync(
      ISmsMessageBase message);

    event TypedEventHandler<SmsDevice2, object> DeviceStatusChanged;
  }
}
