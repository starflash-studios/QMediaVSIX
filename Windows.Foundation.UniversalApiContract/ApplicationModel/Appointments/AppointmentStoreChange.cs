// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Appointments.AppointmentStoreChange
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Appointments
{
  /// <summary>Represents a change that has occurred in an appointment store.</summary>
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class AppointmentStoreChange : IAppointmentStoreChange, IAppointmentStoreChange2
  {
    /// <summary>Gets the Appointment associated with the change.</summary>
    /// <returns>The Appointment associated with the change.</returns>
    public extern Appointment Appointment { [MethodImpl] get; }

    /// <summary>Gets an AppointmentStoreChangeType value indicating the type of change represented by the object.</summary>
    /// <returns>An AppointmentStoreChangeType value indicating the type of change represented by the object.</returns>
    public extern AppointmentStoreChangeType ChangeType { [MethodImpl] get; }

    /// <summary>Gets the AppointmentCalendar in which the change occurred.</summary>
    /// <returns>The AppointmentCalendar in which the change occurred.</returns>
    public extern AppointmentCalendar AppointmentCalendar { [MethodImpl] get; }
  }
}
