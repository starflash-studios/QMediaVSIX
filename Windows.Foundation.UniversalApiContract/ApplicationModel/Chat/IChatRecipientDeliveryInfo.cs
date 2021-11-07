// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Chat.IChatRecipientDeliveryInfo
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Chat
{
  [Guid(4291277474, 10300, 19466, 138, 14, 140, 51, 189, 191, 5, 69)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (ChatRecipientDeliveryInfo))]
  internal interface IChatRecipientDeliveryInfo
  {
    string TransportAddress { get; set; }

    IReference<DateTime> DeliveryTime { get; set; }

    IReference<DateTime> ReadTime { get; set; }

    ChatTransportErrorCodeCategory TransportErrorCodeCategory { get; }

    ChatTransportInterpretedErrorCode TransportInterpretedErrorCode { get; }

    int TransportErrorCode { get; }

    bool IsErrorPermanent { get; }

    ChatMessageStatus Status { get; }
  }
}
