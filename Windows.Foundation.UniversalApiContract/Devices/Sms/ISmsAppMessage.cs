// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sms.ISmsAppMessage
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Devices.Sms
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (SmsAppMessage))]
  [Guid(3904603284, 54176, 18954, 134, 215, 41, 16, 51, 168, 207, 84)]
  internal interface ISmsAppMessage : ISmsMessageBase
  {
    DateTime Timestamp { get; }

    string To { get; set; }

    string From { get; }

    string Body { get; set; }

    string CallbackNumber { get; set; }

    bool IsDeliveryNotificationEnabled { get; set; }

    int RetryAttemptCount { get; set; }

    SmsEncoding Encoding { get; set; }

    int PortNumber { get; set; }

    int TeleserviceId { get; set; }

    int ProtocolId { get; set; }

    IBuffer BinaryBody { get; set; }
  }
}
