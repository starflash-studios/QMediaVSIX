// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Email.IEmailMessageBatch
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Email
{
  [Guid(1616695439, 9689, 20251, 158, 81, 5, 20, 192, 20, 150, 83)]
  [ExclusiveTo(typeof (EmailMessageBatch))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IEmailMessageBatch
  {
    IVectorView<EmailMessage> Messages { get; }

    EmailBatchStatus Status { get; }
  }
}
