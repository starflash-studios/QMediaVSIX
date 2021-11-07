// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Email.DataProvider.IEmailMailboxUpdateMeetingResponseRequestEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Email.DataProvider
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (EmailMailboxUpdateMeetingResponseRequestEventArgs))]
  [Guid(1754847073, 22217, 20247, 190, 49, 102, 253, 169, 75, 161, 89)]
  internal interface IEmailMailboxUpdateMeetingResponseRequestEventArgs
  {
    EmailMailboxUpdateMeetingResponseRequest Request { get; }

    Deferral GetDeferral();
  }
}
