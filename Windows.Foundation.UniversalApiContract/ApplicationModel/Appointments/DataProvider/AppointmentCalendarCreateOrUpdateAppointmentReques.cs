// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Appointments.DataProvider.AppointmentCalendarCreateOrUpdateAppointmentRequest
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Appointments.DataProvider
{
  /// <summary>Represents the user's request to change the response to a calendar meeting.</summary>
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class AppointmentCalendarCreateOrUpdateAppointmentRequest : 
    IAppointmentCalendarCreateOrUpdateAppointmentRequest
  {
    /// <summary>Gets a string that uniquely identifies the calendar associated with the appointment on the local device.</summary>
    /// <returns>A string that uniquely identifies the calendar on the local device.</returns>
    public extern string AppointmentCalendarLocalId { [MethodImpl] get; }

    /// <summary>Gets the appointment to create or update.</summary>
    /// <returns>The appointment to create or update.</returns>
    public extern Appointment Appointment { [MethodImpl] get; }

    /// <summary>Gets a Boolean value indicating if invitees should be notified.</summary>
    /// <returns>A Boolean value indicating if invitees should be notified.</returns>
    public extern bool NotifyInvitees { [MethodImpl] get; }

    /// <summary>Gets a list of properties that the user wished to change or set in an appointment.</summary>
    /// <returns>A list of appointment properties.</returns>
    public extern IVectorView<string> ChangedProperties { [MethodImpl] get; }

    /// <summary>Notifies the system that the task of creating or updating an appointment has completed.</summary>
    /// <param name="createdOrUpdatedAppointment">The calendar appointment that has been created or updated.</param>
    /// <returns>An asynchronous operation.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction ReportCompletedAsync(
      Appointment createdOrUpdatedAppointment);

    /// <summary>Notifies the system that the task of creating or updating an appointment has failed.</summary>
    /// <returns>An asynchronous operation.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction ReportFailedAsync();
  }
}
