// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Appointments.DataProvider.IAppointmentCalendarUpdateMeetingResponseRequestEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Appointments.DataProvider
{
  [Guid(2289408131, 38847, 18333, 174, 213, 11, 232, 206, 86, 125, 30)]
  [ExclusiveTo(typeof (AppointmentCalendarUpdateMeetingResponseRequestEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IAppointmentCalendarUpdateMeetingResponseRequestEventArgs
  {
    AppointmentCalendarUpdateMeetingResponseRequest Request { get; }

    Deferral GetDeferral();
  }
}
