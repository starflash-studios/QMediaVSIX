﻿// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Email.IEmailMessage4
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Email
{
  [ExclusiveTo(typeof (EmailMessage))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(830271873, 15999, 18949, 131, 148, 62, 16, 51, 109, 212, 53)]
  internal interface IEmailMessage4
  {
    IVector<EmailRecipient> ReplyTo { get; }

    EmailRecipient SentRepresenting { get; set; }
  }
}