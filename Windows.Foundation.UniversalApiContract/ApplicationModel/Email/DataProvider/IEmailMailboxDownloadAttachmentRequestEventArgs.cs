// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Email.DataProvider.IEmailMailboxDownloadAttachmentRequestEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Email.DataProvider
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(3437085805, 65448, 18551, 159, 157, 254, 215, 188, 175, 65, 4)]
  [ExclusiveTo(typeof (EmailMailboxDownloadAttachmentRequestEventArgs))]
  internal interface IEmailMailboxDownloadAttachmentRequestEventArgs
  {
    EmailMailboxDownloadAttachmentRequest Request { get; }

    Deferral GetDeferral();
  }
}
