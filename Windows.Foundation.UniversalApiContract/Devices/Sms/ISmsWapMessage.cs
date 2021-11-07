// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sms.ISmsWapMessage
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Devices.Sms
{
  [Guid(3448993603, 31317, 19771, 144, 33, 242, 46, 2, 45, 9, 197)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (SmsWapMessage))]
  internal interface ISmsWapMessage : ISmsMessageBase
  {
    DateTime Timestamp { get; }

    string To { get; }

    string From { get; }

    string ApplicationId { get; }

    string ContentType { get; }

    IBuffer BinaryBody { get; }

    IMap<string, string> Headers { get; }
  }
}
