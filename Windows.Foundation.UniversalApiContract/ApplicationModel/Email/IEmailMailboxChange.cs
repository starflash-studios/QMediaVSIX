// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Email.IEmailMailboxChange
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Email
{
  [Guid(1642984779, 4591, 16396, 173, 222, 140, 222, 101, 200, 94, 102)]
  [ExclusiveTo(typeof (EmailMailboxChange))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IEmailMailboxChange
  {
    EmailMailboxChangeType ChangeType { get; }

    IVector<EmailMailboxAction> MailboxActions { get; }

    EmailMessage Message { get; }

    EmailFolder Folder { get; }
  }
}
