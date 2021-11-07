// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Appointments.DataProvider.AppointmentCalendarUpdateMeetingResponseRequest
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Appointments.DataProvider
{
  /// <summary>Represents the user's request to change the response to a calendar meeting.</summary>
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class AppointmentCalendarUpdateMeetingResponseRequest : 
    IAppointmentCalendarUpdateMeetingResponseRequest
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

    /// <summary>Gets the new response the user wishes to give concerning an appointment invitation.</summary>
    /// <returns>The new response the user wishes to give.</returns>
    public extern AppointmentParticipantResponse Response { [MethodImpl] get; }

    /// <summary>Gets the subject of the response.</summary>
    /// <returns>The subject of the response.</returns>
    public extern string Subject { [MethodImpl] get; }

    /// <summary>Gets a text comment the user may write regarding the change in meeting response.</summary>
    /// <returns>A text comment by the user regarding the change in meeting response.</returns>
    public extern string Comment { [MethodImpl] get; }

    /// <summary>Indicates whether the user wishes to send an update to the meeting's organizer.</summary>
    /// <returns>The Boolean value indicating whether or not to send the response to the meeting organizer.</returns>
    public extern bool SendUpdate { [MethodImpl] get; }

    /// <summary>Notifies the system that the task of updating a meeting response has completed.</summary>
    /// <returns>An asynchronous operation.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction ReportCompletedAsync();

    /// <summary>Notifies the system that the task of updating a meeting response has failed.</summary>
    /// <returns>An asynchronous operation.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction ReportFailedAsync();
  }
}
