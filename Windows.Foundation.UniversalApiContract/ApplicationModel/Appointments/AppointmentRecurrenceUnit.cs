// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Appointments.AppointmentRecurrenceUnit
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Appointments
{
  /// <summary>Specifies the frequency for which an appointment occurs.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum AppointmentRecurrenceUnit
  {
    /// <summary>Appointment occurs daily.</summary>
    Daily,
    /// <summary>Appointment occurs weekly.</summary>
    Weekly,
    /// <summary>Appointment occurs monthly.</summary>
    Monthly,
    /// <summary>Appointment occurs monthly on a particular day of the month.</summary>
    MonthlyOnDay,
    /// <summary>Appointment occurs yearly.</summary>
    Yearly,
    /// <summary>Appointment occurs yearly on a particular day of the year.</summary>
    YearlyOnDay,
  }
}
