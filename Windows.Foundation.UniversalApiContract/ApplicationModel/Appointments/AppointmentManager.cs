// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Appointments.AppointmentManager
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
  /// <summary>Provides API to interact with the user’s Appointments provider app (for example, the Calendar app). Call static methods to display provider-specific UI so that the user can perform tasks.</summary>
  [Static(typeof (IAppointmentManagerStatics3), 196608, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IAppointmentManagerStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IAppointmentManagerStatics2), 65536, "Windows.Foundation.UniversalApiContract")]
  public static class AppointmentManager
  {
    /// <summary>Gets the AppointmentManagerForUser object for the specified user.</summary>
    /// <param name="user">The user account to use to get the AppointmentManagerForUser object.</param>
    /// <returns>Returns the appointment manager for the account specified by the *user* parameter.</returns>
    [MethodImpl]
    public static extern AppointmentManagerForUser GetForUser(User user);

    /// <summary>Shows the Appointments provider Appointment Details UI, to enable the user to view the specified appointment.</summary>
    /// <param name="appointmentId">The LocalId of the appointment to be displayed.</param>
    /// <returns>When this method returns, it does not return a result. On completion, the AsyncActionCompletedHandler  specified by get_Completed / Completed is invoked.</returns>
    [RemoteAsync]
    [Overload("ShowAppointmentDetailsAsync")]
    [MethodImpl]
    public static extern IAsyncAction ShowAppointmentDetailsAsync(string appointmentId);

    [RemoteAsync]
    [Overload("ShowAppointmentDetailsWithDateAsync")]
    [MethodImpl]
    public static extern IAsyncAction ShowAppointmentDetailsAsync(
      string appointmentId,
      DateTime instanceStartDate);

    /// <summary>Shows the Appointments provider Add Appointment UI including the full edit experience, to enable the user to add an appointment.</summary>
    /// <param name="appointment">The appointment to be added.</param>
    /// <returns>An asynchronous operation that returns a string containing an appointment ID upon successful completion.</returns>
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<string> ShowEditNewAppointmentAsync(
      Appointment appointment);

    /// <summary>Requests the AppointmentStore object associated with the calling application.</summary>
    /// <param name="options">An AppointmentStoreAccessType value indicating the level of access the returned appointment store will have.</param>
    /// <returns>An asynchronous operation that returns an AppointmentStore upon successful completion.</returns>
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<AppointmentStore> RequestStoreAsync(
      AppointmentStoreAccessType options);

    /// <summary>Shows the Appointments provider Add Appointment UI, to enable the user to add an appointment.</summary>
    /// <param name="appointment">The object representing the information for the appointment to add.</param>
    /// <param name="selection">The Rect is the rectangular area of user selection (for example, pressing a button), around which the operating system displays the Add Appointment UI, not within that rectangular area. For example, if an app uses a button to show the Rect, pass the Rect of the button so the Add Appointment UI displays around the button, not overlapping it.</param>
    /// <returns>When this method completes, it returns a **String** object that represents the appointment. This serves as an appointment identifier for future reference when updating or removing. If the appointment identifier returned is an empty string, the appointment was not added to the Appointments provider app.</returns>
    [Overload("ShowAddAppointmentAsync")]
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<string> ShowAddAppointmentAsync(
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
    public static extern IAsyncOperation<string> ShowAddAppointmentAsync(
      Appointment appointment,
      Rect selection,
      Placement preferredPlacement);

    /// <summary>Shows the Appointments provider Replace Appointment UI, to enable the user to replace an appointment.</summary>
    /// <param name="appointmentId">The appointment identifier of the current appointment. This is typically obtained from the async return value of a previous ShowAddAppointmentAsync or ShowReplaceAppointmentAsync call.</param>
    /// <param name="appointment">The object representing the information for the appointment to replace the current appointment.</param>
    /// <param name="selection">The Rect is the rectangular area of user selection (for example, pressing a button), around which the operating system displays the Replace Appointment UI, not within that rectangular area. For example, if an app uses a button to show the Rect, pass the Rect of the button so the Replace Appointment UI displays around the button, not overlapping it.</param>
    /// <returns>When this method completes, it returns a **String** object that represents the appointment. This serves as an appointment identifier for future reference when updating or removing. If the appointment identifier returned is an empty string, the appointment was not replaced in the Appointments provider app.</returns>
    [RemoteAsync]
    [Overload("ShowReplaceAppointmentAsync")]
    [MethodImpl]
    public static extern IAsyncOperation<string> ShowReplaceAppointmentAsync(
      string appointmentId,
      Appointment appointment,
      Rect selection);

    /// <summary>Shows the Appointments provider Replace Appointment UI, to enable the user to replace an appointment.</summary>
    /// <param name="appointmentId">The appointment identifier of the current appointment. This is typically obtained from the async return value of a previous ShowAddAppointmentAsync or ShowReplaceAppointmentAsync call.</param>
    /// <param name="appointment">The object representing the information for the appointment to replace the current appointment.</param>
    /// <param name="selection">The Rect is the rectangular area of user selection (for example, pressing a button), around which the operating system displays the Replace Appointment UI, not within that rectangular area. For example, if an app uses a button to show the Rect, pass the Rect of the button so the Replace Appointment UI displays around the button, not overlapping it.</param>
    /// <param name="preferredPlacement">The Placement that describes the preferred placement of the Replace Appointment UI.</param>
    /// <returns>When this method completes, it returns a **String** object that represents the appointment. This serves as an appointment identifier for future reference when updating or removing. If the appointment identifier returned is an empty string, the appointment was not replaced in the Appointments provider app.</returns>
    [RemoteAsync]
    [Overload("ShowReplaceAppointmentWithPlacementAsync")]
    [MethodImpl]
    public static extern IAsyncOperation<string> ShowReplaceAppointmentAsync(
      string appointmentId,
      Appointment appointment,
      Rect selection,
      Placement preferredPlacement);

    [RemoteAsync]
    [Overload("ShowReplaceAppointmentWithPlacementAndDateAsync")]
    [MethodImpl]
    public static extern IAsyncOperation<string> ShowReplaceAppointmentAsync(
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
    public static extern IAsyncOperation<bool> ShowRemoveAppointmentAsync(
      string appointmentId,
      Rect selection);

    /// <summary>Shows the Appointments provider Remove Appointment UI, to enable the user to remove an appointment.</summary>
    /// <param name="appointmentId">The appointment identifier. This is typically obtained from the async return value of a previous ShowAddAppointmentAsync call.</param>
    /// <param name="selection">The Rect is the rectangular area of user selection (for example, pressing a button), around which the operating system displays the Remove Appointment UI, not within that rectangular area. For example, if an app uses a button to show the Rect, pass the Rect of the button so the Remove Appointment UI displays around the button, not overlapping it.</param>
    /// <param name="preferredPlacement">The Placement that describes the preferred placement of the Remove Appointment UI.</param>
    /// <returns>When this method completes, it returns a **Boolean** value that indicates whether the Appointment provider app removed the appointment.</returns>
    [Overload("ShowRemoveAppointmentWithPlacementAsync")]
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<bool> ShowRemoveAppointmentAsync(
      string appointmentId,
      Rect selection,
      Placement preferredPlacement);

    [Overload("ShowRemoveAppointmentWithPlacementAndDateAsync")]
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<bool> ShowRemoveAppointmentAsync(
      string appointmentId,
      Rect selection,
      Placement preferredPlacement,
      DateTime instanceStartDate);

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncAction ShowTimeFrameAsync(
      DateTime timeToShow,
      TimeSpan duration);
  }
}
