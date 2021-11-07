// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Chat.IChatMessageAttachment
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.ApplicationModel.Chat
{
  [Guid(3351575924, 48995, 22763, 80, 140, 139, 134, 63, 241, 107, 103)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (ChatMessageAttachment))]
  internal interface IChatMessageAttachment
  {
    IRandomAccessStreamReference DataStreamReference { get; set; }

    uint GroupId { get; set; }

    string MimeType { get; set; }

    string Text { get; set; }
  }
}
