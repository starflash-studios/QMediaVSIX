// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Appointments.DataProvider.IAppointmentCalendarCancelMeetingRequestEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Appointments.DataProvider
{
  [ExclusiveTo(typeof (AppointmentCalendarCancelMeetingRequestEventArgs))]
  [Guid(444186134, 32560, 20021, 190, 239, 157, 44, 123, 109, 202, 225)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IAppointmentCalendarCancelMeetingRequestEventArgs
  {
    AppointmentCalendarCancelMeetingRequest Request { get; }

    Deferral GetDeferral();
  }
}
