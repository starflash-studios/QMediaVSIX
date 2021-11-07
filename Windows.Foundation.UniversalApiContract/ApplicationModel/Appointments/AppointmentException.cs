// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Appointments.AppointmentException
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Appointments
{
  /// <summary>Represents an appointment instance that is an exception from the master appointment.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  public sealed class AppointmentException : IAppointmentException
  {
    /// <summary>Gets the appointment that is an exception from the master appointment.</summary>
    /// <returns>The appointment that is an exception from the master appointment.</returns>
    public extern Appointment Appointment { [MethodImpl] get; }

    /// <summary>Gets a list of the names of the appointment properties for which an exception was found.</summary>
    /// <returns>A list of the names of the appointment properties for which an exception was found.</returns>
    public extern IVectorView<string> ExceptionProperties { [MethodImpl] get; }

    /// <summary>Gets a value indicating whether the exception is that the appointment instance has been deleted.</summary>
    /// <returns>A value indicating whether the exception is that the appointment instance has been deleted.</returns>
    public extern bool IsDeleted { [MethodImpl] get; }
  }
}
