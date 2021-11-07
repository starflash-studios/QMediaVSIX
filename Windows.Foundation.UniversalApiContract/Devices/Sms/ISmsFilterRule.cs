// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sms.ISmsFilterRule
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sms
{
  [ExclusiveTo(typeof (SmsFilterRule))]
  [Guid(1088630702, 45129, 20412, 175, 233, 226, 166, 16, 239, 245, 92)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ISmsFilterRule
  {
    SmsMessageType MessageType { get; }

    IVector<string> ImsiPrefixes { get; }

    IVector<string> DeviceIds { get; }

    IVector<string> SenderNumbers { get; }

    IVector<string> TextMessagePrefixes { get; }

    IVector<int> PortNumbers { get; }

    CellularClass CellularClass { get; set; }

    IVector<int> ProtocolIds { get; }

    IVector<int> TeleserviceIds { get; }

    IVector<string> WapApplicationIds { get; }

    IVector<string> WapContentTypes { get; }

    IVector<SmsBroadcastType> BroadcastTypes { get; }

    IVector<int> BroadcastChannels { get; }
  }
}
