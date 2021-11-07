// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Email.IEmailMessage
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Email
{
  [ExclusiveTo(typeof (EmailMessage))]
  [Guid(1819120781, 32949, 18680, 176, 177, 224, 78, 67, 15, 68, 229)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IEmailMessage
  {
    string Subject { get; set; }

    string Body { get; set; }

    IVector<EmailRecipient> To { get; }

    IVector<EmailRecipient> CC { get; }

    IVector<EmailRecipient> Bcc { get; }

    IVector<EmailAttachment> Attachments { get; }
  }
}
