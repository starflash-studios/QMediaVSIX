// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Appointments.AppointmentManagerForUser
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.System;
using Windows.UI.Popups;

namespace Windows.ApplicationModel.Appointments
{
  /// <summary>Represents an appointment manager for a specific user.</summary>
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class AppointmentManagerForUser : IAppointmentManagerForUser
  {
    /// <summary>Shows the Appointments provider Add Appointment UI, to enable the user to add an appointment.</summary>
    /// <param name="appointment">The object representing the information for the appointment to add.</param>
    /// <param name="selection">The Rect is the rectangular area of user selection (for example, pressing a button), around which the operating system displays the Add Appointment UI, not within that rectangular area. For example, if an app uses a button to show the Rect, pass the Rect of the button so the Add Appointment UI displays around the button, not overlapping it.</param>
    /// <returns>When this method completes, it returns a **String** object that represents the appointment. This serves as an appointment identifier for future reference when updating or removing. If the appointment identifier returned is an empty string, the appointment was not added to the Appointments provider app.</returns>
    [Overload("ShowAddAppointmentAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<string> ShowAddAppointmentAsync(
      Appointment appointment,
      Rect selection);

    /// <summary>Shows the Appointments provider Add Appointment UI, to enable the user to add an appointment.</summary>
    /// <param name="appointment">The object representing the information for the appointment to add.</param>
    /// <param name="selection">The Rect is the rectangular area of user selection (for example, pressing a button), around which the operating system displays the Add Appointment UI, not within that rectangular area. For example, if an app uses a button to show the Rect, pass the Rect of the button so the Add Appointment UI displays around the button, not overlapping it.</param>
    /// <param name="preferredPlacement">The Placement that describes the preferred placement of the Add Appointment UI.</param>
    /// <returns>When this method completes, it returns a **String** object that represents the appointment. This serves as an appointment identifier for future reference when updating or removing. If the appointment identifier returned is an empty string, the appointment was not added to the Appointments provider app.</returns>
    [RemoteAsync]
    [Overload("ShowAddAppointmentWithPlacementAsync")]
    [MethodImpl]
    public extern IAsyncOperation<string> ShowAddAppointmentAsync(
      Appointment appointment,
      Rect selection,
      Placement preferredPlacement);

    /// <summary>Shows the Appointments provider Replace Appointment UI, to enable the user to replace an appointment.</summary>
    /// <param name="appointmentId">The appointment identifier of the current appointment. This is typically obtained from the async return value of a previous ShowAddAppointmentAsync or ShowReplaceAppointmentAsync call.</param>
    /// <param name="appointment">The object representing the information for the appointment to replace the current appointment.</param>
    /// <param name="selection">The Rect is the rectangular area of user selection (for example, pressing a button), around which the operating system displays the Replace Appointment UI, not within that rectangular area. For example, if an app uses a button to show the Rect, pass the Rect of the button so the Replace Appointment UI displays around the button, not overlapping it.</param>
    /// <returns>When this method completes, it returns a **String** object that represents the appointment. This serves as an appointment identifier for future reference when updating or removing. If the appointment identifier returned is an empty string, the appointment was not replaced in the Appointments provider app.</returns>
    [Overload("ShowReplaceAppointmentAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<string> ShowReplaceAppointmentAsync(
      string appointmentId,
      Appointment appointment,
      Rect selection);

    /// <summary>Shows the Appointments provider Replace Appointment UI, to enable the user to replace an appointment.</summary>
    /// <param name="appointmentId">The appointment identifier of the current appointment. This is typically obtained from the async return value of a previous ShowAddAppointmentAsync or ShowReplaceAppointmentAsync call.</param>
    /// <param name="appointment">The object representing the information for the appointment to replace the current appointment.</param>
    /// <param name="selection">The Rect is the rectangular area of user selection (for example, pressing a button), around which the operating system displays the Replace Appointment UI, not within that rectangular area. For example, if an app uses a button to show the Rect, pass the Rect of the button so the Replace Appointment UI displays around the button, not overlapping it.</param>
    /// <param name="preferredPlacement">The Placement that describes the preferred placement of the Replace Appointment UI.</param>
    /// <returns>When this method completes, it returns a **String** object that represents the appointment. This serves as an appointment identifier for future reference when updating or removing. If the appointment identifier returned is an empty string, the appointment was not replaced in the Appointments provider app.</returns>
    [Overload("ShowReplaceAppointmentWithPlacementAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<string> ShowReplaceAppointmentAsync(
      string appointmentId,
      Appointment appointment,
      Rect selection,
      Placement preferredPlacement);

    [RemoteAsync]
    [Overload("ShowReplaceAppointmentWithPlacementAndDateAsync")]
    [MethodImpl]
    public extern IAsyncOperation<string> ShowReplaceAppointmentAsync(
      string appointmentId,
      Appointment appointment,
      Rect selection,
      Placement preferredPlacement,
      DateTime instanceStartDate);

    /// <summary>Shows the Appointments provider Remove Appointment UI, to enable the user to remove an appointment.</summary>
    /// <param name="appointmentId">The appointment identifier. This is typically obtained from the async return value of a previous ShowAddAppointmentAsync call.</param>
    /// <param name="selection">The Rect is the rectangular area of user selection (for example, pressing a button), around which the operating system displays the Remove Appointment UI, not within that rectangular area. For example, if an app uses a button to show the Rect, pass the Rect of the button so the Remove Appointment UI displays around the button, not overlapping it.</param>
    /// <returns>When this method completes, it returns a **Boolean** value that indicates whether the Appointment provider app removed the appointment.</returns>
    [Overload("ShowRemoveAppointmentAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> ShowRemoveAppointmentAsync(
      string appointmentId,
      Rect selection);

    /// <summary>Shows the Appointments provider Remove Appointment UI, to enable the user to remove an appointment.</summary>
    /// <param name="appointmentId">The appointment identifier. This is typically obtained from the async return value of a previous ShowAddAppointmentAsync call.</param>
    /// <param name="selection">The Rect is the rectangular area of user selection (for example, pressing a button), around which the operating system displays the Remove Appointment UI, not within that rectangular area. For example, if an app uses a button to show the Rect, pass the Rect of the button so the Remove Appointment UI displays around the button, not overlapping it.</param>
    /// <param name="preferredPlacement">The Placement that describes the preferred placement of the Remove Appointment UI.</param>
    /// <returns>When this method completes, it returns a **Boolean** value that indicates whether the Appointment provider app removed the appointment.</returns>
    [RemoteAsync]
    [Overload("ShowRemoveAppointmentWithPlacementAsync")]
    [MethodImpl]
    public extern IAsyncOperation<bool> ShowRemoveAppointmentAsync(
      string appointmentId,
      Rect selection,
      Placement preferredPlacement);

    [Overload("ShowRemoveAppointmentWithPlacementAndDateAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> ShowRemoveAppointmentAsync(
      string appointmentId,
      Rect selection,
      Placement preferredPlacement,
      DateTime instanceStartDate);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction ShowTimeFrameAsync(
      DateTime timeToShow,
      TimeSpan duration);

    /// <summary>Shows the Appointments provider Appointment Details UI, to enable the user to view the specified appointment.</summary>
    /// <param name="appointmentId">The LocalId of the appointment to be displayed.</param>
    /// <returns>When this method returns, it does not return a result. On completion, the AsyncActionCompletedHandler  specified by get_Completed / Completed is invoked.</returns>
    [Overload("ShowAppointmentDetailsAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction ShowAppointmentDetailsAsync(string appointmentId);

    [RemoteAsync]
    [Overload("ShowAppointmentDetailsWithDateAsync")]
    [MethodImpl]
    public extern IAsyncAction ShowAppointmentDetailsAsync(
      string appointmentId,
      DateTime instanceStartDate);

    /// <summary>Shows the Appointments provider Add Appointment UI including the full edit experience, to enable the user to add an appointment.</summary>
    /// <param name="appointment">The new appointment to be added.</param>
    /// <returns>An asynchronous operation that returns a string containing an appointment ID upon successful completion.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<string> ShowEditNewAppointmentAsync(
      Appointment appointment);

    /// <summary>Retrieves an AppointmentStore object that enables searching or retrieving appointments on the device.</summary>
    /// <param name="options">Specifies the type of read/write access requested.</param>
    /// <returns>An asynchronous operation that returns an AppointmentStore object upon successful completion.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<AppointmentStore> RequestStoreAsync(
      AppointmentStoreAccessType options);

    /// <summary>Gets the User represented by this appointment manager.</summary>
    /// <returns>The User represented by this appointment manager.</returns>
    public extern User User { [MethodImpl] get; }
  }
}
