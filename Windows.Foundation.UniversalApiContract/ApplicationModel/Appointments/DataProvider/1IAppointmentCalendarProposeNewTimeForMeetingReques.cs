// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Appointments.DataProvider.IAppointmentCalendarProposeNewTimeForMeetingRequestEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Appointments.DataProvider
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(3537336280, 65233, 17024, 163, 186, 46, 31, 71, 96, 154, 162)]
  [ExclusiveTo(typeof (AppointmentCalendarProposeNewTimeForMeetingRequestEventArgs))]
  internal interface IAppointmentCalendarProposeNewTimeForMeetingRequestEventArgs
  {
    AppointmentCalendarProposeNewTimeForMeetingRequest Request { get; }

    Deferral GetDeferral();
  }
}
