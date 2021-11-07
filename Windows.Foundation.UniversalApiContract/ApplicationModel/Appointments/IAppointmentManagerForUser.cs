// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Appointments.IAppointmentManagerForUser
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.System;
using Windows.UI.Popups;

namespace Windows.ApplicationModel.Appointments
{
  [Guid(1881543715, 29644, 18016, 179, 24, 176, 19, 101, 48, 42, 3)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (AppointmentManagerForUser))]
  internal interface IAppointmentManagerForUser
  {
    [RemoteAsync]
    [Overload("ShowAddAppointmentAsync")]
    IAsyncOperation<string> ShowAddAppointmentAsync(
      Appointment appointment,
      Rect selection);

    [Overload("ShowAddAppointmentWithPlacementAsync")]
    [RemoteAsync]
    IAsyncOperation<string> ShowAddAppointmentAsync(
      Appointment appointment,
      Rect selection,
      Placement preferredPlacement);

    [Overload("ShowReplaceAppointmentAsync")]
    [RemoteAsync]
    IAsyncOperation<string> ShowReplaceAppointmentAsync(
      string appointmentId,
      Appointment appointment,
      Rect selection);

    [RemoteAsync]
    [Overload("ShowReplaceAppointmentWithPlacementAsync")]
    IAsyncOperation<string> ShowReplaceAppointmentAsync(
      string appointmentId,
      Appointment appointment,
      Rect selection,
      Placement preferredPlacement);

    [RemoteAsync]
    [Overload("ShowReplaceAppointmentWithPlacementAndDateAsync")]
    IAsyncOperation<string> ShowReplaceAppointmentAsync(
      string appointmentId,
      Appointment appointment,
      Rect selection,
      Placement preferredPlacement,
      DateTime instanceStartDate);

    [RemoteAsync]
    [Overload("ShowRemoveAppointmentAsync")]
    IAsyncOperation<bool> ShowRemoveAppointmentAsync(
      string appointmentId,
      Rect selection);

    [Overload("ShowRemoveAppointmentWithPlacementAsync")]
    [RemoteAsync]
    IAsyncOperation<bool> ShowRemoveAppointmentAsync(
      string appointmentId,
      Rect selection,
      Placement preferredPlacement);

    [Overload("ShowRemoveAppointmentWithPlacementAndDateAsync")]
    [RemoteAsync]
    IAsyncOperation<bool> ShowRemoveAppointmentAsync(
      string appointmentId,
      Rect selection,
      Placement preferredPlacement,
      DateTime instanceStartDate);

    [RemoteAsync]
    IAsyncAction ShowTimeFrameAsync(DateTime timeToShow, TimeSpan duration);

    [RemoteAsync]
    [Overload("ShowAppointmentDetailsAsync")]
    IAsyncAction ShowAppointmentDetailsAsync(string appointmentId);

    [Overload("ShowAppointmentDetailsWithDateAsync")]
    [RemoteAsync]
    IAsyncAction ShowAppointmentDetailsAsync(
      string appointmentId,
      DateTime instanceStartDate);

    [RemoteAsync]
    IAsyncOperation<string> ShowEditNewAppointmentAsync(Appointment appointment);

    [RemoteAsync]
    IAsyncOperation<AppointmentStore> RequestStoreAsync(
      AppointmentStoreAccessType options);

    User User { get; }
  }
}
