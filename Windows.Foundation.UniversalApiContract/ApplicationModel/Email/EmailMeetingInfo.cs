// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Email.EmailMeetingInfo
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.ApplicationModel.Appointments;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Email
{
  /// <summary>Represents the information associated with a meeting.</summary>
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class EmailMeetingInfo : IEmailMeetingInfo, IEmailMeetingInfo2
  {
    /// <summary>Initializes a new instance of the  class.</summary>
    [MethodImpl]
    public extern EmailMeetingInfo();

    /// <summary>Gets or sets a Boolean value indicating whether the proposal of a new time is allowed.</summary>
    /// <returns>A Boolean value indicating whether the proposal of a new time is allowed.</returns>
    public extern bool AllowNewTimeProposal { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the server identifier for the appointment associated with an email message.</summary>
    /// <returns>The server identifier for the appointment associated with an email message.</returns>
    public extern string AppointmentRoamingId { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the start time for a meeting.</summary>
    /// <returns>The start time for a meeting.</returns>
    public extern IReference<DateTime> AppointmentOriginalStartTime { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the duration of the meeting.</summary>
    /// <returns>The duration of the meeting.</returns>
    public extern TimeSpan Duration { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a Boolean value indicating whether the meeting is an all day event.</summary>
    /// <returns>A Boolean value indicating whether the meeting is an all day event.</returns>
    public extern bool IsAllDay { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a Boolean value indicating whether a response to the meeting request is required.</summary>
    /// <returns>A Boolean value indicating whether a response to the meeting request is required.</returns>
    public extern bool IsResponseRequested { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the meeting location.</summary>
    /// <returns>The meeting location.</returns>
    public extern string Location { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the proposed start time for the proposed meeting change.</summary>
    /// <returns>The proposed start time for the proposed meeting change.</returns>
    public extern IReference<DateTime> ProposedStartTime { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the proposed duration for the proposed meeting change.</summary>
    /// <returns>The proposed duration for the proposed meeting change.</returns>
    public extern IReference<TimeSpan> ProposedDuration { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the first instance of the recurrence pattern.</summary>
    /// <returns>The first instance of the recurrence pattern.</returns>
    public extern IReference<DateTime> RecurrenceStartTime { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the recurrence parameters.</summary>
    /// <returns>The recurrence parameters.</returns>
    public extern AppointmentRecurrence Recurrence { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the change number on the server that identifies the meeting email change number.</summary>
    /// <returns>The change number on the server that identifies the meeting email change number.</returns>
    public extern ulong RemoteChangeNumber { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the start time for the meeting.</summary>
    /// <returns>The start time for the meeting.</returns>
    public extern DateTime StartTime { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets a Boolean value indicating if the meeting is reported as out of date by the server.</summary>
    /// <returns>A Boolean value indicating if the meeting is reported as out of date by the server.</returns>
    public extern bool IsReportedOutOfDateByServer { [MethodImpl] get; }
  }
}
