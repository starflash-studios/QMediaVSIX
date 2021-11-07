// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Chat.IRcsTransportConfiguration
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Chat
{
  [ExclusiveTo(typeof (RcsTransportConfiguration))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(533508354, 9330, 19385, 153, 136, 193, 33, 28, 131, 232, 169)]
  internal interface IRcsTransportConfiguration
  {
    int MaxAttachmentCount { get; }

    int MaxMessageSizeInKilobytes { get; }

    int MaxGroupMessageSizeInKilobytes { get; }

    int MaxRecipientCount { get; }

    int MaxFileSizeInKilobytes { get; }

    int WarningFileSizeInKilobytes { get; }
  }
}
