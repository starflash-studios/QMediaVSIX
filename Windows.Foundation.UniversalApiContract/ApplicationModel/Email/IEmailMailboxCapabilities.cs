// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Email.IEmailMailboxCapabilities
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Email
{
  [ExclusiveTo(typeof (EmailMailboxCapabilities))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(4007576486, 35291, 17157, 130, 196, 67, 158, 10, 51, 218, 17)]
  internal interface IEmailMailboxCapabilities
  {
    bool CanForwardMeetings { get; }

    bool CanGetAndSetExternalAutoReplies { get; }

    bool CanGetAndSetInternalAutoReplies { get; }

    bool CanUpdateMeetingResponses { get; }

    bool CanServerSearchFolders { get; }

    bool CanServerSearchMailbox { get; }

    bool CanProposeNewTimeForMeetings { get; }

    bool CanSmartSend { get; }
  }
}
