// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Appointments.DataProvider.IAppointmentCalendarCreateOrUpdateAppointmentRequestEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Appointments.DataProvider
{
  [Guid(3482185000, 46, 19447, 142, 157, 94, 32, 212, 154, 163, 186)]
  [ExclusiveTo(typeof (AppointmentCalendarCreateOrUpdateAppointmentRequestEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IAppointmentCalendarCreateOrUpdateAppointmentRequestEventArgs
  {
    AppointmentCalendarCreateOrUpdateAppointmentRequest Request { get; }

    Deferral GetDeferral();
  }
}
