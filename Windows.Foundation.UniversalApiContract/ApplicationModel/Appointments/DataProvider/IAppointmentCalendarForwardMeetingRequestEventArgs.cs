// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Appointments.DataProvider.IAppointmentCalendarForwardMeetingRequestEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Appointments.DataProvider
{
  [Guid(822678810, 9122, 17149, 156, 130, 201, 166, 13, 89, 248, 168)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (AppointmentCalendarForwardMeetingRequestEventArgs))]
  internal interface IAppointmentCalendarForwardMeetingRequestEventArgs
  {
    AppointmentCalendarForwardMeetingRequest Request { get; }

    Deferral GetDeferral();
  }
}
