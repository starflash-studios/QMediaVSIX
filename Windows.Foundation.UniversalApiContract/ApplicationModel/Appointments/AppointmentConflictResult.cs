// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Appointments.AppointmentConflictResult
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Appointments
{
  /// <summary>Represents a conflict between appointments.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  public sealed class AppointmentConflictResult : IAppointmentConflictResult
  {
    /// <summary>Gets a value indicating the type of appointment conflict.</summary>
    /// <returns>A value indicating the type of appointment conflict.</returns>
    public extern AppointmentConflictType Type { [MethodImpl] get; }

    /// <summary>Gets the date of the appointment conflict.</summary>
    /// <returns>The date of the appointment conflict.</returns>
    public extern DateTime Date { [MethodImpl] get; }
  }
}
