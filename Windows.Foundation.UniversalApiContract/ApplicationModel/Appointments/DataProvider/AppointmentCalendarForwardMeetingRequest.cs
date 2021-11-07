// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Appointments.DataProvider.AppointmentCalendarForwardMeetingRequest
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Appointments.DataProvider
{
  /// <summary>Represents the user's request to forward a calendar meeting.</summary>
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  public sealed class AppointmentCalendarForwardMeetingRequest : 
    IAppointmentCalendarForwardMeetingRequest
  {
    /// <summary>Gets a string that uniquely identifies the calendar associated with the appointment on the local device.</summary>
    /// <returns>A string that uniquely identifies the calendar on the local device.</returns>
    public extern string AppointmentCalendarLocalId { [MethodImpl] get; }

    /// <summary>Gets a string that uniquely identifies the appointment on the local device.</summary>
    /// <returns>A string that uniquely identifies the appointment on the local device.</returns>
    public extern string AppointmentLocalId { [MethodImpl] get; }

    /// <summary>Gets the original starting time for a recurring appointment.</summary>
    /// <returns>The original starting time for a recurring appointment.</returns>
    public extern IReference<DateTime> AppointmentOriginalStartTime { [MethodImpl] get; }

    /// <summary>Gets a list of the new invitees to receive the forwarded meeting.</summary>
    /// <returns>A list of new invitees.</returns>
    public extern IVectorView<AppointmentInvitee> Invitees { [MethodImpl] get; }

    /// <summary>Gets the subject of the forwarded meeting invitation.</summary>
    /// <returns>The subject of the forwarded meeting invitation.</returns>
    public extern string Subject { [MethodImpl] get; }

    /// <summary>Gets the new meeting header that includes the new invitees.</summary>
    /// <returns>The new meeting header for the new invitees.</returns>
    public extern string ForwardHeader { [MethodImpl] get; }

    /// <summary>Gets a text comment the user may write regarding the forwarding of the meeting.</summary>
    /// <returns>A text comment by the user regarding the forwarding of the meeting.</returns>
    public extern string Comment { [MethodImpl] get; }

    /// <summary>Notifies the system that the task of forwarding a meeting has completed.</summary>
    /// <returns>An asynchronous operation.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction ReportCompletedAsync();

    /// <summary>Notifies the system that the task of forwarding a meeting has failed.</summary>
    /// <returns>An asynchronous operation.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction ReportFailedAsync();
  }
}
