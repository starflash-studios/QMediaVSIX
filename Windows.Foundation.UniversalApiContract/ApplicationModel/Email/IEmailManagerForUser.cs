// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Email.IEmailManagerForUser
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.System;

namespace Windows.ApplicationModel.Email
{
  [ExclusiveTo(typeof (EmailManagerForUser))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(4151565983, 15525, 19215, 144, 193, 21, 110, 64, 23, 76, 229)]
  internal interface IEmailManagerForUser
  {
    [RemoteAsync]
    IAsyncAction ShowComposeNewEmailAsync(EmailMessage message);

    [RemoteAsync]
    IAsyncOperation<EmailStore> RequestStoreAsync(
      EmailStoreAccessType accessType);

    User User { get; }
  }
}
