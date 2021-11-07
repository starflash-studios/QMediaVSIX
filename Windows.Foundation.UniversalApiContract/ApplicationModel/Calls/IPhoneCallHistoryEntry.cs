// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Calls.IPhoneCallHistoryEntry
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Calls
{
  [ExclusiveTo(typeof (PhoneCallHistoryEntry))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(4205895977, 12964, 19333, 131, 209, 249, 13, 140, 35, 168, 87)]
  internal interface IPhoneCallHistoryEntry
  {
    string Id { get; }

    PhoneCallHistoryEntryAddress Address { get; set; }

    IReference<TimeSpan> Duration { get; set; }

    bool IsCallerIdBlocked { get; set; }

    bool IsEmergency { get; set; }

    bool IsIncoming { get; set; }

    bool IsMissed { get; set; }

    bool IsRinging { get; set; }

    bool IsSeen { get; set; }

    bool IsSuppressed { get; set; }

    bool IsVoicemail { get; set; }

    PhoneCallHistoryEntryMedia Media { get; set; }

    PhoneCallHistoryEntryOtherAppReadAccess OtherAppReadAccess { get; set; }

    string RemoteId { get; set; }

    string SourceDisplayName { get; }

    string SourceId { get; set; }

    PhoneCallHistorySourceIdKind SourceIdKind { get; set; }

    DateTime StartTime { get; set; }
  }
}
