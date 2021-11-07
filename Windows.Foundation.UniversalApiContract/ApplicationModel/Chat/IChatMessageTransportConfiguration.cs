// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Chat.IChatMessageTransportConfiguration
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Media.MediaProperties;

namespace Windows.ApplicationModel.Chat
{
  [ExclusiveTo(typeof (ChatMessageTransportConfiguration))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2275407653, 6664, 19146, 160, 117, 51, 85, 18, 99, 18, 230)]
  internal interface IChatMessageTransportConfiguration
  {
    int MaxAttachmentCount { get; }

    int MaxMessageSizeInKilobytes { get; }

    int MaxRecipientCount { get; }

    MediaEncodingProfile SupportedVideoFormat { get; }

    IMapView<string, object> ExtendedProperties { get; }
  }
}
