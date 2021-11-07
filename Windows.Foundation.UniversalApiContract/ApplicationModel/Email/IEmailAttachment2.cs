// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Email.IEmailAttachment2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Email
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(576655472, 45311, 17777, 157, 84, 167, 6, 196, 141, 85, 198)]
  [ExclusiveTo(typeof (EmailAttachment))]
  internal interface IEmailAttachment2
  {
    string Id { get; }

    string ContentId { get; set; }

    string ContentLocation { get; set; }

    EmailAttachmentDownloadState DownloadState { get; set; }

    ulong EstimatedDownloadSizeInBytes { get; set; }

    bool IsFromBaseMessage { get; }

    bool IsInline { get; set; }

    string MimeType { get; set; }
  }
}
