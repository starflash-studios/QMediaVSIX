// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Email.IEmailMeetingInfo2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Email
{
  [ExclusiveTo(typeof (EmailMeetingInfo))]
  [Guid(2119776365, 45273, 20453, 134, 124, 227, 30, 210, 181, 136, 184)]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  internal interface IEmailMeetingInfo2
  {
    bool IsReportedOutOfDateByServer { get; }
  }
}
