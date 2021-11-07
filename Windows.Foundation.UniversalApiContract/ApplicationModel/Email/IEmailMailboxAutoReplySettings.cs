// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Email.IEmailMailboxAutoReplySettings
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Email
{
  [Guid(2826608552, 2758, 19319, 186, 119, 166, 185, 158, 154, 39, 184)]
  [ExclusiveTo(typeof (EmailMailboxAutoReplySettings))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IEmailMailboxAutoReplySettings
  {
    bool IsEnabled { get; set; }

    EmailMailboxAutoReplyMessageResponseKind ResponseKind { get; set; }

    IReference<DateTime> StartTime { get; set; }

    IReference<DateTime> EndTime { get; set; }

    EmailMailboxAutoReply InternalReply { get; }

    EmailMailboxAutoReply KnownExternalReply { get; }

    EmailMailboxAutoReply UnknownExternalReply { get; }
  }
}
