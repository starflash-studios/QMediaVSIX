// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sms.ISmsSendMessageResult
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sms
{
  [Guid(3675495154, 30921, 20459, 150, 34, 69, 35, 40, 8, 141, 98)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (SmsSendMessageResult))]
  internal interface ISmsSendMessageResult
  {
    bool IsSuccessful { get; }

    IVectorView<int> MessageReferenceNumbers { get; }

    CellularClass CellularClass { get; }

    SmsModemErrorCode ModemErrorCode { get; }

    bool IsErrorTransient { get; }

    int NetworkCauseCode { get; }

    int TransportFailureCause { get; }
  }
}
