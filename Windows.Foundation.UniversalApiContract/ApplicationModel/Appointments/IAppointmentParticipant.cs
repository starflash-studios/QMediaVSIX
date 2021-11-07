// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Appointments.IAppointmentParticipant
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Appointments
{
  /// <summary>Provides info about a participant of an appointment in a calendar.</summary>
  [Guid(1633560834, 38680, 18043, 131, 251, 178, 147, 161, 145, 33, 222)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public interface IAppointmentParticipant
  {
    /// <summary>Gets or sets a string that communicates the display name of a participant of an appointment. The display name is optional, of type String, and a maximum of 256 characters in length.</summary>
    /// <returns>The display name of a participant of an appointment.</returns>
    string DisplayName { get; set; }

    /// <summary>Gets or sets a string that communicates the address of a participant of an appointment. The address is required and is a Simple Mail Transfer Protocol (SMTP) e-mail address. It is also of type String and between 1 and 321 characters in length (non-empty).</summary>
    /// <returns>The address of a participant of an appointment.</returns>
    string Address { get; set; }
  }
}
