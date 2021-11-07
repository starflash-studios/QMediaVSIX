// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Appointments.AppointmentOrganizer
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Appointments
{
  /// <summary>Represents the organizer of an appointment in a calendar.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class AppointmentOrganizer : IAppointmentParticipant
  {
    /// <summary>Initializes a new instance of the AppointmentOrganizer class.</summary>
    [MethodImpl]
    public extern AppointmentOrganizer();

    /// <summary>Gets or sets a string that communicates the display name of the organizer of an appointment. The display name is optional, inherited from IAppointmentParticipant, of type String, and a maximum of 256 characters in length.</summary>
    /// <returns>The display name of the organizer of an appointment.</returns>
    public extern string DisplayName { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a string that communicates the address of the organizer of an appointment. The address is required, inherited from IAppointmentParticipant, and a Simple Mail Transfer Protocol (SMTP) e-mail address. It is also of type String and between 1 and 321 characters in length (non-empty).</summary>
    /// <returns>The address of the organizer of an appointment.</returns>
    public extern string Address { [MethodImpl] get; [MethodImpl] set; }
  }
}
