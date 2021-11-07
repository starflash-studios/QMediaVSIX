﻿// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Email.DataProvider.IEmailMailboxCreateFolderRequest
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Email.DataProvider
{
  [Guid(407713653, 51489, 19513, 163, 9, 225, 108, 159, 34, 176, 75)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (EmailMailboxCreateFolderRequest))]
  internal interface IEmailMailboxCreateFolderRequest
  {
    string EmailMailboxId { get; }

    string ParentFolderId { get; }

    string Name { get; }

    [RemoteAsync]
    IAsyncAction ReportCompletedAsync(EmailFolder folder);

    [RemoteAsync]
    IAsyncAction ReportFailedAsync(EmailMailboxCreateFolderStatus status);
  }
}