// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Email.IEmailAttachmentFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.ApplicationModel.Email
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (EmailAttachment))]
  [Guid(2037296198, 60758, 18809, 135, 8, 171, 184, 188, 133, 75, 125)]
  internal interface IEmailAttachmentFactory
  {
    EmailAttachment Create(string fileName, IRandomAccessStreamReference data);
  }
}
