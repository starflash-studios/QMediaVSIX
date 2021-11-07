// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sms.ISmsTextMessage2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sms
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(580966547, 17749, 18261, 181, 161, 231, 253, 132, 149, 95, 141)]
  [ExclusiveTo(typeof (SmsTextMessage2))]
  internal interface ISmsTextMessage2 : ISmsMessageBase
  {
    DateTime Timestamp { get; }

    string To { get; set; }

    string From { get; }

    string Body { get; set; }

    SmsEncoding Encoding { get; set; }

    string CallbackNumber { get; set; }

    bool IsDeliveryNotificationEnabled { get; set; }

    int RetryAttemptCount { get; set; }

    int TeleserviceId { get; }

    int ProtocolId { get; }
  }
}
