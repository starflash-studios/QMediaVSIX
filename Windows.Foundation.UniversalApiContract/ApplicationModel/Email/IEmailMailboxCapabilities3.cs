// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Email.IEmailMailboxCapabilities3
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Email
{
  [ExclusiveTo(typeof (EmailMailboxCapabilities))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(4136692036, 22258, 17834, 135, 44, 12, 233, 243, 219, 11, 92)]
  internal interface IEmailMailboxCapabilities3
  {
    bool CanForwardMeetings { set; }

    bool CanGetAndSetExternalAutoReplies { set; }

    bool CanGetAndSetInternalAutoReplies { set; }

    bool CanUpdateMeetingResponses { set; }

    bool CanServerSearchFolders { set; }

    bool CanServerSearchMailbox { set; }

    bool CanProposeNewTimeForMeetings { set; }

    bool CanSmartSend { set; }

    bool CanResolveRecipients { set; }

    bool CanValidateCertificates { set; }

    bool CanEmptyFolder { set; }

    bool CanCreateFolder { set; }

    bool CanDeleteFolder { set; }

    bool CanMoveFolder { set; }
  }
}
