// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Email.DataProvider.IEmailMailboxProposeNewTimeForMeetingRequestEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Email.DataProvider
{
  [ExclusiveTo(typeof (EmailMailboxProposeNewTimeForMeetingRequestEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(4215802776, 13229, 19047, 130, 81, 15, 156, 36, 155, 106, 32)]
  internal interface IEmailMailboxProposeNewTimeForMeetingRequestEventArgs
  {
    EmailMailboxProposeNewTimeForMeetingRequest Request { get; }

    Deferral GetDeferral();
  }
}
