﻿// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Email.IEmailMailbox4
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Email
{
  [ExclusiveTo(typeof (EmailMailbox))]
  [Guid(1562325019, 61986, 18599, 183, 182, 113, 99, 86, 205, 38, 161)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IEmailMailbox4
  {
    [RemoteAsync]
    IAsyncAction RegisterSyncManagerAsync();
  }
}