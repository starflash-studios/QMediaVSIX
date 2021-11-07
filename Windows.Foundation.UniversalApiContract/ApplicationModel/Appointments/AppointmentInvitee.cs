// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Appointments.AppointmentInvitee
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Appointments
{
  /// <summary>Represents a participant of an appointment in a calendar.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class AppointmentInvitee : IAppointmentInvitee, IAppointmentParticipant
  {
    /// <summary>Initializes a new instance of the AppointmentInvitee class.</summary>
    [MethodImpl]
    public extern AppointmentInvitee();

    /// <summary>Gets or sets a AppointmentParticipantRole -typed value that indicates the role of a participant concerning an appointment invitation.</summary>
    /// <returns>A AppointmentParticipantRole -typed value that indicates the role of a participant concerning an appointment invitation.</returns>
    public extern AppointmentParticipantRole Role { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a AppointmentParticipantResponse -typed value that indicates the response from a participant concerning an appointment invitation.</summary>
    /// <returns>A AppointmentParticipantResponse -typed value that indicates the response from a participant concerning an appointment invitation.</returns>
    public extern AppointmentParticipantResponse Response { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a string that communicates the display name of a participant of an appointment. The display name is inherited from IAppointmentParticipant, of type String, and a maximum of 256 characters in length.</summary>
    /// <returns>The display name of a participant of an appointment.</returns>
    public extern string DisplayName { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a string that communicates the address of a participant of an appointment. The address is inherited from IAppointmentParticipant and is a Simple Mail Transfer Protocol (SMTP) e-mail address. It is also of type String and between 1 and 321 characters in length (non-empty).</summary>
    /// <returns>The address of a participant of an appointment.</returns>
    public extern string Address { [MethodImpl] get; [MethodImpl] set; }
  }
}
