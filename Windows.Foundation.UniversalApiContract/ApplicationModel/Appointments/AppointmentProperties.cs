// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Appointments.AppointmentProperties
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Appointments
{
  /// <summary>Provides strings that identify the properties of an appointment.</summary>
  [Static(typeof (IAppointmentPropertiesStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IAppointmentPropertiesStatics2), 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  public static class AppointmentProperties
  {
    /// <summary>Gets the current change number of the local version of the Appointment.</summary>
    /// <returns>The current change number of the local version of the Appointment.</returns>
    public static extern string ChangeNumber { [MethodImpl] get; }

    /// <summary>Gets or sets the current change number of the server version of the Appointment.</summary>
    /// <returns>The current change number of the server version of the Appointment.</returns>
    public static extern string RemoteChangeNumber { [MethodImpl] get; }

    /// <summary>Gets the format of the appointment details, plain text or HTML.</summary>
    /// <returns>The format of the appointment details, plain text or HTML.</returns>
    public static extern string DetailsKind { [MethodImpl] get; }

    /// <summary>Gets the name of the Subject property.</summary>
    /// <returns>The name of the Subject property.</returns>
    public static extern string Subject { [MethodImpl] get; }

    /// <summary>Gets the name of the Location property.</summary>
    /// <returns>The name of the Location property.</returns>
    public static extern string Location { [MethodImpl] get; }

    /// <summary>Gets the name of the StartTime property.</summary>
    /// <returns>The name of the StartTime property</returns>
    public static extern string StartTime { [MethodImpl] get; }

    /// <summary>Gets the name of the Duration property.</summary>
    /// <returns>The name of the Duration property.</returns>
    public static extern string Duration { [MethodImpl] get; }

    /// <summary>Gets the name of the Reminder property.</summary>
    /// <returns>The name of the Reminder property.</returns>
    public static extern string Reminder { [MethodImpl] get; }

    /// <summary>Gets the name of the BusyStatus property.</summary>
    /// <returns>The name of the BusyStatus property.</returns>
    public static extern string BusyStatus { [MethodImpl] get; }

    /// <summary>Gets the name of the Sensitivity property.</summary>
    /// <returns>The name of the Sensitivity property.</returns>
    public static extern string Sensitivity { [MethodImpl] get; }

    /// <summary>Gets the name of the OriginalStartTime property.</summary>
    /// <returns>The name of the OriginalStartTime property.</returns>
    public static extern string OriginalStartTime { [MethodImpl] get; }

    /// <summary>Gets the name of the IsResponseRequested property.</summary>
    /// <returns>The name of the IsResponseRequested property.</returns>
    public static extern string IsResponseRequested { [MethodImpl] get; }

    /// <summary>Gets the name of AllowNewTimeProposal the property.</summary>
    /// <returns>The name of AllowNewTimeProposal the property.</returns>
    public static extern string AllowNewTimeProposal { [MethodImpl] get; }

    /// <summary>Gets the name of the AllDay property.</summary>
    /// <returns>The name of the AllDay property.</returns>
    public static extern string AllDay { [MethodImpl] get; }

    /// <summary>Gets the name of the Details property.</summary>
    /// <returns>The name of the Details property.</returns>
    public static extern string Details { [MethodImpl] get; }

    /// <summary>Gets the name of the OnlineMeetingLink property.</summary>
    /// <returns>The name of the OnlineMeetingLink property.</returns>
    public static extern string OnlineMeetingLink { [MethodImpl] get; }

    /// <summary>Gets the name of the ReplyTime property.</summary>
    /// <returns>The name of the ReplyTime property.</returns>
    public static extern string ReplyTime { [MethodImpl] get; }

    /// <summary>Gets the name of the Organizer property.</summary>
    /// <returns>The name of the Organizer property.</returns>
    public static extern string Organizer { [MethodImpl] get; }

    /// <summary>Gets the name of the UserResponse property.</summary>
    /// <returns>The name of the UserResponse property.</returns>
    public static extern string UserResponse { [MethodImpl] get; }

    /// <summary>Gets the name of the HasInvitees property.</summary>
    /// <returns>The name of the HasInvitees property.</returns>
    public static extern string HasInvitees { [MethodImpl] get; }

    /// <summary>Gets the name of the IsCanceledMeeting property.</summary>
    /// <returns>The name of the IsCanceledMeeting property.</returns>
    public static extern string IsCanceledMeeting { [MethodImpl] get; }

    /// <summary>Gets the name of the IsOrganizedByUser property.</summary>
    /// <returns>The name of the IsOrganizedByUser property.</returns>
    public static extern string IsOrganizedByUser { [MethodImpl] get; }

    /// <summary>Gets the name of the Recurrence property.</summary>
    /// <returns>The name of the Recurrence property.</returns>
    public static extern string Recurrence { [MethodImpl] get; }

    /// <summary>Gets the name of the Uri property.</summary>
    /// <returns>The name of the Uri property.</returns>
    public static extern string Uri { [MethodImpl] get; }

    /// <summary>Gets the name of the Invitees property.</summary>
    /// <returns>The name of the Invitees property.</returns>
    public static extern string Invitees { [MethodImpl] get; }

    /// <summary>Gets a list of names for the default appointment properties.</summary>
    /// <returns>A list of names for the default appointment properties.</returns>
    public static extern IVector<string> DefaultProperties { [MethodImpl] get; }
  }
}
