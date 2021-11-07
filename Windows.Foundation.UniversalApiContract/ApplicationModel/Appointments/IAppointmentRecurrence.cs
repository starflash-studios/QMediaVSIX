// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Appointments.IAppointmentRecurrence
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Appointments
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3631955587, 5542, 18555, 185, 89, 12, 54, 30, 96, 233, 84)]
  [ExclusiveTo(typeof (AppointmentRecurrence))]
  internal interface IAppointmentRecurrence
  {
    AppointmentRecurrenceUnit Unit { get; set; }

    IReference<uint> Occurrences { get; set; }

    IReference<DateTime> Until { get; set; }

    uint Interval { get; set; }

    AppointmentDaysOfWeek DaysOfWeek { get; set; }

    AppointmentWeekOfMonth WeekOfMonth { get; set; }

    uint Month { get; set; }

    uint Day { get; set; }
  }
}
