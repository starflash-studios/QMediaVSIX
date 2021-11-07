// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Calls.PhoneCallHistoryEntry
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Calls
{
  /// <summary>A collection of information about a phone call for the call history.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class PhoneCallHistoryEntry : IPhoneCallHistoryEntry
  {
    /// <summary>Creates a new PhoneCallHistoryEntry object.</summary>
    [MethodImpl]
    public extern PhoneCallHistoryEntry();

    /// <summary>Gets the unique identifier for this log entry.</summary>
    /// <returns>The unique identifier for the PhoneCallHistoryEntry object.</returns>
    public extern string Id { [MethodImpl] get; }

    /// <summary>Gets or sets the address book information for this phone call.</summary>
    /// <returns>The address book information for the phone call.</returns>
    public extern PhoneCallHistoryEntryAddress Address { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the duration of the call.</summary>
    /// <returns>The duration of the phone call.</returns>
    public extern IReference<TimeSpan> Duration { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value determining whether the caller ID is blocked for this phone call.</summary>
    /// <returns>Indicates whether the caller ID is blocked.</returns>
    public extern bool IsCallerIdBlocked { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that determines whether the call is classified as an emergency.</summary>
    /// <returns>Indicates whether the call is an emergency phone call.</returns>
    public extern bool IsEmergency { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets whether a call is an incoming call.</summary>
    /// <returns>**True** if the call was an incoming call, otherwise **false**.</returns>
    public extern bool IsIncoming { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets whether a phone call was missed.</summary>
    /// <returns>**True** if the phone call was missed, otherwise **false**.</returns>
    public extern bool IsMissed { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets whether a call is currently ringing.</summary>
    /// <returns>**True** if the call is currently ringing, otherwise **false**.</returns>
    public extern bool IsRinging { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a whether a phone call is seen.</summary>
    /// <returns>**True** if the call is seen, otherwise **false**.</returns>
    public extern bool IsSeen { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets whether this entry is suppressed.</summary>
    /// <returns>**True** if the entry is suppressed, otherwise **false**.</returns>
    public extern bool IsSuppressed { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets whether the phone call entry is a voicemail message.</summary>
    /// <returns>**True** if the entry is a voicemail message, otherwise **false**.</returns>
    public extern bool IsVoicemail { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the type of media associated with a call.</summary>
    /// <returns>The media associated with a call.</returns>
    public extern PhoneCallHistoryEntryMedia Media { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the level of access provided to other applications.</summary>
    /// <returns>The level of access that other applications have with respect to this PhoneCallHistoryEntry object.</returns>
    public extern PhoneCallHistoryEntryOtherAppReadAccess OtherAppReadAccess { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the remote id for the entry.</summary>
    /// <returns>The remote id for the PhoneCallHistoryEntry.</returns>
    public extern string RemoteId { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the display name for the source of the phone call.</summary>
    /// <returns>The display string for the source of the phone call.</returns>
    public extern string SourceDisplayName { [MethodImpl] get; }

    /// <summary>Gets or sets the identifier for the source of the phone call.</summary>
    /// <returns>The identifier for the source of the phone call.</returns>
    public extern string SourceId { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates what type of identifier the SourceId is.</summary>
    /// <returns>The type of identifier that the PhoneCallHistoryEntry.SourceId is.</returns>
    public extern PhoneCallHistorySourceIdKind SourceIdKind { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the start time for this history entry.</summary>
    /// <returns>The time that this entry started.</returns>
    public extern DateTime StartTime { [MethodImpl] get; [MethodImpl] set; }
  }
}
