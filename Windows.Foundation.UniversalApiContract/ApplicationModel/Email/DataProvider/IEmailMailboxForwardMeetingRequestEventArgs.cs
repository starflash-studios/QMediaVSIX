﻿// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Email.DataProvider.IEmailMailboxForwardMeetingRequestEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Email.DataProvider
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (EmailMailboxForwardMeetingRequestEventArgs))]
  [Guid(735638330, 10612, 18265, 165, 165, 88, 244, 77, 60, 2, 117)]
  internal interface IEmailMailboxForwardMeetingRequestEventArgs
  {
    EmailMailboxForwardMeetingRequest Request { get; }

    Deferral GetDeferral();
  }
}