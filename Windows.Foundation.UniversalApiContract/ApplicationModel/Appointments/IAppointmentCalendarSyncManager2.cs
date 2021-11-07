// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Appointments.IAppointmentCalendarSyncManager2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Appointments
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (AppointmentCalendarSyncManager))]
  [Guid(1685399725, 3369, 19580, 170, 167, 191, 153, 104, 5, 83, 124)]
  internal interface IAppointmentCalendarSyncManager2
  {
    AppointmentCalendarSyncStatus Status { set; }

    DateTime LastSuccessfulSyncTime { set; }

    DateTime LastAttemptedSyncTime { set; }
  }
}
